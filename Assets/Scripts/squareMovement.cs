using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    public float speed = 10f; // Speed of the movement
    public Projectile laserPrefab;

    void Update()
    {
        Vector3 position = transform.position;

        // Update the position of the player based on the input
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            position.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            position.x += speed * Time.deltaTime;
        }

        // Clamp the position of the character so they do not go out of bounds
        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
        position.x = Mathf.Clamp(position.x, leftEdge.x, rightEdge.x);

        // Set the new position
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space)){
            shoot();
        }

    }

    private void shoot(){
        Instantiate(laserPrefab, transform.position, Quaternion.identity);
    }
}
