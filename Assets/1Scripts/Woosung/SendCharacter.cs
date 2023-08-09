using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("C_Data"))
        {
            int data = PlayerPrefs.GetInt("C_Data");
            Debug.Log("Character data : " + data);
        }
        else
        {
            Debug.Log("No character data found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
