using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // every item has a name
    // every item has a description
    // every item has an image icon
    // every item has an attack strength

    public string name;
    public string description;
    public float attackStrength = 1f;
    public Sprite icon;


    // Start is called before the first frame update
    void Start()
    {
        
    }
}
