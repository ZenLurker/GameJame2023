using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{

    

    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        Debug.Log("Attend");
        //Wait for 10 seconds
        yield return new WaitForSeconds(5);
        Debug.Log("Fini");

    }


    public AudioSource audio;
    public AudioSource audio2;


    public void scene_changer_level1(){
        PlayerPrefs.SetInt("score", 0);
        SceneManager.LoadScene("CoffeeShopScene");
    }

    public void QuitGame(){
        Debug.Log("Quit game");
        Application.Quit();
    }

    public void playButton()
    {
        audio2.Play();
    }

}
