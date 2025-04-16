using UnityCommunity.UnitySingleton;
using UnityEngine;
using UnityEngine.SceneManagement;

// This is the SceneChanger class. When called, it will change
// the current scene to a new one of a specific name. Set the
// name in the Inspector, or create a line to manually assign
// it through the code.

public class SceneChanger : MonoSingleton<SceneChanger>
{
    
    // ===== Variables/Components =====
    private GameManager gameManager; // Access GameManager.cs
    private string sceneName; // Name of a scene
    // ================================

    protected override void Awake()
    {
        gameManager = GameManager.Instance; // Assign GameManager.cs
    }

    // Load a scene by name (set name in Inspector)
    public void LoadScene(string sceneName)
    {
        this.sceneName = sceneName;
        
        // Tell the user what scene is being loaded
        Debug.Log($"SceneChanger > Loading scene: {sceneName}");
        
        // Load a scene by its name
        SceneManager.LoadScene(sceneName);
        
        //  Confirm the scene was loaded
        Debug.Log($"SceneChanger > Scene Loaded: {sceneName}");
    }
    
    // Get the current scene
    public string GetCurrentSceneName()
    {
        // Grab the scene by its name
        return SceneManager.GetActiveScene().name;
    }
    
    // Call sceneLoaded when a new scene is loaded
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Notify the GameManager of the new "current" scene name
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        gameManager.UpdateCurrentScene(scene.name);
    }
    
    
}