using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float[] _quizScores = new float[5];

    [SerializeField]
    private float totalScores;

    [SerializeField]
    private float _classAverageScore;
    
    // 5 quiz grades
    // calculate the average quiz grades
    // that prints out the grade average based on this scenario

    // Print A -> >= 90
    // Print B -> >= 80 but less than 90
    // Print C -> >=70 but less than 80
    // Print F -> less than 70

    // Start is called before the first frame update
    void Start()
    {
        // Randomize, cause it's more fun!
        for(int i = 0; i < _quizScores.Length; i++)
        {
            float score = Random.Range(0f, 100f);
            _quizScores[i] = score;
            totalScores += score;
        }

        _classAverageScore = totalScores / _quizScores.Length;

        char classAverageLetterGrade;

        // We can get away with logic where we're just testing the minimum rather than a range
        // if we order our conditions in decrementing order.
        // if we didn't then we'd have to make the conditional logic more complex

        if (_classAverageScore >= 90)
        {
            classAverageLetterGrade = 'A';
        }
        else if (_classAverageScore >= 80)
        {
            classAverageLetterGrade = 'B';
        }
        else if (_classAverageScore >= 70)
        {
            classAverageLetterGrade = 'C';
        } else
        {
            classAverageLetterGrade = 'F';
        }
        Debug.Log("The class average letter grade is: " + classAverageLetterGrade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
