using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleShiny : MonoBehaviour
{

    public Material myMaterial;
    public AudioClip hit;
    public GameObject sonido;
    private AudioSource src;

    private float brilloBool;
    // Start is called before the first frame update
    void Start()
    {
        brilloBool = 1f;
        src = sonido.GetComponent<AudioSource>();
        myMaterial = this.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Canica")
        {
            myMaterial.SetFloat("_ActiveEmissionObst", brilloBool);
            src.PlayOneShot(hit);
            brilloBool= 1 - brilloBool;

        }
    }
}
