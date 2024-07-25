using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem SnowDustEffect;
    private void OnCollisionEnter2D(Collision2D other) {
        SnowDustEffect.Play();
    }
    private void OnCollisionExit2D(Collision2D other) {
        SnowDustEffect.Stop();
    }
}
