using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoToGame() 
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
