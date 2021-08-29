using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CreditsButtonHoverOver : MonoBehaviour
{
    GameObject button;
    Vector3 positionUp;
    Vector3 positionDown;


    void Start()
    {
        button = GameObject.Find("CreditsButtonHover");
        positionUp = new Vector3(0, 0, -10);
        positionDown = new Vector3(0, 0, 10);
    }

    void OnMouseEnter()
    {
        button.transform.position += positionUp;
    }
    void OnMouseExit()
    {
        button.transform.position += positionDown;
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene("Credits");
    }
}
