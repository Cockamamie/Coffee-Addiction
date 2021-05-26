using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public int sceneIndex;
    /*[SerializeField] private PlayerHealth playerHealth;
    private float hp;*/

    /*private void Start()
    {
        playerHealth.OnHealthChange.AddListener(health => { hp = health; });
    }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        /*PlayerPrefs.SetFloat("Health", hp);*/
        SceneManager.LoadScene(sceneIndex);
    }
}
