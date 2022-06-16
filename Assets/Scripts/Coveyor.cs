using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coveyor : MonoBehaviour
{
    //back Z POSITIVO, down, forward, left X POSITIVO
    public float speed;
    Rigidbody rBody;
    Transform trans;

    public float ScrollX = 0.5f;
    public float ScrollY = 0.5f;


    void Start()
    {
        trans = GetComponent<Transform>();
        rBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 pos = rBody.position;
        rBody.position += trans.right * speed * Time.fixedDeltaTime;
        rBody.MovePosition(pos);
    }

    void Update()
    {
        float OffsetX = Time.time * ScrollX;
        float OffsetY = Time.time * ScrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
    }
}

