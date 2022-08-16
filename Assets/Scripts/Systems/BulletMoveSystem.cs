using Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Systems {
	public class BulletMoveSystem : ComponentSystem {
		private EntityQuery _moveQuery;

		protected override void OnCreate() {
			_moveQuery = GetEntityQuery(
				ComponentType.ReadOnly<BulletData>(),
				ComponentType.ReadOnly<Translation>(),
				ComponentType.ReadOnly<Rotation>());
			//);
		}

		protected override void OnUpdate() {
			Entities.With(_moveQuery).ForEach(
				(Entity entity, ref Translation translation,
					ref Rotation rotation,
					ref BulletData bulletMoveData) => {
					var pos = new Vector3(translation.Value.x, translation.Value.y, translation.Value.z);
					var rot = new Quaternion(rotation.Value.value.x, rotation.Value.value.y,
						rotation.Value.value.z, rotation.Value.value.w);

					var posForward = rot * Vector3.forward;
					pos += posForward * bulletMoveData.Speed * Time.DeltaTime;

					translation.Value = pos;

					//transform.position                += transform.forward * bulletMoveData.Speed / 100f;
					bulletMoveData.ActualExistingTime += Time.DeltaTime;
					if ( bulletMoveData.ShouldDestroy() ) {
						EntityManager.DestroyEntity(entity);
					}
				});
		}
	}
}