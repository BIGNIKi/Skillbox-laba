using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Components {
	public class UserInputData : MonoBehaviour, IConvertGameObjectToEntity {
		public float speed;

		public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
			// благодаря этому в Entity дебагере можно будет смотреть что происходит с данными
			// также при помощи этого наши структуры будут висеть на GO как компоненты
			dstManager.AddComponentData<InputData>(entity, new InputData());
			dstManager.AddComponentData<MoveData>(entity, new MoveData { Speed = speed / 100 });
		}
	}

	// IComponentData говорит ECS, что InputData является компонентом ECS
	public struct InputData : IComponentData {
		public float2 Move;
	}

	public struct MoveData : IComponentData {
		public float Speed;
	}
}