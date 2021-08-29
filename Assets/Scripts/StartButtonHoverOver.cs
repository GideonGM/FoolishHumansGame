using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButtonHoverOver : MonoBehaviour
{
    GameObject button;
    Vector3 positionUp;
    Vector3 positionDown;
    

    void Start()
    {
        button = GameObject.Find("StartButtonHover");
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
        SceneManager.LoadScene("Talk1");
    }
}
