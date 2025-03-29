using UnityEngine;
using UnityEngine.SceneManagement;

// This is the SceneChanger class. When called, it will change
// the current scene to a new one of a specific name. Set the
// name in the Inspector, or create a line to manually assign
// it through the code.

public class SceneChanger : MonoBehaviour
{

    // Singleton instance for global reference
    private static SceneChanger _sceneChanger;

    // Constructor that forces only a single
    // instance of SceneChanger to be created
    public static SceneChanger Instance
    {
        get
        {
            // If Player instance is null, assign Player component
            if (_sceneChanger == null)
            {
                _sceneChanger = new SceneChanger(); // Assign SceneChanger
            }

            // Return the SceneChanger instance
            return _sceneChanger;
        }
    }

    // Current instance of the sceneName
    private string sceneName;

    // Load a scene
    public void LoadScene(string sceneName)
    {
        this.sceneName = sceneName;
    //  ^^^
    //  Use keyword "this" assign the name
    //  to the specific instance of sceneName

        // Tell the user what scene is being loaded
        Debug.Log($"Loading scene: {sceneName}");
        
        // Load a scene by its name
        SceneManager.LoadScene(sceneName);
    }
    
    // Get the current scene
    public string GetCurrentSceneName()
    {
        // Grab the scene by its name
        return SceneManager.GetActiveScene().name;
    }
    
}