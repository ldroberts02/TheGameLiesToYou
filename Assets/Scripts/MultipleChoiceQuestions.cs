using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultipleChoiceQuestions : MonoBehaviour
{
    public TMP_Text questionText;
    public List<TMP_Text> answerTexts;
    public QuestionCard questionCard;
    public int currentQuestion;


    // Start is called before the first frame update
    void Start()
    {
        questionText.text = questionCard.question;

        for(int i = 0; i < 4; i++)
        {
            answerTexts[i].text = questionCard.answers[i];
        }
    }


    public void ButtonPressed(int index)
    {
        //Debug.Log(answerTexts[index].text);

        if (index == questionCard.correctAnswer)
        {
            Debug.Log("Correct");
            currentQuestion++;
        }

        else if (index == questionCard.correctAnswer)
        //here goes the raise mood by 1, max 8
        {
            Debug.Log("Wrong");
            //here should go code that calls the MascotActions and lowers the mood by 1
        }
    }



}
