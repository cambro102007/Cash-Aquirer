using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleBook : MonoBehaviour
{
    public void Unload()
    {
        SceneManager.UnloadSceneAsync("Rule Book");
        SceneManager.LoadScene("Game");
    }
}
