using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPopUp : MonoBehaviour
{
    public Game game;

    void Start()
    {
        Invoke("Reset", 3);
    }

    void Reset()
    {
        gameObject.SetActive(false);
        game.type = Game.types.PLAYING;
    }
}
