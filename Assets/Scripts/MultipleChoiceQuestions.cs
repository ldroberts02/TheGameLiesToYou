/*MultipleChoiceQuestions.cs
this script is for the text and buttons inside the game, and will use this alongside the other question scripts to determine multiple factors.
Variables
SetCursor - 



*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultipleChoiceQuestions : MonoBehaviour
{
    public TMP_Text questionText;
    public List<TMP_Text> answerTexts;
    public QuestionCard questionCard; //prob get rid of this, or rewrite any mention of it
    public int currentQuestion;

	public setCursor SetCursor;
//calls setcursor.cs
	public QuestionArray questionArray;
//calls QuestionArray.cs

    // Start is called before the first frame update
    void Start()
    {
        questionText.text = questionCard.question;

        for(int i = 0; i < 4; i++)
        {
            answerTexts[i].text = questionCard.answers[i];
        }
    }


    public void ButtonPressed(int index) //for when the button is pressed, it should progress the question as well as consider it correct or incorrect, but it should not use currentQuestion ++; more than ONCE.
    {
        //Debug.Log(answerTexts[index].text);

        if (index == questionCard.correctAnswer)
        {
            //Debug.Log("Correct");
			SetCursor.cursorName = "Gun";		
		
			//right here is code thats gonna check the question array, then check the question to update to, so array goes from 0 to 1, then updates text.
			
			//to call questionArray, use questionArray.Question[currentQuestion].(name of either question, answer, or something else)
        }

        else if (index != questionCard.correctAnswer)
        //here goes the raise mood by 1, max 8
        {
            //Debug.Log("Wrong");
			
			SetCursor.cursorName = "FlSword";	
			
            //here should go code that calls the MascotActions and lowers the mood by 1
        }

        //below is what to do AFTER both right and wrong answers have been considered

        currentQuestion++; //increments the currentQuestion variable, which in turn allows for the next line to function
        if (currentQuestion >= questionArray.Question.Count)
        {
            return; //if the maximum questions have been reached in a list
        }
        questionText.text = questionArray.Question[currentQuestion].question; //using the previous line, it checks for the number of the question in the array of questions, which in turn updates all text that is tied to this

        for(int i = 0; i < 4; i++)
        {
            answerTexts[i].text = questionArray.Question[currentQuestion].answers[i]; //to call questionArray, use questionArray.Question[currentQuestion].(name of either question, answer, or something else)
        }
    }



}
