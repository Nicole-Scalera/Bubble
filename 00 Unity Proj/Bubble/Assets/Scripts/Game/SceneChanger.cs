using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log($"Loading scene: {sceneName}");
        // Load a different scene by name
        SceneManager.LoadScene(sceneName);
    }
}