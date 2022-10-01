using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(GetComponent<SpriteRenderer>().bounds.size.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Debug.Log(GetComponent<SpriteRenderer>().bounds.size.x);
            transform.position += 2 * Vector3.right * 5.696f;
        }

    }
}
