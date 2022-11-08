using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
      if (target != null) {
        transform.position = target.position + (Vector3.back * 10);
      }        
    }
}
