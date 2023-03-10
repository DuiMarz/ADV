using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallExplosion : MonoBehaviour
{

    public GameObject particlePrefab; // Reference to the particle prefab

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Instantiate the particle prefab at the point of collision
            Instantiate(particlePrefab, collision.contacts[0].point, Quaternion.identity);
        }
    }
}
