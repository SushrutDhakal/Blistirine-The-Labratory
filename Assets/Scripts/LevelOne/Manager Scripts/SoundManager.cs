using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //Required variables 
    public static AudioClip syringeSound, smokeSound, freezeSound, timeSound, puzzleMove, pressureSound, alarmSound, reloadSound, shootSound, pinSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        //All sounds mapped 
        syringeSound = Resources.Load<AudioClip>("syringe");
        smokeSound = Resources.Load<AudioClip>("smoke");
        freezeSound = Resources.Load<AudioClip>("freeze");
        timeSound = Resources.Load<AudioClip>("time");
        puzzleMove = Resources.Load<AudioClip>("puzzleMove");
        pressureSound = Resources.Load<AudioClip>("pressure");
        alarmSound = Resources.Load<AudioClip>("alarm");
        reloadSound = Resources.Load<AudioClip>("reload");
        shootSound = Resources.Load<AudioClip>("shoot");
        pinSound = Resources.Load<AudioClip>("pin");

        audioSrc = GetComponent<AudioSource>();
    }

    //Switch cases that can be called in any script using a string input 
    public static void PlaySound(string clip)
    { 
        switch (clip)
        {
            case "syringe":
                audioSrc.PlayOneShot (syringeSound) ; 
                break;

            case "smoke":
                audioSrc.PlayOneShot(smokeSound);
                break;

            case "freeze":
                audioSrc.PlayOneShot(freezeSound);
                break;

            case "time":
                audioSrc.PlayOneShot(timeSound);
                break;

            case "puzzleMove":
                audioSrc.PlayOneShot(puzzleMove);
                break;

            case "pressure":
                audioSrc.PlayOneShot(pressureSound);
                break;

            case "alarm":
                audioSrc.PlayOneShot(alarmSound);
                break;

            case "reload":
                audioSrc.PlayOneShot(reloadSound);
                break;

            case "shoot":
                audioSrc.PlayOneShot(shootSound);
                break;

            case "pin":
                audioSrc.PlayOneShot(pinSound);
                break;
        }
    }
}
