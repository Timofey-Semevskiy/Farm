using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ChangeSprite : MonoBehaviour 
{
  
    public GameObject player;
    public Tilemap tilemap;
    public TileBase titleGardenBed;
    public StatBar stat;
    public Character character;
    


    public Vector3Int location;


    public int tired = 10;

    public bool checkGardenBed = false;


    private void Update()
    {
        //копать грядку
        DigAGarden();
        

    }

    private void DigAGarden()
    {
        if (checkGardenBed == true)
        {
            Vector3 playerPosition = player.transform.position;
            if (Input.GetKeyDown(KeyCode.Space) && stat.slider.value != 0)
            {
                location = tilemap.WorldToCell(playerPosition);
                tilemap.SetTile(location, titleGardenBed);
                // вычит силы за действие 
                stat.SetStrength((int)stat.slider.value - tired);
                // вычит сна за действие 
                character.statList[2].SetSleepy((int)stat.slider.value - tired);
               
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            checkGardenBed = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        checkGardenBed = false;
    }
}
