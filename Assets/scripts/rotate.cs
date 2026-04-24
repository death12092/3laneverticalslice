using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class rotate : MonoBehaviour
{

    public Camera cam;
 

    public void turnleft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            StartCoroutine(RotateLeft());
        }
    }

    public void turnright(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            StartCoroutine(RotateRIGHT());
        }
    }


    public IEnumerator RotateLeft()
    {

        for (int i = 0; i < 9; i++)
        {
            transform.Rotate(new Vector3(0, -10, 0));
            yield return 0;
        }

    }

    public IEnumerator RotateRIGHT()
    {

        for (int i = 0; i < 9; i++)
        {
            transform.Rotate(new Vector3(0, 10, 0));
            yield return 0;
        }

    }
}
