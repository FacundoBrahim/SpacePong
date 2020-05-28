using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem ballHitEffect;
    public ParticleSystem asteroidBallHit;

    public void BallHitCoin(Vector3 pos)
    {
        ballHitEffect.transform.position = pos;
        ballHitEffect.Play();
    }

    public void asteroidBallColision(Vector3 pos)
    {
        asteroidBallHit.transform.position = pos;
        asteroidBallHit.Play();
    }
}
