using UnityEngine.InputSystem;
using UnityEngine;

public class bow : MonoBehaviour
{
    private float aimAmount = 0;
    private float finalAimAmount;

    [SerializeField]
    SkinnedMeshRenderer bowMesh;

    private bool aiming;

    private bool shoot;

    [SerializeField]
    private float aimspeed = 10f;

    [SerializeField]
    GameObject arrowToSpawn;

    GameObject currentArrow;

    [SerializeField]
    Transform start, end;

    public void aim(InputAction.CallbackContext context)
    {
        if(!shoot && !aiming)
        {
            aiming = context.ReadValue<float>() > 0;
            if (aiming)
            {
                if(arrowToSpawn != null)
                {
                    currentArrow = Instantiate(arrowToSpawn);
                    currentArrow.transform.position = start.position;
                }
            }
        }
    }

    public void shooot(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() > 0)
        {
            if (aiming)
            {
                shoot = true;
                aiming = false;
                finalAimAmount = aimAmount;
            }
        }
    }

    private void Update()
    {
        if(aiming && !shoot)
        {
            aimAmount = Mathf.Clamp(aimAmount + (Time.deltaTime * aimspeed), 0, 100);
        }
        if (shoot && !aiming)
        {
            aimAmount = Mathf.Clamp(aimAmount - (Time.deltaTime * 500), 0, 100);
            if(aimAmount == 0)
            {

            }
        }
    }
}
