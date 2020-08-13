using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hori_movement = Input.GetAxis("Horizontal");
        float verti_movement = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(hori_movement, 0.0f, verti_movement);

        rb.AddForce(force * speed);

    }
}
