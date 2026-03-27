using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Camera player;
    [SerializeField] PlayerInput inputer;

    private void CamerRotate(InputAction.CallbackContext context)
    {
        float Rootate = Input.GetAxis("wtf");
    }
}