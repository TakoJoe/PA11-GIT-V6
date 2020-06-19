using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Game();
    }
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }

    public void Game()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void Leave()
    {
        SceneManager.LoadScene(0);
    }
}
