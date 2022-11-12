using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UProje1.Controllers 
{
    public class PCInputController 
    {
        public bool LeftMouseClickDown  => Input.GetMouseButtonDown(0);
        public bool rightMouseClickDown  => Input.GetMouseButtonDown(1);
   
    }
}

