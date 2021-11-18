using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Check if console has been clicked, check# of bosses remaining

public class Door : MonoBehaviour
{
    bool consoleClick = false;
    int bosses = 2; //set to check how many Boss tagged enemies remain LATER

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check & update boss #

        //if tag == tutorial
        if (gameObject.CompareTag("Tutorial") == true){
            if (consoleClick == true)//if console has been interacted with
            {
                Destroy(gameObject);
            }
        }

        //if tag == bosses
        if (gameObject.CompareTag("Boss") == true)
        {
            if (bosses == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
