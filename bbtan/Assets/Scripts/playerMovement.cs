using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    void Start()
    {
        HingeJoint hinge = gameObject.GetComponent(typeof(HingeJoint)) as HingeJoint;
        if (hinge != null)
        {
            hinge.useSpring = false;
        }
    }

   
}
