// Note for Annadaliah:
// I set up this super basic scene-changer script at the start of the game jam.
// It's not in use right now, so feel free to tweak it how ever you'd like.
// I am currently optimizing scripts for a more object-oriented approach that
// will reduce the likelihood of errors and protect data.
// -- Nikki

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
