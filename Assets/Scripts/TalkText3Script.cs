using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// attach to UI Text component (with the full text already there)

public class TalkText3Script : MonoBehaviour
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
        humanimage = GameObject.Find("TalkPresidentImage");
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
                happy.transform.position += fiftyforward;
                blank.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "Who would've thunk that all it takes is to appeal to the common masses by spouting out a series of incredibly vague and agressive statements!?";
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
                    txt.text = "They truly are FOOLISH HUMANS!!!";
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
                    blank.transform.position += fiftyforward;
                    happy.transform.position += fiftyback;
                    StopAllCoroutines();
                    txt.text = "The Grand Broodmind is so proud of you Zaglarian #16728!";
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
                    txt.text = "Please let your vision-sphere enjoy this informative image of your new reign!";
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
                    humanimage.transform.position += fiftyforward;
                    StopAllCoroutines();
                    txt.text = "...";
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
                blank.transform.position += fiftyback;
                happy.transform.position += fiftyforward;
                humanimage.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "Grand isn't it? That's not even all! There are plenty more rewards to com-";
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
                blank.transform.position += fiftyforward;
                happy.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "Oh, hold on I'm getting a message.";
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
                txt.text = "...";
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
                blank.transform.position += fiftyback;
                angry.transform.position += fiftyforward;
                StopAllCoroutines();
                txt.text = "...";
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
                txt.text = "Ah, it appears as if the wormhole our entire murderous battlefleet fell into wasn't actually deadly...";
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
                txt.text = "They're perfectly fine so uh...";
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
            if (counter == 11)
            {
                StopAllCoroutines();
                txt.text = "We're scrapping the program.";
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
            if (counter == 12)
            {
                blank.transform.position += fiftyforward;
                angry.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "...";
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
            if (counter == 13)
            {
                StopAllCoroutines();
                txt.text = "Erm, I suppose you can just uh, return to your broodhive...";
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
            if (counter == 14)
            {
                StopAllCoroutines();
                txt.text = "Erm...";
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
            if (counter == 15)
            {
                salute.transform.position += fiftyforward;
                blank.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "Praise the Broodmind!";
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
            if (counter == 16)
            {
                salute.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "(The End!)";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                SceneManager.LoadScene("Menu");
                return;
            }
        }
    }
}