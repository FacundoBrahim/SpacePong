using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    public Game game;
    float _x;
    float _y;
    public float speed = 1;
    public float smooth = 1;
    public float direction_x = 1f;
    public float direction_y = 1f;
    public Player player1;
    public Player player2;
    public Ball ball;
    public AudioSource audioSource;
    public Animation anim;

    void Update () {
        _x = transform.position.x;
        _y = transform.position.y + speed * direction_y * Time.deltaTime;

        if (_y >= game.sizes.y)
            ChangeYDirectionCoin (1);
        else if (_y <= -game.sizes.y)
            ChangeYDirectionCoin (-1);

        transform.position = new Vector2 (_x, _y);
    }
    private void ResetCoin () {
        int rand = Random.Range (0, 100);
        if (rand > 50)
            direction_y = 1;
        else
            direction_y = -1;

        _x = _y = 0;
        transform.position = Vector3.zero;
        anim.Play();
    }

    private void ChangeYDirectionCoin (int direction) {
        _y = game.sizes.y * direction;
        direction_y *= -1;
    }

    private void OnTriggerEnter (Collider other) {
        int extra = 0;
        if (transform.localScale.x == 0.8f) { // Selecciono solo los astronautas
            audioSource.Play();
            if (ball.direction_x == 1){ // Si la direccion de la pelota es 1, osea el ultimo en pegarle fue el jugador 2
                player2.AumentarTamaño(); // Activar funcion que aumenta el tamaño por 2 seg y lo vuelve a la normalidad
            }
            else {
                player1.AumentarTamaño(); // Si no es 1, osea el ultimo en pegarle fue el jugador 1, activar esa funcion al jugador 1
            }
            extra = 4; // Los astronautas suman 4 puntos extras
        }

        if (game.playerActiveType == Player.types.PLAYER1)
            game.Win (1, -1 + extra);
        else
            game.Win (2, -1 + extra);

        Repositionate ();
    }

    void Repositionate () {
        float _x = Random.Range (game.sizes.x, -game.sizes.x);
        float _y = Random.Range (game.sizes.y, -game.sizes.y);

        _x /= 1.5f;
        _y /= 1.2f;

        transform.position = new Vector2 (_x, _y);
    }
}