using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialPopUp : MonoBehaviour
{
    public Game game;
    public Text countdownField;

    int timer;

    void Start()
    {
        timer = 4;
        Invoke("CuentaRegresiva", 0.400f);
    }

    void Reset()
    {
        gameObject.SetActive(false); // Descativa el popup
        game.type = Game.types.PLAYING; // Game type pasa a playing entonces todo lo demas se activa
    }

    void CuentaRegresiva() {
        timer = timer - 1;
        countdownField.text = timer.ToString();
        Invoke("CuentaRegresiva", 1);
        if (timer == 0)
        {
            countdownField.text = "YA!";
            Invoke("Reset", 1);
        }
    } 
}
