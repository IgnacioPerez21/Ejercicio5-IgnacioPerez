using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    public int enemys = 0;
    
    public HUDManager HUD;
    public static GameManager Instance { get; private set; }
    void Awake()
    {
        Instance = this;
    }
   

    public void AddEnemy()
    {
        enemys++;
        HUD.MostrarPuntos(enemys);
    }


}
