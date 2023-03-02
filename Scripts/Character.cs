using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    public List<StatBar> statList = new List<StatBar>()
    {
        
    };

    [SerializeField, Range(0f, 100f)]
    float speed;
    [SerializeField]
    Collider2D collider;
    
    


    public int strength = 100;
    public int sleepy = 100;
    public int agility = 100;
    


    void Start()
    {
       collider =  GetComponent<Collider2D>();

        statList[0].SetMaxSleepy(strength);
        statList[1].SetMaxSleepy(sleepy);
        statList[2].SetMaxAgility(agility);
       
    }

    // Update is called once per frame
    void Update()
    {

       
        Vector2 playerInput;
        playerInput.x = Input.GetAxis("Horizontal");
        playerInput.y = Input.GetAxis("Vertical");
        playerInput = Vector2.ClampMagnitude(playerInput, 1f);
        Vector3 displacement = new Vector3(playerInput.x, playerInput.y,0f) * speed * Time.deltaTime;
        transform.localPosition += displacement;
        
    }
  
}
