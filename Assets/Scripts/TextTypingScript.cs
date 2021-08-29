using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// attach to UI Text component (with the full text already there)

public class TextTypingScript: MonoBehaviour 
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
                txt.text = "You are the one for the invasion assignment yes? Zaglarian #16728?";
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
                txt.text = "Very good!";
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
                txt.text = "I suppose I should provide an explanation as to why you're here.";
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
                txt.text = "As you know, normally our planet invasion procedures would involve the use of our superior warships to completely erradicate all native life.";
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
                    txt.text = "A very efficent procedure!";
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
                txt.text = "Unfortunately, it would appear as if our pilots have, erm...";
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
                blank.transform.position += fiftyback;
                angry.transform.position += fiftyforward;
                StopAllCoroutines();
                txt.text = "Crashed our entire fleet into an incredibly deadly wormhole.";
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
                blank.transform.position += fiftyforward;
                angry.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "As you may expect, this has forced us to devise more creative invasion strategies, mostly involving the art of deception!";
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
                txt.text = "This is why we have gathered you, to disguise as a native inhabitant of an alien world, and usurp power without the foolish natives even knowing!";
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
                txt.text = "We have even given you a specially designed suit for your first assignment! Please let your vision-sphere enjoy this informative image.";
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
        if (Input.GetMouseButtonDown(0))
        {
            if (counter == 11)
            {
                humanimage.transform.position += fiftyback;
                blank.transform.position += fiftyback;
                happy.transform.position += fiftyforward;
                StopAllCoroutines();
                txt.text = "Beautiful isn't it? You can barely even notice your squizlumps!";
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
                happy.transform.position += fiftyback;
                StopAllCoroutines();
                txt.text = "This will be for your mission on EARTH, populated by FOOLISH HUMANS.";
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
                txt.text = "As a test, we will deploy you to usurp a small HUMAN community known as a NEIGHBORHOOD.";
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
                txt.text = "This will be preformed by appealing to HUMAN VOTERS, via the answering of questions.";
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
                StopAllCoroutines();
                txt.text = "Should you appeal enough, the HUMANS will ELECT you as their leader, thus giving you complete control over them!";
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
                blank.transform.position += fiftyback;
                salute.transform.position += fiftyforward;
                StopAllCoroutines();
                txt.text = "Good luck Zaglarian #16728, The Grand Broodmind which controls us all is counting on you!";
                story = txt.text;
                txt.text = "";
                StartCoroutine("PlayText");
                counter = counter += 1;
                Debug.Log(counter);
                SceneManager.LoadScene("Questions1");
                return;
            }
        }
    }
}