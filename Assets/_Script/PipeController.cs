using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        InvokeRepeating(nameof(CreateOjb),1.25f,1.25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateOjb()
    {
        float ramdomPipe = Random.Range(-2.8f, 2.8f);

        Instantiate(prefab,new Vector2(transform.position.x,ramdomPipe), Quaternion.identity,transform);

    }
}
