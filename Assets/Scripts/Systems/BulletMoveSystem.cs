using Components;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Systems {
	public class BulletMoveSystem : ComponentSystem {
		private EntityQuery _moveQuery;

		protected override void OnCreate() {
			_moveQuery = GetEntityQuery(
				ComponentType.ReadOnly<BulletData>(),
			ComponentType.ReadOnly<LocalToWorld>());
			//);
		}

		protected override void OnUpdate() {
			Entities.With(_moveQuery).ForEach(
				( Entity entity, ref LocalToWorld lTW, ref BulletData bulletMoveData) => {
					// TODO: to move entities
					//transform.position                += transform.forward * bulletMoveData.Speed / 100f;
					bulletMoveData.ActualExistingTime += Time.DeltaTime;
					if (bulletMoveData.ShouldDestroy()) {
						EntityManager.DestroyEntity(entity);
					}
				});
		}
	}
}