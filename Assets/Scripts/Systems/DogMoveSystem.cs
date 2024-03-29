using Components;
using Unity.Entities;
using UnityEngine;

namespace Systems {
	public class DogMoveSystem : ComponentSystem {
		private EntityQuery _query; // запрос, с которого мы будем брать всё, что нужно

		protected override void OnCreate() {
			_query = GetEntityQuery(ComponentType
				.ReadOnly<DogMoveComponent>()); // получаем все сущности с DogMoveComponent компонентом
		}

		protected override void OnUpdate() {
			Entities.With(_query).ForEach((Entity entity, Transform transform, DogMoveComponent dogMoveComp) => {
				var p = transform.position;
				p.y                += (dogMoveComp.moveSpeed / 1000);
				transform.position =  p;
			});
		}
	}
}