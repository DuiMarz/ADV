using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioColorHammer : MonoBehaviour
{
    public Material myMaterial; // Referencia al material que deseas modificar
   

    void Start()
    {
        
        
        myMaterial = this.GetComponent<MeshRenderer>().materials[2];

    }
    void Update()
    {
        // Obtiene el ángulo de rotación en el eje y (vertical)
        float angle = transform.rotation.eulerAngles.x;

        Debug.Log(angle);
        // Calcula un valor entre 0 y 1 en función del ángulo de rotación
        float t = Mathf.InverseLerp(90f, 0f, angle);

        if (angle > 90 )
        {
            myMaterial.SetColor("_Color", Color.red);
            myMaterial.SetColor("_ColorEmission", Color.red);
            
        }
        else 
        {

            // Interpola entre verde y rojo en función del valor calculado
            Color32 color = Color.Lerp(Color.green, Color.red, t);

            // Modifica el color del material utilizando el valor interpolado
            myMaterial.SetColor("_Color", color);
            myMaterial.SetColor("_ColorEmission", color);
        }

        
    }
}
