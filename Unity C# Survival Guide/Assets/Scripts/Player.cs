using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create a program that lets you increment the speed when you hit the "s" key
    // and the "A" key decrements the speed.
    // When the speed is greater than 20 then print "Slow down"
    // when the speed is 0 print "you need to speed up!"
    // you can't go below zero.

    [SerializeField]
    private int _speed = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _speed++;
        }
        else if (Input.GetKeyDown(KeyCode.A) && _speed > 0)
        {
            _speed--;
        }

        if (_speed > 20)
        {
            Debug.Log("Slow Down!");
        }
        else if (_speed == 0)
        {
            Debug.Log("You need to speed up!");
        }

    }
}
