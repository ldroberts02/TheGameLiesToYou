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
    public TMP_Text questionText; //sets the question text outside of editor
    public List<TMP_Text> answerTexts;
    public QuestionCard questionCard; //qcrd
    public int currentQuestion;

    public MascotActions MascotActionsScript; //msctactscr

	public setCursor SetCursor; //cscur

	public QuestionArray questionArray; //csqary




    void Start()
    {
        
        questionText.text = questionCard.question;

        for(int i = 0; i < 4; i++) //this loop means that, starting with i is set equal to zero, do what is inside of it, so on start, increase  i by one, then do the thing, then add 1, until it reaches zero
        {

            answerTexts[i].text = questionCard.answers[i];
        }
        
        questionCard.correctAnswer = questionArray.Question[currentQuestion].correctAnswer;

    }


    public void ButtonPressed(int buttonnum) //for when the button is pressed, it should progress the question as well as consider it correct or incorrect, but it should not use currentQuestion ++; more than ONCE.
    {
        //Debug.Log(answerTexts[buttonnum].text);


        if (buttonnum == questionCard.correctAnswer)
        {
            //Debug.Log("Correct");
			SetCursor.cursorName = "Gun";		
		
            MascotActionsScript.correctMascot();    


        }

        else if (buttonnum != questionCard.correctAnswer)
        //here goes the raise mood by 1, max 8
        {
            //Debug.Log("Wrong");
			
			SetCursor.cursorName = "FlSword";	
			
            MascotActionsScript.wrongMascot();
            //here should go code that calls the MascotActions and lowers the mood by 1
        }


        currentQuestion++; //increments the currentQuestion variable, which in turn allows for the next line to function
        if (currentQuestion >= questionArray.Question.Count)
        {
            return; //if the maximum questions have been reached in a list
        }

        questionCard.correctAnswer = questionArray.Question[currentQuestion].correctAnswer;


        questionText.text = questionArray.Question[currentQuestion].question; //using the previous line, it checks for the number of the question in the array of questions, which in turn updates text that is tied to this
        
        // questionCard.currentAnswer = questionArray.Question[currentQuestion].currentAnswer;

        answerTexts[currentQuestion].text = questionArray.Question[currentQuestion].answers[currentQuestion]; //sets all 4 buttons

        for(int i = 0; i < 4; i++)
        {
            Debug.Log("1");
            answerTexts[i].text = questionCard.answers[i];



        }
        

    }

    public void DebugButtonPressed(string reason) //debug, the string is assigned by the item, so it would help sort things
    {
        Debug.Log(questionCard.correctAnswer);


    }



}
