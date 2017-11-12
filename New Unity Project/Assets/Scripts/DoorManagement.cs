using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }

    [SerializeField]
    private Animator AnimateDoor;

    private bool isOpen = true;

    // Update is called once per frame
    void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {

            if (isOpen)
            {
                AnimateDoor.SetTrigger("AnimateDoor");

            }
            else
            {
                AnimateDoor.SetTrigger("AnimateDoor");
            }

            isOpen = !isOpen;
        }
       
        
	}
}
