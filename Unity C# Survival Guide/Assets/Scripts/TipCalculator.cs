using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public float bill = 40f;
    public float tipRate = .2f;
    public float total;

    // Start is called before the first frame update
    void Start()
    {
        total = bill * tipRate + bill;

        Debug.Log("Your bill is: " + bill + " and your tip amount is: " + tipRate + " So you owe: $" + total);
    }

}
