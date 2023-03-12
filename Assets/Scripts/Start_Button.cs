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
        //Wait for 4 seconds
        yield return new WaitForSeconds(100);
    }


    public AudioSource audio;
    public AudioSource audio2;
    public void scene_changer_level1(){
        waiter();
        SceneManager.LoadScene("MoonAnimation");
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
