using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    // Toggle a button between its pressed and unpressed state

    public GameObject switch1;
    public GameObject switch2;
    
    public float moveValue = 0.15f; // value to move button by
    public float upPos = 0.3f;      // default button position
    
    public bool switchPressed;

    Vector3 tempPos;
    
    // Start is called before the first frame update
    void Start()
    {
        switch1 = GameObject.FindWithTag("Switch1");
        switch2 = GameObject.FindWithTag("Switch2");

        tempPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Handles the user clicking a button.
    private void OnMouseDown()
    {
        // if the button clicked was switch1
        if (gameObject == switch1)
        {
            // if switch2 hasn't been pressed
            if (switch2.GetComponent<Click>().switchPressed == false)
            {
                MoveButton();
            }
        }
        else
        {
            // if switch1 hasn't been pressed
            if (switch1.GetComponent<Click>().switchPressed == false)
            {
                MoveButton();
            }
        }
        transform.position = tempPos;
    }

    // moves the button within the program
    private void MoveButton()
    {
        if (tempPos.y < upPos)
        {
            tempPos.y += moveValue;
            switchPressed = false;
        }
        else
        {
            tempPos.y += -moveValue;
            switchPressed = true;
        }
    }
}
