using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if we hit the space key
        // add 10 points.

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
        }

        // if points greater than or equal to 50
        // then print "you are awesome!"
        if(_score >= 50)
        {
            Debug.Log("You are awesome!");
        }
    }
}
