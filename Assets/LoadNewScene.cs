using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public void buttonLoadScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);

    }
}
