using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    public float MaxBound = 30.0f;
    public float minBound = -10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >MaxBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < minBound)
        {
            Destroy(gameObject);
        }
    }
}
