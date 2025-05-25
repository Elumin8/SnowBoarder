using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideEffect : MonoBehaviour
{
    [SerializeField]
    ParticleSystem slideEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
        // if (other.gameObject.tag == "Ground")
        // {
            slideEffect.Play();
        // }
    }
    void OnCollisionExit2D(Collision2D other) {
        // if (other.gameObject.tag == "Ground")
        // {
            slideEffect.Stop();
        // }
    }
}
