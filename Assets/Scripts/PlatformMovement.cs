using UnityEngine;

public class PlatformMovement : MonoBehaviour {
    // Speed the platforms should move at (negative so they move left)
    public float Speed = -5.0f;

    private void Update() {
        // Change the transform from it's old values, plus the Speed * deltTime for each frame on the x-axis
        transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y);
    }
}