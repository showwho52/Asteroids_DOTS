using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

partial class GameStateHandlingSystem : SystemBase
{
    private GameStates m_CurrentGameState = GameStates.None;

    protected override void OnCreate()
    {
        base.OnCreate();

        RequireSingletonForUpdate<GameState>();
    }

    protected override void OnUpdate()
    {
        var gameState = GetSingleton<GameState>();
        if (gameState.Value == m_CurrentGameState)
            return;

        m_CurrentGameState = gameState.Value;

        var ecbSystem = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
        var cmdBuffer = ecbSystem.CreateCommandBuffer().AsParallelWriter();

        Dependency = Entities.ForEach((Entity entity, int entityInQueryIndex, in GameShowState showState, in DynamicBuffer<GameStateObject> gameStateObjects) =>
        {
            for (var i = 0; i < gameStateObjects.Length; i++)
            {
                var isVisible = gameState.Value == showState.Value;

                if (isVisible)
                {
                    cmdBuffer.RemoveComponent<Disabled>(entityInQueryIndex, gameStateObjects[i].Value);
                }
                else
                {
                    cmdBuffer.AddComponent<Disabled>(entityInQueryIndex, gameStateObjects[i].Value);
                }
            }
        }).Schedule(Dependency);

        ecbSystem.AddJobHandleForProducer(Dependency);
    }
}