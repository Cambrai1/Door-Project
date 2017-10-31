using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }

    [SerializeField]
    private Animator door1;

    [SerializeField]
    private Animator door2;

    private bool isOpen = false;

    // Update is called once per frame
    void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isOpen)
            {
                door1.SetTrigger("Close Doors");
                door2.SetTrigger("Close Doors");
            }
            else
            {
                door1.SetTrigger("Open Doors");
                door2.SetTrigger("Open Doors");
            }

            isOpen = !isOpen;
        }
       
        
	}
}
