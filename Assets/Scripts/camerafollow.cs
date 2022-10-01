using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform birdtransform;
    Vector3 range;

    private void Awake()
    {
        range = transform.position - birdtransform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(range.x + birdtransform.position.x, transform.position.y, range.z + birdtransform.position.z);
    }
}
