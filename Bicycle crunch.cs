using UnityEngine;

public class PlayPause : MonoBehaviour
{
    private Animator animationComponent;
    private bool isPlaying = false;

    void Start()
    {
        // Assuming you have an Animation component attached to the GameObject
        animationComponent = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for touch input
        if (Input.touchCount == 2)
        {
            // Toggle play/pause when screen is touched
            TogglePlayPause();
        }
    }

    void TogglePlayPause()
    {
        if (animationComponent == null)
        {
            Debug.LogWarning("No Animation component found on this GameObject.");
            return;
        }

        if (isPlaying)
        {
            // If the animation is currently playing, pause it
            animationComponent.speed = 0f;
            isPlaying = false;
        }
        else
        {
            // If the animation is currently paused or stopped, play it
            animationComponent.speed = 1f;
            isPlaying = true;
        }
    }
}