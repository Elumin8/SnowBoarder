using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float sceneDelay = 1f;
    [SerializeField] ParticleSystem bleeding;
    [SerializeField] AudioClip crashSFX;
    [SerializeField] private bool playSound = true;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            if (playSound)
            {
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
                playSound = false;
            }
            bleeding.Play();
            Debug.Log("hit your head!");
            Invoke("ReloadScene", sceneDelay);
        }
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
