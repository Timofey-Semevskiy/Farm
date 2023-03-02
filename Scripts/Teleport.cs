using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEditor.VersionControl;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public MessageManager messageManager;
    public Transform Where;
    public GameObject player;



    public float distance;

   
    public bool checkPort = false;
    


    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E) && checkPort == true)
        {
            player.transform.position = new Vector2(Where.transform.position.x, Where.transform.position.y + distance);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
           
            checkPort = true;
            messageManager.pressE.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        checkPort = false;
        messageManager.pressE.gameObject.SetActive(false);
    }
}
