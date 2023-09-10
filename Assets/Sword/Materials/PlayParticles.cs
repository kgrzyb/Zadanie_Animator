using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour
{
    [SerializeField] ParticleSystem particles;

    public void PlaySmokeParticle()
    {
        particles.Play();
    }
}
