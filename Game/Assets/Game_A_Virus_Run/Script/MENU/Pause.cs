using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityStandardAssets.CrossPlatformInput;

public class Pause : MonoBehaviour
{
    bool gameispaused=false;
    //public GameObject pauseMenueUi;
    public void ispause()
    {
        
            if(gameispaused){
                Resume();
            }else{
                Pauses();
            }
        
        
    }
    public void Resume(){
        //pauseMenueUi.SetActive(false);
        Time.timeScale=1;
        gameispaused=false;
    }
    void Pauses(){
        //pauseMenueUi.SetActive(true);
        Time.timeScale=0;
        gameispaused=true;
    }

    public void loadmenu(){
        Time.timeScale=1;
        gameispaused=false;
        SceneManager.LoadScene(0);
    }
}
