using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UProje1.Movement
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] float jumpForce = 500f;

        public void JumpAction(Rigidbody2D rigidbody2D)
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector3.up * jumpForce);
        }

    }

}

