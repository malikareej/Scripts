using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawMovement : MonoBehaviour
{
    public Vector2 pos1;
    public Vector2 pos2;
    public Vector2 posDiff = new Vector2(7f, 0f);
    float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = transform.position;
        pos2 = pos1 + posDiff;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        transform.Rotate(0, 0, 3f);
    }
}