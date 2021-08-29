using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// attach to UI Text component (with the full text already there)

public class Questions3TextScript : MonoBehaviour
{
    Text txt;
    int counter = 0;
    string story;

    void Awake()
    {

        txt = GetComponent<Text>();
        story = txt.text;
        txt.text = "";

        // TODO: add optional delay when to start
        StartCoroutine("PlayText");

    }

    IEnumerator PlayText()
    {
        Debug.Log("Coroutine triggered");
        foreach (char c in story)
        {
            txt.text += c;
            yield return new WaitForSeconds(0.03f);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (counter == 0)
            {
                StopAllCoroutines();
                txt.text = "I'm Reporter Wilkins";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                return;
            }
            if (Input.GetMouseButtonDown(0))
            {
                if (counter == 1)
                {
                    StopAllCoroutines();
                    txt.text = "This is an interview about your presidental candacy.";
                    story = txt.text;
                    txt.text = "";
                    StartCoroutine("PlayText");
                    counter = counter += 1;
                    Debug.Log(counter);
                    return;
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                if (counter == 2)
                {
                    StopAllCoroutines();
                    txt.text = "Let's begin.";
                    story = txt.text;
                    txt.text = "";
                    StartCoroutine("PlayText");
                    counter = counter += 1;
                    Debug.Log(counter);
                    return;
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                if (counter == 3)
                {
                    StopAllCoroutines();
                    txt.text = "Why should you be president?";
                    story = txt.text;
                    txt.text = "";
                    StartCoroutine("PlayText");
                    counter = counter += 1;
                    Debug.Log(counter);
                    return;
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                if (counter == 4)
                {
                    StopAllCoroutines();
                    txt.text = "Higher or lower taxes?";
                    story = txt.text;
                    txt.text = "";
                    StartCoroutine("PlayText");
                    counter = counter += 1;
                    Debug.Log(counter);
                    return;
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (counter == 5)
            {
                StopAllCoroutines();
                txt.text = "Favorite politician?";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                return;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (counter == 6)
            {
                StopAllCoroutines();
                txt.text = "Are you answering just to appeal to the majority?";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                return;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (counter == 7)
            {
                StopAllCoroutines();
                txt.text = "This interview is concluded.";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                return;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (counter == 8)
            {
                StopAllCoroutines();
                txt.text = "I should remain impartial but...";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                return;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (counter == 9)
            {
                StopAllCoroutines();
                txt.text = "I believe you have this election Mr. Hughmann.";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                return;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (counter == 10)
            {
                StopAllCoroutines();
                txt.text = "I look forwards to your term.";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                SceneManager.LoadScene("Talk4");
                return;
            }
        }
    }
}