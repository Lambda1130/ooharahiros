using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamestartButton : MonoBehaviour
{
    public void GameButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
