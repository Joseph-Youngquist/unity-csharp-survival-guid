using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create a program that turns a cube into different colors based on user input
    // 1 key = blue
    // 2 key = red
    // 3 key = green
    // 4 key = black

    [SerializeField]
    private GameObject _cube;

    private Renderer _cubeRender;

    private Color _colorToUse;
    private char _keyPressed;

    // Start is called before the first frame update
    void Start()
    {
        if (_cube == null)
        {
            Debug.LogError("Player::Start() - Cube is null");
        }

        _cubeRender = _cube.GetComponent<Renderer>();

        if (_cubeRender == null)
        {
            Debug.LogError("Player::Start() - Cube Renderer is null");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _keyPressed = '1';
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _keyPressed = '2';
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _keyPressed = '3';
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _keyPressed = '4';
        }

        switch(_keyPressed)
        {
            case '1':
                _colorToUse = Color.blue;
                break;
            case '2':
                _colorToUse = Color.red;
                break;
            case '3':
                _colorToUse = Color.green;
                break;
            case '4':
                _colorToUse = Color.black;
                break;
            default:
                _colorToUse = Color.white;
                break;
        }

        _cubeRender.material.color = _colorToUse;
    }
}
