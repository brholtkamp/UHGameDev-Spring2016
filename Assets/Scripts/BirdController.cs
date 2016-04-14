using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour {
    // Amount of jump to apply when space bar is pressed
    public float JumpAmount = 5.0f;

    // Handle on the Score
    public ScoreManager Score;

    // Handle on the rigidbody
    private Rigidbody2D Rigidbody;

    // Flag to determine if we should jump on this physics' update
    private bool ShouldJump = false;

    // Runs when the game object is started
    private void Awake() {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Runs on each physics update
    private void FixedUpdate() {
        // Should we jump right now?
        if (ShouldJump) {
            // Stop our current falling
            Rigidbody.velocity = Vector2.zero;

            // Add an upward force
            Rigidbody.AddForce(Vector2.up * JumpAmount);

            // We jumped, so let's clear our flag
            ShouldJump = false;
        }
    }

    // Runs on each frame
    private void Update () {
        // Check to see if the spacebar has been pressed down
        if (Input.GetKeyDown(KeyCode.Space)) {
            // Mark our flag to jump
            ShouldJump = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Death")) {
            Death();
        }

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Score")) {
            IncrementScore();
        }
    }

    private void Death() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void IncrementScore() {
        Score.IncrementScore();
    }
}