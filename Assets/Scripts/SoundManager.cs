using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
        {
         if(!PlayerPrefs.HasKey("musicvolume"))
           {
            PlayerPrefs.SetFloat("musicvolume",1 );
           }
            else
           {
            load();
           }
        }

    public void changevolume()
       {
           AudioListener.volume = volumeSlider.value ;
           save();
       }

    private void load()
       {
        volumeSlider.value =PlayerPrefs.GetFloat("musicvolume");
       }

       private  void save()
       {
        PlayerPrefs.SetFloat("musicvolume",volumeSlider.value );
       }
}
