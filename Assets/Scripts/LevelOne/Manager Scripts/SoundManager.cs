using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip syringeSound, smokeSound, freezeSound, timeSound, puzzleMove, puzzleWin;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        syringeSound = Resources.Load<AudioClip>("syringe");
        smokeSound = Resources.Load<AudioClip>("smoke");
        freezeSound = Resources.Load<AudioClip>("freeze");
        timeSound = Resources.Load<AudioClip>("time");
        puzzleMove = Resources.Load<AudioClip>("puzzleMove");
        puzzleWin = Resources.Load<AudioClip>("puzzleWin");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

            case "puzzleWin":
                audioSrc.PlayOneShot(puzzleWin);
                break;
        }
    }
}
