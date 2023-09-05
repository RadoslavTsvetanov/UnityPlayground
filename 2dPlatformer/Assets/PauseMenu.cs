using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject MainMenuRefernce;
    void Start()
    {
       Cursor.visible = false;    
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();   
    }

    private void PauseGame()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(!MainMenuRefernce.activeSelf)
            {
                Time.timeScale = 0f;
                MainMenuRefernce.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                MainMenuRefernce.SetActive(false);
                Cursor.visible = false; 
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }


    public void Resume()
    {
        Time.timeScale = 1f;
        MainMenuRefernce.SetActive(false);
        Cursor.visible = false;
    }


}
