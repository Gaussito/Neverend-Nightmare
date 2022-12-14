using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public string firstLevel;

    public GameObject optionsScreen;

    public GameObject creditsScreen;
    public GameObject loadingScreen, loadingIcon;
    public Text loadingText;


    public void StartGame(){
        SceneManager.LoadScene(firstLevel);
        //StartCoroutine(LoadStart());
    }

    public void OpenOptions(){
        optionsScreen.SetActive(true);
    }

    public void CloseOptions(){
        optionsScreen.SetActive(false);
    }

    public void OpenCredits(){
        creditsScreen.SetActive(true);
    }

    public void CloseCredits(){
        creditsScreen.SetActive(false);
    }

    public void QuitGame(){
        Application.Quit();
    }

    /*public IEnumerator LoadStart(){
        loadingScreen.SetActive(true);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(firstLevel);
        asyncLoad.allowSceneActivation = false;
        while (!asyncLoad.isDone){
            if (asyncLoad.progress >= .9f){
                loadingText.text = "Press any key to continue";
                loadingIcon.SetActive(false);

                if(Input.anyKeyDown){
                    asyncLoad.allowSceneActivation = true;
                    Time.timeScale = 1;
                }
            }
            yield return null;
        }
    }*/
}
