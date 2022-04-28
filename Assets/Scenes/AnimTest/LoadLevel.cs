using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public Animator transition;
    private int index;
    private IEnumerator coroutine;

    void Start()
    {
        coroutine = ILoadLevel();
    }

    public void LoadLevelByIndex(int _index)
    {
        index = _index;

        Debug.Log("Load Scene");
        StartCoroutine(ILoadLevel());
    }

    IEnumerator ILoadLevel()
    {
        transition.SetTrigger("LoadLevelStart");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(index);
    }
}
