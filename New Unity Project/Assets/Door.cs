using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	[SerializeField]
	private Animator door1;

	private bool isOpen = false;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (isOpen)
			{
				door1.SetTrigger("Close Doors");
			}
			else
			{
				door1.SetTrigger("Open Doors");
			}

			isOpen = !isOpen;
		}


	}
}
