using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody body;
    public float thrust = 100f;
    public float rotationThrust = 1f;


    // Start is called before the first frame update
    void Start()
    {
      body = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    private void ProcessThrust()
    {
        if (Input.GetMouseButton(0))
        {
            body.AddRelativeForce(Vector3.up * thrust * Time.deltaTime);

        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A)) {

            ApplyRotation(rotationThrust);
        }

        if (Input.GetKey(KeyCode.D))
        {

            ApplyRotation(-rotationThrust);
        }
    }

    public void ApplyRotation(float rotationThruster)
    {
        transform.Rotate(Vector3.forward * rotationThruster * Time.deltaTime);
    } 

}
