using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters {
    public class Player : MonoBehaviour, ICharacter {
        [SerializeField] ICharacterMovement Movement;
        void Start() {
            
        }

        // Update is called once per frame
        void Update() {

        }
    }
}