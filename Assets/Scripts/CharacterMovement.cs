using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project2D
{
    enum ControlsType { WASD, ARROWS }

    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] float speedMovement = 5;

        [SerializeField] ControlsType controls;

        KeyCode up;
        KeyCode down;
        KeyCode left;
        KeyCode right;



        void Awake()
        {
            switch (controls)
            {
                case ControlsType.WASD:
                    up = KeyCode.W;
                    down = KeyCode.S;
                    left = KeyCode.A;
                    right = KeyCode.D;
                    break;
                    
                case ControlsType.ARROWS:
                    up = KeyCode.UpArrow;
                    down = KeyCode.DownArrow;
                    left = KeyCode.LeftArrow;
                    right = KeyCode.RightArrow;
                    break;
            }
        }

        void Update()
        {
            Movement();
        }



        void Movement()
        {
            if (Input.GetKey(up))
            {
                MoveUp();
            }
            if (Input.GetKey(down))
            {
                MoveDown();
            }
            if (Input.GetKey(left))
            {
                MoveLeft();
            }
            if (Input.GetKey(right))
            {
                MoveRight();
            }
        }

        void MoveUp()
        {
            transform.position += new Vector3(0.0f, speedMovement) * Time.deltaTime;
        }
        void MoveDown()
        {
            transform.position += new Vector3(0.0f, -speedMovement) * Time.deltaTime;
        }
        void MoveLeft()
        {
            transform.position += new Vector3(-speedMovement, 0.0f) * Time.deltaTime;
        }
        void MoveRight()
        {
            transform.position += new Vector3(speedMovement, 0.0f) * Time.deltaTime;
        }
    }
}
