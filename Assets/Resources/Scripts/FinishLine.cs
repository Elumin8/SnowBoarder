using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] private bool playSound = true;
    [SerializeField] private float sceneDelay = 3f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (playSound)
            {
                GetComponent<AudioSource>().Play();
                playSound = false;
            }
            finishEffect.Play();
            Invoke("ReloadScene",sceneDelay);
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
