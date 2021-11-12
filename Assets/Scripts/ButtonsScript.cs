using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public GameObject pause;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayAgain()
    {
        Time.timeScale = 1;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void Cancel()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
    }
    public void DisplayPauseMenu()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
    }

    public void ExitButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("menuscene");
    }
}
