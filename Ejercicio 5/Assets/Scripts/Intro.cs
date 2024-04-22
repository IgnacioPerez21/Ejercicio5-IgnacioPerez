using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    protected string nombreSiguienteEscena;

    void Update()
    {
        // Verificar si se ha presionado una tecla
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Cargar la siguiente escena
            SceneManager.LoadScene("Level01");
        }
    }
}