using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Components
    private Rigidbody rb;
    private GameObject focalPoint;

    public float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Init Components
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        rb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
