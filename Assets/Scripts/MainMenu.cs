using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image CrossFader; // Reference to the UI image used for the fade out effect
    public float fadeOutDuration = 1.0f; // Duration of the fade out effect in seconds

    private bool isFading = false; // Flag to indicate if a fade out effect is currently in progress

    public void LoadNextScene()
    {
        if (!isFading)
        {
            StartCoroutine(FadeOutAndLoadScene());
        }
    }

    private IEnumerator FadeOutAndLoadScene()
    {
        isFading = true;

        // Set the alpha of the fade out image to 0 and make it visible
        CrossFader.color = new Color(0, 0, 0, 0);
        CrossFader.gameObject.SetActive(true);

        // Fade out the image
        float elapsedTime = 0;
        while (elapsedTime < fadeOutDuration)
        {
            float alpha = Mathf.Lerp(0, 1, elapsedTime / fadeOutDuration);
            CrossFader.color = new Color(0, 0, 0, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        isFading = false;
    }
public void QuitGame () 
{
    Debug.Log ("QUIT");
 
    Application.Quit();
}



}


