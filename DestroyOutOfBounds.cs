using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Private variables initializing boundaries
    private float topBound = 40.0f;
    private float lowerBound = -10.0f;

    // Update is called once per frame
    void Update()
    {
        // if an object goes beyond the player's view, destory object
        DestroyBeyondBounds();
    }
    void DestroyBeyondBounds()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            FindObjectOfType<AddToScore>().LosePointa();
        }
    }
}
