using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public TMPro.TMP_Text puntos;
    private void Start()
    {
        GameManager.Instance.HUD = this;
    }

    public void MostrarPuntos(int enemys)
    {
        puntos.text = enemys.ToString();
    }
}
