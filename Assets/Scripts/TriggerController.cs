using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        sr.color = Color.red;
        Debug.Log("Entró");
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        sr.color = Color.white;
        Debug.Log("Salió");
    }
}
