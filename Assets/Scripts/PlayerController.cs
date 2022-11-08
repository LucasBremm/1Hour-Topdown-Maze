using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  Rigidbody2D rbody;
  GameManager gameManager;

  Vector2 movement = Vector2.zero;

  [SerializeField] float speed = 5f;

  void Start()
  {
    rbody = GetComponent<Rigidbody2D>();
    gameManager = FindObjectOfType<GameManager>();
  }

  void Update()
  {
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");
  }

  void FixedUpdate() {
    rbody.MovePosition(rbody.position + (movement * speed * Time.fixedDeltaTime));
  }

  void OnTriggerEnter2D(Collider2D other) {
    if (other.name == "Exit") {
      gameManager.HasWon();
    }  
  }
}
