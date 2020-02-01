using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManage : MonoBehaviour
{
    public Button To_Game;
    public Button Exit;
    public Animation Fader;
    // Start is called before the first frame update
    void Start()
    {
        Fader.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void ToExit()
    {
        Application.Quit();
    }
}
