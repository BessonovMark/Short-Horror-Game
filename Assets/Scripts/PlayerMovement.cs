using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters {
    public class PlayerMovement : MonoBehaviour, ICharacterMovement {

        public float Speed;

        // Transform of player object group
        // We're moving the whole group in case if there is additional objects (i.e. Player holds smth)
        private Transform _transform;
        public void Move() {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            
            if (Math.Abs(moveHorizontal) >= Math.Abs(moveVertical)) {
                _transform.Translate(Math.Sign(moveHorizontal) * Speed * Time.deltaTime, 0.0f, 0.0f);
            }
            else {
                _transform.Translate(0.0f, Math.Sign(moveVertical) * Speed * Time.deltaTime, 0.0f);
            }


        }
        void Awake() {
            _transform = GameObject.FindGameObjectWithTag("PlayerGroup").transform;
        }

        // Update is called once per frame
        void Update() {
            //Move();
        }
        
        void FixedUpdate() {
            if (Input.anyKey) {
                Move();
            }
            //Debug.Log(_transform.position);
            
        }
    }
}
