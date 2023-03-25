using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    
    public AudioClip fallSound;
    public AudioClip victory;
    public AudioClip hit;
    public GameObject sonido;

    public bool cesta;
  

    private AudioSource src;
    // Start is called before the first frame update

    public void Start()
    {
        cesta = false;
        src = sonido.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= -5)
        {
            src.PlayOneShot(fallSound);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            src.Stop();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
     
        if (collision.gameObject.CompareTag("Hammer"))
        {
            // Reproducimos el sonido mp3
            src.PlayOneShot(hit);
            cesta = false;

        } else if (collision.gameObject.CompareTag("Basket") && cesta == false)
        {
            src.PlayOneShot(victory);
            cesta = true;
        }
    }

    
}
