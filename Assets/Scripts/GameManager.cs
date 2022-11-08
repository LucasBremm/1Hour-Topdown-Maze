using UnityEngine;

public class GameManager : MonoBehaviour
{
  SceneLoader sceneLoader;
  
  public bool hasKey { get; private set; } = false;
  
  private void Start() {
   sceneLoader = GetComponent<SceneLoader>();
  }

  public void GotKey() {
    hasKey = true;
  }

  public void HasWon() {
    sceneLoader.LoadScene(SceneIndex.Win);
  }
}
