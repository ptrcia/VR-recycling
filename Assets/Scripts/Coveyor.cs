using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coveyor : MonoBehaviour
{
    //back Z POSITIVO, down, forward, left X POSITIVO
    public float speed;
    Rigidbody rBody;
    Transform trans;

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
}
