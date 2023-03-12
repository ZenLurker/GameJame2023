using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


namespace TMPro.Examples
{
    
    public class Change_Scene : MonoBehaviour
    {
        public void scene_changer(string scene_name)
        {
            SceneManager.LoadScene(scene_name);
        }

    }
}
