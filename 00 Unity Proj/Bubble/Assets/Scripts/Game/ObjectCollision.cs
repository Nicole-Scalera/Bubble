using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    public SceneChanger sceneChanger; // Reference to the SceneChanger script
    private string sceneName;

    // This function is called when the object enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TargetObject"))  // Ensure the other object has the correct tag
        {
            sceneChanger.LoadScene(sceneName);
        }
    }
}
