using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UProje1.UIs
{
    public class GameOverPanel : MonoBehaviour
    {

        public void YesButtonClick()
        {
            GameManager.Instance.RestartGame();
        }

        public void NoButtonClick()
        {
            Debug.Log("No button Clicked");
        }

    }


}


