using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public static float[] quizScores = new float[5]; //{ 1f, 1f, 1f, 1f, 1f };
    public float scoreTotal;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0;  i < 5; i++)
        {
            float score = Random.Range(0f, 100f);
            Debug.Log("The score for " + i + " is " + score);
            quizScores[i] = score;
        }

        foreach (var score in quizScores)
        {
            scoreTotal += score;
        }

        Debug.Log("The class average on the quiz is: " + scoreTotal / 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
