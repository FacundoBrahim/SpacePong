using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Vector2 sizes = new Vector2(8, 5);
    public types type;
    public enum types
    {
        INTRO,
        PLAYING,
        GAMEOVER
    }
    public int score_player_1;
    public int score_player_2;
    public Text field_score_p1;
    public Text field_score_p2;
    public Player.types playerActiveType;

    public void Win(int playerID, int score)
    {
        if (playerID == 1)
        {
            score_player_1 += score;
            field_score_p1.text = score_player_1.ToString();
        }
        else
        {
            score_player_2 += score;
            field_score_p2.text = score_player_2.ToString();
        }

        if (score_player_1 >= 150)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver2");
        }
        if (score_player_2 >= 150)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }
}
