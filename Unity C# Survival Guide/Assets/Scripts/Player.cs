using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int myAge = 14;
    private int _legalAgeToDrive = 16;

    // Start is called before the first frame update
    void Start()
    {
        // if my age is greater than or equal to 16
        // then print out you can drive.

        if (myAge >= _legalAgeToDrive)
        {
            Debug.Log("You can drive!");
        }
        else
        {
            Debug.Log("You can't drive because you are not at or above the legal age to drive which is " + _legalAgeToDrive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
