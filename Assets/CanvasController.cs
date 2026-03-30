using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject mainPanel, controlPaenl;
    public Transform man;
    private Vector3 startPos, startScale;
    private Quaternion startRotation;
    public float moveScal = 1f;
    void Start()
    {
        startPos = man.position;
        startScale = man.localScale;
        startRotation = man.localRotation;

        mainPanel.SetActive(true);
        controlPaenl.SetActive(false);
        man.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        mainPanel.SetActive(false);
        controlPaenl.SetActive(true);
        man.gameObject.SetActive(true);
    }

    public void Rotate(bool isClockwise)
    {
        if (isClockwise)
        {
            man.Rotate(0, 30f, 0, Space.World);
        }
        else
        {
            man.Rotate(0, -30f, 0, Space.World);
        }
    }

    public void BackToMainMenu()
    {
        mainPanel.SetActive(true);
        controlPaenl.SetActive(false);
    }

    public void SetSize(bool isBig)
    {
        if (isBig)
        {
            man.localScale = man.localScale - (Vector3.one * 0.2f);
        }
        else
        {
            man.localScale = man.localScale + (Vector3.one * 0.2f);
        }
    }

    public void Move(bool isright)
    {
        if (isright)
        {
            man.position += Vector3.right * moveScal;
        }
        else
        {
            man.position += Vector3.left * moveScal;
        }
    }
    public void Reset()
    {
        man.position = startPos;
        man.localScale = startScale;
        man.localRotation = startRotation;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
