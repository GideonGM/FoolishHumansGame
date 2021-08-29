using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// attach to UI Text component (with the full text already there)

public class Questions2TextScript : MonoBehaviour
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
                txt.text = "You must be canadate Hughmann yes?";
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
                    txt.text = "Alright, let's conduct the interview.";
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
                    txt.text = "How do you feel about this country?";
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
                    txt.text = "What would you do in the event of a crisis?";
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
                    txt.text = "What state are we in?";
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
                txt.text = "Any big construction plans?";
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
                txt.text = "What industry are you looking to expand?";
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
                txt.text = "Well, that's all the time we have.";
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
                txt.text = "Based on the looks of the crowd...";
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
                txt.text = "I think you got this election!";
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
                txt.text = "I'll be voting for you Govenor Hughmann!";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                SceneManager.LoadScene("Talk3");
                return;
            }
        }
    }
}