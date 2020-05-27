using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoInfinito : MonoBehaviour
{
    public Game game;
    Material mt;
    public float paralax;
    Vector2 offset;

    void Start()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        mt = sp.material;
        offset = mt.mainTextureOffset;
    }

    void Update()
    {
        if (game.type == Game.types.INTRO) {
            paralax = 10f;
        } else
        {
            paralax = 2f;
        }
        offset.y += Time.deltaTime / paralax;
        mt.mainTextureOffset = offset;
    }
}
