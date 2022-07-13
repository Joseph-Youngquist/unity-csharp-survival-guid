using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string name = "Joe";
    public int age = 46;
    public float speed = 3.4f;
    public int score = 0;
    public int health = 100;
    public int ammoCount = 10;
    public bool hasAllKeys = false;

    // Start is called before the first frame update
    void Start()
    {
        string textToPrint = "Hello " + name + "! Welcome to the game where you need to find all the keys...and stay alive!\n";
        textToPrint += "I see that you are " + age + " years old.\n";
        Debug.Log(textToPrint);
        textToPrint = "You're a bit on the slow side with a running speed of " + speed + " feet per second...Good Luck with that!\n";
        textToPrint += "The good news is you have full health (" + health + ") and you have a full clip of ammo that holds " + ammoCount + " rounds\n";
        Debug.Log(textToPrint);
        textToPrint = "You need to find all the keys since you status is " + hasAllKeys + "\n";
        textToPrint += "Since you just started the game, your score is " + score;
        Debug.Log(textToPrint);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
