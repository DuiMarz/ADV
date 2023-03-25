using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBallHammer : MonoBehaviour
{

    private Vector3 initialPosition;
    private Quaternion initialRotation;
    public GameObject ball, hammer;

    // En el m�todo Start guardamos la posici�n inicial de la pelota
    void Start()
    {
        initialPosition = ball.transform.position;
        initialRotation = hammer.transform.rotation;

    }

    void Update()
    {
        // Si la pelota est� a una altura de -2 o si se pulsa la tecla R
        if (ball.transform.position.y <= -5 || Input.GetKeyDown(KeyCode.R))
        {
            // Teletransportamos la pelota a su posici�n inicial
            ball.transform.position = initialPosition;
            hammer.transform.rotation = initialRotation;


            // Dormimos la pelota para que no mantenga la velocidad
            ball.GetComponent<Rigidbody>().Sleep();
            hammer.GetComponent<Rigidbody>().Sleep();
        }

        

    }
}
