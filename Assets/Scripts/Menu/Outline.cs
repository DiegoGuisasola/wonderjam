using System;
using UnityEngine;

namespace Menu
{
    public class Outline : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer outlineSprite;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                ToggleOutline(true);
                Debug.Log("Entered");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                ToggleOutline(false);
                Debug.Log("Exited");
            }
        }

        private void ToggleOutline(bool toggleOutline)
        {
            if (toggleOutline)
            {
                Color tmp = outlineSprite.color;
                tmp.a = 0f;
                outlineSprite.color = tmp;
            }
            else
            {
                Color tmp = outlineSprite.color;
                tmp.a = 1f;
                outlineSprite.color = tmp;
            }
        }
    }
}
