using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project2D
{
    enum ControlsType { WASD, ARROWS }

    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] ControlsType controls;

        [SerializeField] float speedMovement = 0.0f;

        [SerializeField] SpriteController sc = null;

        public delegate void SpriteChangeHandler(Sprite s);
        public event SpriteChangeHandler spriteChange;

        KeyCode up;
        KeyCode down;
        KeyCode left;
        KeyCode right;
        SpriteRenderer sr;



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
            sr = GetComponent<SpriteRenderer>();
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
                sc.SetSprite(ref sr, SpriteType.UP);
            }
            if (Input.GetKey(down))
            {
                MoveDown();
                sc.SetSprite(ref sr, SpriteType.DOWN);
            }
            if (Input.GetKey(left))
            {
                MoveLeft();
                sc.SetSprite(ref sr, SpriteType.LEFT);
            }
            if (Input.GetKey(right))
            {
                MoveRight();
                sc.SetSprite(ref sr, SpriteType.RIGHT);
            }

            if (!Input.GetKey(up) && !Input.GetKey(down) && !Input.GetKey(left) && !Input.GetKey(right))
            {
                sc.SetSprite(ref sr, SpriteType.IDLE);
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
