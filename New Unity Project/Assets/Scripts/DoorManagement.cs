using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }

    [SerializeField]
    private Animator AnimateDoor;

    [SerializeField]
    private AudioSource WooshSound;
    private bool isOpen = false;

    // Update is called once per frame
    void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {

            if (isOpen)
            {
                AnimateDoor.SetTrigger("Close");

            }
            else
            {
                AnimateDoor.SetTrigger("Open");
                WooshSound.Play();
            }

            isOpen = !isOpen;
        }
       
        
	}
}
