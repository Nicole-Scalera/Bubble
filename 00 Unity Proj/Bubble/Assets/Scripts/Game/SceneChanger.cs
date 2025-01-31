using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    private string sceneName;

    public void LoadScene(string sceneName)
    {
        this.sceneName = sceneName;
        Debug.Log($"Loading scene: {sceneName}");
        // Load a different scene by name
        SceneManager.LoadScene(sceneName);
    }
}