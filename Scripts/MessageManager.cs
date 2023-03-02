using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour
{
    
    public  GameObject pressE;

    private void Update()
    {
       
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            pressE.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pressE.SetActive(false);
    }

}
