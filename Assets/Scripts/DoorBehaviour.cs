using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    Animator animator;

    void Start() {
      animator = GetComponent<Animator>();  
    }

    public void OpenDoor() {
      animator.SetTrigger("OpenDoor");
    }
}
