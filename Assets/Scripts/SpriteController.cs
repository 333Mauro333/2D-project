using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project2D
{
    public enum SpriteType { IDLE, UP, DOWN, LEFT, RIGHT }

    public class SpriteController : MonoBehaviour
    {
        [SerializeField] Sprite idle;

        [SerializeField] Sprite up;
        [SerializeField] Sprite down;
        [SerializeField] Sprite left;
        [SerializeField] Sprite right;



        public void SetSprite(ref SpriteRenderer sr, SpriteType newS)
        {
            if (sr.sprite != GetSprite(newS))
            {
                sr.sprite = GetSprite(newS);
            }
        }

        Sprite GetSprite(SpriteType st)
        {
            switch (st)
            {
                case SpriteType.IDLE:
                    return idle;

                case SpriteType.UP:
                    return up;

                case SpriteType.DOWN:
                    return down;

                case SpriteType.LEFT:
                    return left;

                case SpriteType.RIGHT:
                    return right;

                default:
                    return null;
            }
        }
    }
}
