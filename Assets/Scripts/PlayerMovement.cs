using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force;

    public bool grounded;
    
    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += Time.deltaTime * force * Vector2.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity += Time.deltaTime * force * Vector2.left;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Time.deltaTime * force * Vector2.up;
        }
    }
}