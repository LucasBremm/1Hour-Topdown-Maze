using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
  DoorBehaviour door;
  GameManager gameManager;

  void Start() {
    door = FindObjectOfType<DoorBehaviour>();
    gameManager = FindObjectOfType<GameManager>();
  }

  void OnTriggerEnter2D(Collider2D other) {
    gameManager.GotKey();
    door.OpenDoor();
    gameObject.SetActive(false);  
  }
}
