using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 1.0f;
    public float axel = 0.001f;
    private float a = 1f;
    public float gravity = -9.8f;
    CharacterController body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        float deltaX = 0;// Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        body.Move(movement);


        //a = a + axel;
        //transform.Translate(0, 0, speed * Input.GetAxis("Vertical") * Time.deltaTime * a);
    }//speed * Input.GetAxis("Vertical") * Time.deltaTime
}
