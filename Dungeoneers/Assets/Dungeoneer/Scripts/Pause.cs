using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject PauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseScreen.SetActive(true);
    }
    public void UnPauseGame()
    {
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
    }
    public void ReturnScene()
    {
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
}
