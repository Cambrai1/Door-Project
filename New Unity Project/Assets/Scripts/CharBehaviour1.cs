using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace ISS
{
    public class CharBehaviour1 : MonoBehaviour
    {
        [SerializeField]
        private float m_speed = 20.0f;

        [SerializeField]
        private Slider slider;

        [SerializeField]
        private Image image;

        private Transform m_transform;
        public Rigidbody rb;
        public float speed = 10.0f;
        public int moveSpeed = 10;
        public float downTime, upTime, power;
        public float minJump = 10;
        public float maxJump = 20;
        public float heightY;

        Vector3 down = new Vector3(0, -1, 0);
        void Start()
        {
            m_transform = GetComponent<Transform>();
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (GameObject.Find("Character").GetComponent<CharBehaviour1>().heightY < 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            heightY = transform.position.y;

            //image.enabled = !(slider.value == 10);

            //if statement for W key press.
            if (Input.GetKey("w"))
            {
                //if statement that increases the capsule character's forward velocity by 3x the standard movement speed
                //when the left shift key and the W key is held down.
                if (Input.GetKey("left shift"))
                {
                    rb.velocity += m_transform.forward * m_speed * Time.deltaTime * 3.0f;
                }
                //else statement that increases the capsule character's forward velocity by just the standard movement speed
                //when just the W key is held down.
                else
                {
                    rb.velocity += m_transform.forward * m_speed * Time.deltaTime;
                }
            }


            //if statement for S key press.
            if (Input.GetKey("s"))
            {
                //if statement that decreases the capsule character's forward velocity by 3x the standard movement speed
                //when the left shift key and the S key is held down.
                if (Input.GetKey("left shift"))
                {
                    rb.velocity -= m_transform.forward * m_speed * Time.deltaTime * 3.0f;
                }
                //else statement that decreases the capsule character's forward velocity by just the standard movement speed
                //when just the W key is held down.
                else
                {
                    rb.velocity -= m_transform.forward * m_speed * Time.deltaTime;
                }
            }

            //if statement for A key press.
            if (Input.GetKey("a"))
            {
                //if statement that decreases the capsule character's right velocity by 3x the standard movement speed
                //when the left shift key and the A key is held down.
                if (Input.GetKey("left shift"))
                {
                    rb.velocity -= m_transform.right * m_speed * Time.deltaTime * 3.0f;
                }
                //else statement that decreases the capsule character's right velocity by just the standard movement speed
                //when just the A key is held down.
                else
                {
                    rb.velocity -= m_transform.right * m_speed * Time.deltaTime;
                }
            }

            //if statement for D key press.
            if (Input.GetKey("d"))
            {
                //if statement that increases the capsule character's right velocity by 3x the standard movement speed
                //when the left shift key and the D key is held down.
                if (Input.GetKey("left shift"))
                {
                    rb.velocity += m_transform.right * m_speed * Time.deltaTime * 3.0f;
                }
                //else statement that increases the capsule character's right velocity by just the standard movement speed
                //when just the D key is held down.
                else
                {
                    rb.velocity += m_transform.right * m_speed * Time.deltaTime;
                }
            }

        }
    }
}
