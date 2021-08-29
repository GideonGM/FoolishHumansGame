using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// attach to UI Text component (with the full text already there)

public class TextTypingThreeScript : MonoBehaviour
{
    Text txt;
    int counter = 0;
    string story;
    GameObject blank;
    GameObject angry;
    GameObject happy;
    GameObject salute;
    GameObject humanimage;
    Vector3 fiftyback;
    Vector3 fiftyforward;

    void Awake()
    {
        blank = GameObject.Find("TalkAlienBlank");
        angry = GameObject.Find("TalkAlienAngry");
        happy = GameObject.Find("TalkAlienHappy");
        salute = GameObject.Find("TalkAlienSalute");
        humanimage = GameObject.Find("TalkHumanImage");
        fiftyback = new Vector3(0, 0, 50);
        fiftyforward = new Vector3(0, 0, -50);
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
                txt.text = "These HUMANS may be even more FOOLISH than we thought!";
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
                    txt.text = "Please pause for our Broodmind mandated evil laugh.";
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
                    blank.transform.position += fiftyback;
                    happy.transform.position += fiftyforward;
                    txt.text = "MUAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA!!!";
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
                    blank.transform.position += fiftyforward;
                    happy.transform.position += fiftyback;
                    txt.text = "Grand! Now, onto your next, and final assignment!";
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
                    txt.text = "You shall usurp the highest position of power in human government...";
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
                txt.text = "THE PRESENT-DENT!";
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
                txt.text = "Of course, not that it'll be any more difficult than before.";
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
                salute.transform.position += fiftyforward;
                blank.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "Good luck Zaglarian #16728! The fate of this planet rests in your claws!";
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
                happy.transform.position += fiftyforward;
                salute.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "And hopefully said fate is one very much on fire!";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                SceneManager.LoadScene("Questions3");
                return;
            }
        }
    }
}