using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    public float SecTime = 3;

    public string levelName;

    public IEnumerator Start()
    {
        yield return new WaitForSeconds(SecTime);
        SceneManager.LoadScene("MainMenu");
    }
}

