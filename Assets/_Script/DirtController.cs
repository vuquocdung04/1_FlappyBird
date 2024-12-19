using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform dirt_tran;
    Vector2 index_loop;
    public SpriteRenderer dirt_render;

    public float dirt_speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        index_loop = new Vector2(0, dirt_tran.position.y);

        dirt_tran.Translate(new Vector2(-1,0) * dirt_speed * Time.deltaTime);
        if (Mathf.Abs(dirt_tran.position.x - index_loop.x) >= dirt_render.sprite.texture.width/32f)
        {
            dirt_tran.position = index_loop;
        }
    }

    private void OnDrawGizmosSelected()
    {
        dirt_tran = GetComponent<Transform>();
        dirt_render = GetComponent<SpriteRenderer>();
    }
}
