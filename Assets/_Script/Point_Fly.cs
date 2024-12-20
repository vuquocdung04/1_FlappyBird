using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Fly : MonoBehaviour
{
    public float flyspeed = 4f;

    private void Update()
    {
        this.transform.Translate(new Vector2(-2,2) * flyspeed * Time.deltaTime);

    }
    private void FixedUpdate()
    {
        Destroy(this.gameObject,0.5f);
    }
}
