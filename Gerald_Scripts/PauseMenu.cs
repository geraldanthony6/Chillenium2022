using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    [SerializeField]private Button pauseButton;
    [SerializeField]private GameObject pauseUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)){
            if(GamePaused){
                Resume();
            }
            else{
                pauseUI.SetActive(true);
                Time.timeScale = 0f;
                GamePaused = true;
            }
        }
    }

    public void Resume(){
                pauseUI.SetActive(false);
                Time.timeScale = 1f;
                GamePaused = false;
    }
}
