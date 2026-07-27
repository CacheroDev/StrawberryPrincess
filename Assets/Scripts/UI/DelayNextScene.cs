using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayNextScene : MonoBehaviour
{
    [SerializeField] float timeDelay;

    void Start()
    {
        StartCoroutine(NextSceneWithDelay());
    }

    IEnumerator NextSceneWithDelay()
    {
        yield return new WaitForSeconds(timeDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
