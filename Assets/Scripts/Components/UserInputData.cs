using Systems.Interfaces;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Components {
	public class UserInputData : MonoBehaviour, IConvertGameObjectToEntity {
		public MonoBehaviour ShootAction;
		public float         speed;

		public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
			// благодаря этому в Entity дебагере можно будет смотреть что происходит с данными
			// также при помощи этого наши структуры будут висеть на GO как компоненты
			dstManager.AddComponentData(entity, new InputData());
			dstManager.AddComponentData(entity, new MoveData { Speed = speed });
			if ( ShootAction != null && ShootAction is IAbility ) {
				dstManager.AddComponentData(entity, new ShootData());
			}
		}
	}

	// IComponentData говорит ECS, что InputData является компонентом ECS
	public struct InputData : IComponentData {
		public float2 Move;
		public float  Shoot;
		public bool   Rush;
	}

	public struct MoveData : IComponentData {
		public float Speed;
	}

	public struct ShootData : IComponentData {}
}