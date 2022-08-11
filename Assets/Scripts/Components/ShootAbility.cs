using Systems.Interfaces;
using UnityEngine;

namespace Components {
	public class ShootAbility : MonoBehaviour, IAbility {
		public  GameObject _bullet;
		public  float      _shootDelay;
		private float      _shootTime = float.MinValue;

		public void Execute() {
			if ( Time.time < _shootTime + _shootDelay ) {
				return;
			}

			_shootTime = Time.time;
			
			if ( _bullet != null ) {
				var t         = transform;
				var newBullet = Instantiate(_bullet, t.position, t.rotation);
			} else {
				Debug.LogError("[SHOOT ABILITY] No bullet prefab's reference!");
			}
		}
	}
}