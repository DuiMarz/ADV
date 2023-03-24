using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public float fuerza = 70f;  // Fuerza de impulso que se aplicará al martillo
    public GameObject hammer;
    private Rigidbody rb;
    private Material material;
    public GameObject ball;

    private void Awake()
    {
        ball.GetComponent<Rigidbody>().Sleep();
    }
    void Start()
    {
        rb = hammer.GetComponent<Rigidbody>();
        material = hammer.GetComponent<MeshRenderer>().material;
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Aplicar fuerza hacia z+ al apretar la tecla de espacio
            rb.AddForce(Vector3.forward.normalized * fuerza, ForceMode.Impulse);
        }

        
        //material.SetFloat("_IntensityEmission", rb.velocity.magnitude);
    }
}
