using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CollisionSounds : MonoBehaviour
{
    private MeshRenderer m;
    public AudioSource Hit;
    public AudioSource PanelHit;
    public AudioSource GroundHit;
    public AudioSource LostSound;
    public AudioSource PanelSound;
    public AudioSource WhistleSound;

    public GameObject ballon;
    public GameObject gameOver;
    public GameObject pause;

    public GameObject HitObject;
    public GameObject PanelHitObject;
    public GameObject GroundHitObject;
    public GameObject LostSoundObject;
    public GameObject PanelSoundObject;
    public GameObject WhistleSoundObject;
    public Text scoreText;
    public Text bestScoreText;
    private int bestScore=0;
    private int currentScore;
    private int a = 0;
    

  
    // Start is called before the first frame update
    void Start()
    {
        m = this.GetComponent<MeshRenderer>();
        currentScore = 0;
        bestScoreText.text = "Best Score: " + PlayerPrefs.GetInt("Best Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayPauseMenu()
    {
        pause.SetActive(true);
    }

    private void HandleScore()
    {
        scoreText.text = "Score: " + currentScore;
        if (currentScore > PlayerPrefs.GetInt("Best Score"))
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("Best Score",bestScore);
        }
        bestScoreText.text = "Best Score: " + PlayerPrefs.GetInt("Best Score");


    }
    
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "panierBasket")
        {
            PanelSoundObject.SetActive(true);
            PanelSound.Play();
        }
        if (collision.collider.tag == "poteau")
        {
            HitObject.SetActive(true);
            Hit.Play();
        }

        if (collision.collider.tag == "lost")
        {
            LostSoundObject.SetActive(true);
            gameOver.SetActive(true);
            LostSound.Play();
            Destroy(this.ballon);
            
        }
        if (collision.collider.tag == "panel")
        {
            PanelHitObject.SetActive(true);
            PanelHit.Play();
        }

        if (collision.collider.tag=="wall")
        {
            GroundHitObject.SetActive(true);
            GroundHit.Play();
        }
        if (collision.collider.tag == "ground")
        {
            a = 0;
            GroundHitObject.SetActive(true);
            GroundHit.Play();
           
        }

        if (collision.collider.tag == "goall")
        {
            Debug.Log("First collision");
            if (collision.collider.tag == "avoidGoal")
            {
                Debug.Log("Goall!!!");
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "goall")
        {
            a = 1;
            Debug.Log(a);

        }

        if (other.tag=="avoidGoal" && a==1)
        {
            Debug.Log("Goaaaaal");
            WhistleSoundObject.SetActive(true);
            WhistleSound.Play();
            currentScore++;
            HandleScore();
            a = 0;
        }
    }




}
