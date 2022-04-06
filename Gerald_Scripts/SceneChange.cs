using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField]private GameObject credits;
    [SerializeField]private GameObject mainMenu;
    [SerializeField]private GameObject levelSelect;
    [SerializeField]private GameObject control;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame(){
        SceneManager.LoadScene("Payne");
        if(Time.timeScale == 0){
            Time.timeScale = 1;
        }
    }

    public void LoadBulletHell(){
        SceneManager.LoadScene("Bullet Hell");
        if(Time.timeScale == 0){
            Time.timeScale = 1;
        }
    }

    public void LoadCredits(){
        control.gameObject.SetActive(false);
        levelSelect.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        credits.gameObject.SetActive(true);
    }

    public void ReLoadMainMenu(){
        mainMenu.gameObject.SetActive(true);
        control.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        levelSelect.gameObject.SetActive(false);
    }

    public void LoadMainMenu(){
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadBulletHellLose(){
        SceneManager.LoadScene("Bullet Hell Lose Scene");
    }

    public void LoadLevelSelect(){
        mainMenu.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        levelSelect.gameObject.SetActive(true);
        control.gameObject.SetActive(false);

    }

    public void LoadControl(){
        mainMenu.gameObject.SetActive(false);
        control.gameObject.SetActive(true);
        credits.gameObject.SetActive(false);
        levelSelect.gameObject.SetActive(false);
    }

    public void EndGame(){
        Application.Quit();
        Debug.Log("Bye Bye!");
    }
}
