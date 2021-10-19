using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    [SerializeField] private Image _progressBar;
    [SerializeField] private float delayBeforeLoad = 3f; // Testing Purpose
    [SerializeField] private GameObject chicken;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Remove Testing Code Later in SceneLoading Script");
        float randomNumber = Random.Range(1, 11);
        randomNumber = randomNumber / 10;
        chicken.transform.localScale = new Vector3 (randomNumber,randomNumber,randomNumber);
        StartCoroutine(Delay());       
    }

    IEnumerator Delay()
    {
        //Testing Purpose
        _progressBar.fillAmount = 0;
        yield return new WaitForSeconds(delayBeforeLoad);
        _progressBar.fillAmount = 0.5f;
        yield return new WaitForSeconds(delayBeforeLoad);
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(2);
        

        while (gameLevel.progress < 1)
        {            
            _progressBar.fillAmount = gameLevel.progress;
            yield return new WaitForEndOfFrame();
        }
    }

}
