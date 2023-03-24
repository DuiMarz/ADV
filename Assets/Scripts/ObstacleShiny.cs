using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleShiny : MonoBehaviour
{

    public Material myMaterial;
    // Start is called before the first frame update
    void Start()
    {
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
            myMaterial.SetFloat("_ActiveEmissionObst", 1f);
        }
    }
}
