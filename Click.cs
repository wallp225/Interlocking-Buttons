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
    
    Vector3 tempPos;
    
    public bool switchPressed;

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

    private void OnMouseDown()
    {
        if(tempPos.y < upPos)
        {
            Debug.Log("Button Up");
            tempPos.y += moveValue;
            switchPressed = false;
        } else {
            Debug.Log("Button Down");
            tempPos.y += -moveValue;
            switchPressed = true;
        }
        transform.position = tempPos;
        Debug.Log("switch1 pressed? " + switch1.GetComponent<Click>().switchPressed);
        Debug.Log("switch2 pressed? " + switch2.GetComponent<Click>().switchPressed);
    }
}
