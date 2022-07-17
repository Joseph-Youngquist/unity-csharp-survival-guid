using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create a program that when you hit the space key, you  increment a score value. When that score value is greater
    // than 50, you turn the cube green. At the start of the program, set the cube to red.

    [SerializeField]
    private GameObject _cube;

    [SerializeField]
    private int _score;

    private Renderer _cubeRenderer;
    private bool _colorHasChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        if (_cube == null)
        {
            Debug.LogError("Player::Start() - cube is null");
        }

        _cubeRenderer = _cube.GetComponent<Renderer>();

        if (_cubeRenderer == null)
        {
            Debug.LogError("Player::Start - cube renderer is null");
        }

        _cubeRenderer.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
        }

        if (_score > 50 && _colorHasChanged == false)
        {
            _cubeRenderer.material.color = Color.green;
            _colorHasChanged = true;
        }
    }
}
