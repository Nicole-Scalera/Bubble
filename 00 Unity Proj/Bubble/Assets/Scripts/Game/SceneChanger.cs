using UnityEngine;
using UnityEngine.SceneManagement;

// This is the SceneChanger class. When called, it will change
// the current scene to a new one of a specific name. Set the
// name in the Inspector, or create a line to manually assign
// it through the code.

public class SceneChanger : MonoBehaviour
{
    // Current instance of the sceneName
    private string sceneName;

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
}