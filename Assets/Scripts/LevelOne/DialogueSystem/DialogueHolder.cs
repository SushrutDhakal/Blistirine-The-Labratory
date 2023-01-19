using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DialogueSystem
{
    public class DialogueHolder : MonoBehaviour
    {
        [Header("After Scene")]
        [SerializeField] public string Scene;

        private void Awake ()
        {
            StartCoroutine(dialogueSequence());
        }
        
        private IEnumerator dialogueSequence ()
        {
            for (int i=0; i < transform.childCount; i++)
            {
                Deactivate ();
                transform.GetChild(i).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finished);
            }
            gameObject.SetActive(false);
            
            if (! (Scene == ""))
            {
                SceneManager.LoadScene(Scene);
            }
        }

        private void Deactivate ()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
