using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void StartMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
