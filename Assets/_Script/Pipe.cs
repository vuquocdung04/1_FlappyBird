using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector2(-1,0) * speed * Time.deltaTime);
        if(transform.position.x < - 10f)
        {
            Destroy(gameObject);
        }
    }

    
}
