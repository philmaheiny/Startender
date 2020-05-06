using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Startender
{
    public class PlayerMovement : MonoBehaviour
    {
        void Update()
        {
            if(VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.right * 5f * Time.deltaTime);
            }

            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(Vector3.left * 5f * Time.deltaTime);
            }
        }
    }
}
