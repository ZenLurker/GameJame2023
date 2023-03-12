using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_skip : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("Attend");
        //Wait for 10 seconds
        yield return new WaitForSeconds(5);
        Debug.Log("Fini");
        SceneManager.LoadScene("Credit");
    }

}
