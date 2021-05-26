using System.Collections;
using  UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1;
    private static readonly int Start = Animator.StringToHash("Start");

    void Update()
    {
        
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    private IEnumerator LoadScene(int sceneIndex)
    {
        transition.SetTrigger(Start);
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}
