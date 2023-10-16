using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class EventHandler : MonoBehaviour
{
    public GameObject cashObject;
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    public void RuleBook()
    {
        Cash cash = cashObject.GetComponent<Cash>();
        PlayerPrefs.SetFloat("Cash", cash.money);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("MPS", cash.mps);
        PlayerPrefs.Save();

        SceneManager.UnloadSceneAsync("Game");
        SceneManager.LoadScene("Rule Book");
    }
}