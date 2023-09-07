using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ball;
    private Vector3 offset;
    public float smoothSpeed;

    void Start()
    {
   offset = transform.position - ball.position;     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position , offset + ball.position , smoothSpeed );
        transform.position = newPos;
    }
}
