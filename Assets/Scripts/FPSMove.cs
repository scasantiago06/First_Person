﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
    float speed = 1f;

    void Update()                                                                   //El "Update" se utiliza para comprobar la presión de botones.
    {
        if (Input.GetKey(KeyCode.W))                                                //Si se presiona la tecla "W" pasa lo siguiente.
        {
            transform.position += transform.forward * speed * Time.deltaTime;       //Se le agrega velocidad al "transform" hacia el frente.
        }
        if (Input.GetKey(KeyCode.S))                                                //Si se presiona la tecla "S" pasa lo siguiente.
        {
            transform.position -= transform.forward * speed * Time.deltaTime;       //Se le agrega velocidad al "transform" hacia el frente pero en negativo, es decir, hacia atrás.
        }
        if (Input.GetKey(KeyCode.A))                                                //Si se presiona la tecla "A" pasa lo siguiente.
        {
            transform.position -= transform.right * speed * Time.deltaTime;         //Se le agrega velocidad al "transform" hacia la derecha en negativo, es decir, hacia la izquierda.
        }
        if (Input.GetKey(KeyCode.D))                                                //Si se presiona la tecla "D" pasa lo siguiente.
        {
            transform.position += transform.right * speed * Time.deltaTime;         //Se le agrega velocidad al "transform" hacia la derecha.
        }
    }
}
