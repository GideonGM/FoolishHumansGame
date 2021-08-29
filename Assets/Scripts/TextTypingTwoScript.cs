using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// attach to UI Text component (with the full text already there)

public class TextTypingTwoScript : MonoBehaviour
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
                txt.text = "The FOOLISH HUMANS were completely convinced! Not to mention your effortless usurping of power!";
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
                    blank.transform.position += fiftyforward;
                    happy.transform.position += fiftyback;
                    txt.text = "I belive you're more than ready for larger assignments!";
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
                    txt.text = "Our next target is to usurp the position of power known as a GOVEN-NOIR.";
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
                    txt.text = "This should be acheived in the same way as before, just on a much larger scale.";
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
                    blank.transform.position += fiftyback;
                    salute.transform.position += fiftyforward;
                    StopAllCoroutines();
                    txt.text = "Good luck Zaglarian #16728, reign over the FOOLISH HUMANS with all your might!";
                    story = txt.text;
                    txt.text = "";
                    StartCoroutine("PlayText");
                    counter = counter += 1;
                    Debug.Log(counter);
                    SceneManager.LoadScene("Questions2");
                    return;
                }
            }
        }
    }
}