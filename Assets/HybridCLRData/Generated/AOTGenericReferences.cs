public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ constraint implement type
	// }} 

	// {{ AOT generic type
	//System.Action`1<AudioClipType>
	//System.Action`1<System.Int32>
	//System.Action`1<System.Byte>
	//System.Action`1<UnityEngine.InputSystem.InputAction/CallbackContext>
	//System.Collections.Generic.IEnumerable`1<System.Object>
	//System.Collections.Generic.List`1<System.Object>
	//System.ValueTuple`2<Unity.Mathematics.float3,Unity.Mathematics.float3>
	//System.ValueTuple`2<System.Byte,Unity.Mathematics.float3>
	//Unity.Entities.BufferAccessor`1<GameStateObject>
	//Unity.Entities.BufferFromEntity`1<Health>
	//Unity.Entities.ComponentDataFromEntity`1<Enemy>
	//Unity.Entities.ComponentDataFromEntity`1<Player>
	//Unity.Entities.ComponentDataFromEntity`1<Unity.Transforms.Translation>
	//Unity.Entities.ComponentDataFromEntity`1<PowerUp>
	//Unity.Entities.ComponentDataFromEntity`1<Missile>
	//Unity.Entities.ComponentTypeHandle`1<Player>
	//Unity.Entities.ComponentTypeHandle`1<Unity.Transforms.Translation>
	//Unity.Entities.ComponentTypeHandle`1<Explosion>
	//Unity.Entities.ComponentTypeHandle`1<GameStateData>
	//Unity.Entities.ComponentTypeHandle`1<Unity.Transforms.Rotation>
	//Unity.Entities.DynamicBuffer`1<Health>
	//Unity.Entities.DynamicBuffer`1<GameStateObject>
	//Unity.Entities.DynamicBuffer`1<EnemySpritePrefab>
	// }}

	public void RefMethods()
	{
		// Unity.Entities.BufferAccessor`1<GameStateObject> Unity.Entities.ArchetypeChunk::GetBufferAccessor<GameStateObject>(Unity.Entities.BufferTypeHandle`1<GameStateObject>)
		// Unity.Entities.BufferTypeHandle`1<GameStateObject> Unity.Entities.ComponentSystemBase::GetBufferTypeHandle<GameStateObject>(System.Boolean)
		// Unity.Entities.ComponentTypeHandle`1<Unity.Transforms.Translation> Unity.Entities.ComponentSystemBase::GetComponentTypeHandle<Unity.Transforms.Translation>(System.Boolean)
		// Unity.Entities.ComponentTypeHandle`1<Unity.Transforms.Rotation> Unity.Entities.ComponentSystemBase::GetComponentTypeHandle<Unity.Transforms.Rotation>(System.Boolean)
		// Unity.Entities.ComponentTypeHandle`1<GameStateData> Unity.Entities.ComponentSystemBase::GetComponentTypeHandle<GameStateData>(System.Boolean)
		// Unity.Entities.ComponentTypeHandle`1<Explosion> Unity.Entities.ComponentSystemBase::GetComponentTypeHandle<Explosion>(System.Boolean)
		// Unity.Entities.ComponentTypeHandle`1<Player> Unity.Entities.ComponentSystemBase::GetComponentTypeHandle<Player>(System.Boolean)
		// System.Void Unity.Entities.ComponentSystemBase::RequireSingletonForUpdate<HealthManager>()
		// System.Void Unity.Entities.ComponentSystemBase::RequireSingletonForUpdate<ExplosionSpawner>()
		// System.Void Unity.Entities.ComponentSystemBase::RequireSingletonForUpdate<Player>()
		// System.Void Unity.Entities.ComponentSystemBase::RequireSingletonForUpdate<GameParameters>()
		// System.Void Unity.Entities.ComponentSystemBase::RequireSingletonForUpdate<GameStateData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<HealthManager>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<ExplosionSpawner>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<Explosion>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<GameStateObject>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<GameParameters>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<Player>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<GameStateData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<Missile>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<Enemy>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<PowerUpSpawner>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<System.Object>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<EnemySpawner>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadOnly<PowerUp>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadWrite<Unity.Transforms.Translation>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadWrite<GameParameters>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadWrite<Unity.Transforms.Rotation>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType::ReadWrite<Explosion>()
		// Unity.Entities.DynamicBuffer`1<Health> Unity.Entities.EntityCommandBuffer::AddBuffer<Health>(Unity.Entities.Entity)
		// System.Void Unity.Entities.EntityCommandBuffer::AddComponent<Unity.Entities.Disabled>(Unity.Entities.Entity)
		// System.Void Unity.Entities.EntityCommandBuffer::SetComponent<GameParameters>(Unity.Entities.Entity,GameParameters)
		// System.Void Unity.Entities.EntityCommandBuffer::SetComponent<Unity.Transforms.Translation>(Unity.Entities.Entity,Unity.Transforms.Translation)
		// System.Void Unity.Entities.EntityCommandBuffer/ParallelWriter::AddComponent<Unity.Entities.Disabled>(System.Int32,Unity.Entities.Entity)
		// System.Void Unity.Entities.EntityCommandBuffer/ParallelWriter::RemoveComponent<Unity.Entities.Disabled>(System.Int32,Unity.Entities.Entity)
		// Unity.Entities.DynamicBuffer`1<EnemySpritePrefab> Unity.Entities.EntityManager::AddBuffer<EnemySpritePrefab>(Unity.Entities.Entity)
		// Unity.Entities.DynamicBuffer`1<GameStateObject> Unity.Entities.EntityManager::AddBuffer<GameStateObject>(Unity.Entities.Entity)
		// System.Boolean Unity.Entities.EntityManager::AddComponent<Explosion>(Unity.Entities.Entity)
		// System.Boolean Unity.Entities.EntityManager::AddComponent<Unity.Entities.Disabled>(Unity.Entities.Entity)
		// System.Boolean Unity.Entities.EntityManager::AddComponent<Enemy>(Unity.Entities.Entity)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<ExplosionSpawner>(Unity.Entities.Entity,ExplosionSpawner)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<EnemySpawner>(Unity.Entities.Entity,EnemySpawner)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<Missile>(Unity.Entities.Entity,Missile)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<Player>(Unity.Entities.Entity,Player)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<GameParameters>(Unity.Entities.Entity,GameParameters)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<HealthManager>(Unity.Entities.Entity,HealthManager)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<GameStateData>(Unity.Entities.Entity,GameStateData)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<PowerUpSpawner>(Unity.Entities.Entity,PowerUpSpawner)
		// System.Boolean Unity.Entities.EntityManager::AddComponentData<PowerUp>(Unity.Entities.Entity,PowerUp)
		// Unity.Entities.DynamicBuffer`1<EnemySpritePrefab> Unity.Entities.EntityManager::GetBuffer<EnemySpritePrefab>(Unity.Entities.Entity,System.Boolean)
		// Unity.Transforms.Translation Unity.Entities.EntityManager::GetComponentData<Unity.Transforms.Translation>(Unity.Entities.Entity)
		// Unity.Transforms.Rotation Unity.Entities.EntityManager::GetComponentData<Unity.Transforms.Rotation>(Unity.Entities.Entity)
		// System.Object Unity.Entities.EntityManager::GetComponentObject<System.Object>(Unity.Entities.Entity)
		// System.Boolean Unity.Entities.EntityManager::HasComponent<Unity.Entities.Disabled>(Unity.Entities.Entity)
		// System.Boolean Unity.Entities.EntityManager::RemoveComponent<Unity.Entities.Disabled>(Unity.Entities.Entity)
		// System.Void Unity.Entities.EntityManager::SetComponentData<Unity.Physics.PhysicsVelocity>(Unity.Entities.Entity,Unity.Physics.PhysicsVelocity)
		// System.Void Unity.Entities.EntityManager::SetComponentData<GameParameters>(Unity.Entities.Entity,GameParameters)
		// System.Void Unity.Entities.EntityManager::SetComponentData<Unity.Transforms.Translation>(Unity.Entities.Entity,Unity.Transforms.Translation)
		// System.Void Unity.Entities.EntityManager::SetComponentData<Unity.Transforms.Rotation>(Unity.Entities.Entity,Unity.Transforms.Rotation)
		// EnemySpawner Unity.Entities.EntityQuery::GetSingleton<EnemySpawner>()
		// GameParameters Unity.Entities.EntityQuery::GetSingleton<GameParameters>()
		// Player Unity.Entities.EntityQuery::GetSingleton<Player>()
		// PowerUpSpawner Unity.Entities.EntityQuery::GetSingleton<PowerUpSpawner>()
		// ExplosionSpawner Unity.Entities.EntityQuery::GetSingleton<ExplosionSpawner>()
		// HealthManager Unity.Entities.EntityQuery::GetSingleton<HealthManager>()
		// System.Void Unity.Entities.EntityQuery::SetSingleton<GameParameters>(GameParameters)
		// System.IntPtr Unity.Entities.InternalCompilerInterface::UnsafeGetChunkNativeArrayIntPtr<Unity.Transforms.Rotation>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle`1<Unity.Transforms.Rotation>)
		// System.IntPtr Unity.Entities.InternalCompilerInterface::UnsafeGetChunkNativeArrayIntPtr<Unity.Transforms.Translation>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle`1<Unity.Transforms.Translation>)
		// System.IntPtr Unity.Entities.InternalCompilerInterface::UnsafeGetChunkNativeArrayIntPtr<Explosion>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle`1<Explosion>)
		// System.IntPtr Unity.Entities.InternalCompilerInterface::UnsafeGetChunkNativeArrayReadOnlyIntPtr<Player>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle`1<Player>)
		// System.IntPtr Unity.Entities.InternalCompilerInterface::UnsafeGetChunkNativeArrayReadOnlyIntPtr<GameStateData>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle`1<GameStateData>)
		// System.IntPtr Unity.Entities.InternalCompilerInterface::UnsafeGetChunkNativeArrayReadOnlyIntPtr<Explosion>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle`1<Explosion>)
		// Unity.Entities.Entity Unity.Entities.InternalCompilerInterface::UnsafeGetCopyOfNativeArrayPtrElement<Unity.Entities.Entity>(System.IntPtr,System.Int32)
		// Unity.Transforms.Rotation& Unity.Entities.InternalCompilerInterface::UnsafeGetRefToNativeArrayPtrElement<Unity.Transforms.Rotation>(System.IntPtr,System.Int32)
		// Explosion& Unity.Entities.InternalCompilerInterface::UnsafeGetRefToNativeArrayPtrElement<Explosion>(System.IntPtr,System.Int32)
		// Unity.Transforms.Translation& Unity.Entities.InternalCompilerInterface::UnsafeGetRefToNativeArrayPtrElement<Unity.Transforms.Translation>(System.IntPtr,System.Int32)
		// Player& Unity.Entities.InternalCompilerInterface::UnsafeGetRefToNativeArrayPtrElement<Player>(System.IntPtr,System.Int32)
		// GameStateData& Unity.Entities.InternalCompilerInterface::UnsafeGetRefToNativeArrayPtrElement<GameStateData>(System.IntPtr,System.Int32)
		// System.Void Unity.Entities.JobEntityBatchExtensions::EarlyJobInit<ExplosionSystem/ExplosionSystem_LambdaJob_0_Job>()
		// System.Void Unity.Entities.JobEntityBatchExtensions::EarlyJobInit<PlayerMoveSystem/PlayerMoveSystem_LambdaJob_0_Job>()
		// System.Void Unity.Entities.JobEntityBatchExtensions::EarlyJobInit<HyperSpaceSystem/HyperSpaceSystem_LambdaJob_0_Job>()
		// System.Void Unity.Entities.JobEntityBatchExtensions::RunWithoutJobs<PlayerMoveSystem/PlayerMoveSystem_LambdaJob_0_Job>(PlayerMoveSystem/PlayerMoveSystem_LambdaJob_0_Job&,Unity.Entities.EntityQuery)
		// System.Void Unity.Entities.JobEntityBatchExtensions::RunWithoutJobs<HyperSpaceSystem/HyperSpaceSystem_LambdaJob_0_Job>(HyperSpaceSystem/HyperSpaceSystem_LambdaJob_0_Job&,Unity.Entities.EntityQuery)
		// Unity.Jobs.JobHandle Unity.Entities.JobEntityBatchExtensions::Schedule<ExplosionSystem/ExplosionSystem_LambdaJob_0_Job>(ExplosionSystem/ExplosionSystem_LambdaJob_0_Job,Unity.Entities.EntityQuery,Unity.Jobs.JobHandle)
		// System.Void Unity.Entities.JobEntityBatchIndexExtensions::EarlyJobInit<ExplosionSystem/ExplosionSystem_LambdaJob_1_Job>()
		// System.Void Unity.Entities.JobEntityBatchIndexExtensions::EarlyJobInit<GameStateUISystem/GameStateUISystem_LambdaJob_0_Job>()
		// System.Void Unity.Entities.JobEntityBatchIndexExtensions::RunWithoutJobs<ExplosionSystem/ExplosionSystem_LambdaJob_1_Job>(ExplosionSystem/ExplosionSystem_LambdaJob_1_Job&,Unity.Entities.EntityQuery)
		// Unity.Jobs.JobHandle Unity.Entities.JobEntityBatchIndexExtensions::Schedule<GameStateUISystem/GameStateUISystem_LambdaJob_0_Job>(GameStateUISystem/GameStateUISystem_LambdaJob_0_Job,Unity.Entities.EntityQuery,Unity.Jobs.JobHandle)
		// Unity.Entities.BufferFromEntity`1<Health> Unity.Entities.SystemBase::GetBufferFromEntity<Health>(System.Boolean)
		// Unity.Entities.ComponentDataFromEntity`1<Player> Unity.Entities.SystemBase::GetComponentDataFromEntity<Player>(System.Boolean)
		// Unity.Entities.ComponentDataFromEntity`1<PowerUp> Unity.Entities.SystemBase::GetComponentDataFromEntity<PowerUp>(System.Boolean)
		// Unity.Entities.ComponentDataFromEntity`1<Missile> Unity.Entities.SystemBase::GetComponentDataFromEntity<Missile>(System.Boolean)
		// Unity.Entities.ComponentDataFromEntity`1<Enemy> Unity.Entities.SystemBase::GetComponentDataFromEntity<Enemy>(System.Boolean)
		// Unity.Entities.ComponentDataFromEntity`1<Unity.Transforms.Translation> Unity.Entities.SystemBase::GetComponentDataFromEntity<Unity.Transforms.Translation>(System.Boolean)
		// System.Object Unity.Entities.World::GetOrCreateSystem<System.Object>()
		// Unity.Jobs.JobHandle Unity.Physics.ITriggerEventJobExtensions::Schedule<PlayerHitSystem/CollisionEventSystemJob>(PlayerHitSystem/CollisionEventSystemJob,Unity.Physics.ISimulation,Unity.Jobs.JobHandle)
		// Unity.Jobs.JobHandle Unity.Physics.ITriggerEventJobExtensions::Schedule<MissileHitSystem/CollisionEventSystemJob>(MissileHitSystem/CollisionEventSystemJob,Unity.Physics.ISimulation,Unity.Jobs.JobHandle)
		// UnityEngine.Vector2 UnityEngine.InputSystem.InputAction::ReadValue<UnityEngine.Vector2>()
	}
}