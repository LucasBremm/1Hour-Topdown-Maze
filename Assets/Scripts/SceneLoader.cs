using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneIndex {
  Game = 0,
  Win = 1,
};

public class SceneLoader : MonoBehaviour
{
  public void LoadScene(SceneIndex index) {
    SceneManager.LoadScene((int) index);
  }
  
  public void LoadSceneByGetEnum(GetEnum getEnum) {
    LoadScene(getEnum.index);
  }

  public void LoadGameScene() {
    LoadScene(SceneIndex.Game);
  }
}
