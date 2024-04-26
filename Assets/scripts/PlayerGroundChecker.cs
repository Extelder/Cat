using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundChecker : MonoBehaviour
{
    public static bool _onGround;
    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent<Ground>(out Ground ground))  _onGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Ground>(out Ground ground)) _onGround = false;
    }
}
