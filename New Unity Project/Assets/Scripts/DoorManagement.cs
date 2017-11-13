using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ISS
{
    public class DoorManagement : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        [SerializeField]
        private Animator AnimateDoor;

        [SerializeField]
        private AudioSource WooshSound;
        public bool isOpen = false;

        // Update is called once per frame
        void Update()
        {
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

            if (GameObject.Find("Character").GetComponent<CharBehaviour1>().heightY < 0)
            {
                AnimateDoor.SetTrigger("Close");
                isOpen = !isOpen;

                GameObject.Find("Character").transform.position = new Vector3(0.586f, 1.637555f, -42.42f);
            }

        }
    }
}

