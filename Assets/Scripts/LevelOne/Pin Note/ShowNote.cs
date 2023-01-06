using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShowNote : MonoBehaviour
{
    public GameObject Note;
    public GameObject drawerOpen;

    [SerializeField]
    public TMP_Text hint;

    //7317
    static string hintOne = "I am a four-digit code\r\nThat you must solve to progress\r\nMy second digit is three times my third\r\nTwo of my digits are the same\r\nTwo of my digits is a factor of 49\r\nAll of my digits are odd\r\nThe sum of my digits is 18";

    //6488
    static string hintTwo = "I am a four-digit code\r\nThat you must solve to progress\r\nMy first letter is hex in Greek\r\nMy second digit is half of my third and last\r\nAll of my digits are even\r\nMy second digit is two less than my fourth\r\nThe sum of my digits is 26";

    //3481
    static string hintThree = "I am a four-digit code\r\nThat you must solve to progress\r\nMy second digit is a half of my third\r\nMy first digit is three times of my last\r\nMy second and third digits are even\r\nMy last digit is the first odd integer\r\nThe sum of my digits is 16";

    //9265
    static string hintFour = "I am a four-digit code\r\nThat you must solve to progress\r\nMy second digit is a third of my third\r\nMy second and third digits are multiples of 2\r\nMy first digit is a factor of 81\r\nThe sum of my digits is 22";

    //3432
    static string hintFive = "I am a four-digit code\r\nThat you must solve to progress\r\nTwo of my digits are the same and odd\r\nMy last digit is half of my second and even\r\nAll of my digits are less than 5\r\nOne of digits is 4\r\nThe sum of my digits is 12";

    public int pin;

    void Start()
    {
        Note.SetActive(false);
    }

    public void showNote()
    {
        drawerOpen.SetActive(false);

        string[] hints = { hintOne, hintTwo, hintThree, hintFour, hintFive };
        int[] pins = { 7317, 6488, 3481, 9265, 3432 };

        int randomHint = Random.Range(0, 5);
        hint.text = hints[randomHint];
        pin = pins[randomHint];
        Debug.Log(pin);
        Note.SetActive(true);
    }


}
