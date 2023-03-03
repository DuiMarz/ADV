using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public float fuerza = 10f;  // Fuerza de impulso que se aplicará a la bola

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Aplicar fuerza hacia arriba mientras se mantiene presionada la tecla de espacio
            rb.AddForce(Vector3.right * fuerza);
        }
    }
}
