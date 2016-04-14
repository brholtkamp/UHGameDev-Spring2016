using UnityEngine;

public class GameManager : MonoBehaviour {
    // How much time to wait between spawning an obstacle
    public float TimeBetweenObstacles = 4.0f;

    // How much can the obstacle deviate from 0?
    public float RangeFromOrigin = 5.0f;

    // How much time has passed since we spawned an obstacle?
    private float TimeElapsed = 0.0f;

    private void Update() {
        // Have we waited enough time since the last obstacle?
        if (TimeElapsed > TimeBetweenObstacles) {
            // Create a new obstacle from the resources folder
            var obstacle = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/Obstacle"));

            // Move the obstacle's transform to the far right (10.0f on the x-axis), and a random distance from 0.0f on the y-axis
            obstacle.transform.position = new Vector2(10.0f, 0.0f + Random.Range(-RangeFromOrigin, RangeFromOrigin));

            TimeElapsed = 0.0f;
        }

        // Add how much time has elapsed since the last frame (should be super small, like 0.015 seconds)
        TimeElapsed += Time.deltaTime;
    }
}