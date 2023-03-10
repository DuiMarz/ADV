using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public float fuerza = 10f;  // Fuerza de impulso que se aplicará a la bola
    public GameObject ball;
    private Rigidbody rb;
    private Material material;

    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
        material = ball.GetComponent<Material>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Aplicar fuerza hacia arriba mientras se mantiene presionada la tecla de espacio
            rb.AddForce(Vector3.right.normalized * fuerza, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(Vector3.left.normalized * fuerza, ForceMode.Impulse);
        }
        material.SetFloat("IntensityEmission", rb.velocity.magnitude);
    }
}
