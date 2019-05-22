using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }

    public void Reset()
    {
        SceneManager.LoadScene("Main");
    }
}
