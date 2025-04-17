using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float bottomBound = -10;

// Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound | transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}