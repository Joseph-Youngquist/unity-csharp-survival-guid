using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int WeaponID;

    // id 1 = gun
    // id 2 = knife
    // id 3 = Machine Gun

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            WeaponID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            WeaponID = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            WeaponID = 3;
        }

        MessageSelectedWeapon();
        
    }

    void MessageSelectedWeapon()
    {
        string _message;

        switch (WeaponID)
        {
            case 1:
                _message = "You have selected the Gun!";
                break;
            case 2:
                _message = "You have selected the Knife!";
                break;
            case 3:
                _message = "You have selected the Machine Gun!";
                break;
            default:
                _message = "You have no weapons selected!";
                break;
        }

        Debug.Log(_message);
    }
}
