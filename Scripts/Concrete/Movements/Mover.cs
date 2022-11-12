using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Enums;

namespace UProje1.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField]    float moveSpeed = 5f;
        [SerializeField] DirectionEnum direction;
        Rigidbody2D _rigidBody2D;

        private void Awake() 
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }   

        private void OnEnable() 
        {

            _rigidBody2D.velocity = SelectDirection() * moveSpeed;
        }

        private Vector2 SelectDirection()
        {
            Vector2 selectedXDirection;
            
            if(direction == DirectionEnum.Left)
            {
               selectedXDirection = Vector2.left;
            }
            else
            {
                selectedXDirection = Vector2.right;
            }
            
            return selectedXDirection; 
        }



        
    }

    

}

