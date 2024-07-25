using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashReload = 0.3f;
    [SerializeField] ParticleSystem crashEffect;

    bool isCrash = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground" && isCrash == false)
        {
            FindAnyObjectByType<PlayerController>().DisableControl();
            crashEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", crashReload);
            isCrash = true;
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
