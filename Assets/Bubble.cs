using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public int moveForwardFrame = 6;
    public int currentFrame = 0;
    public float speed = 0.7f;
    public Rigidbody2D rigidbody2D;
    public float gravityScale = -0.7f;
    // 앞쪽 이동, 6프레임 움직인 후, 위로 이동(중력)
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.gravityScale = 0;
    }
    private void FixedUpdate()
    {
        if(currentFrame++ < moveForwardFrame)
        {
            var pos = rigidbody2D.position;
            pos.x += (speed * transform.forward.z);
            rigidbody2D.position = pos;
        }
        else
        {
            rigidbody2D.gravityScale = gravityScale;
            enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 버블이 터질만큼 만힝 붙어 있다면 터트리자.
        //if(collision 이 벽인가?)
        ////collision.contacts[0].point  와 나와의 거리를 확인하자. -> 특정 값보다 작다면 터트리자.
    }
}