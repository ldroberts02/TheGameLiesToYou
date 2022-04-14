using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Question Card")]

//this gives a right click menu that is basically just a list for questions



public class QuestionCard : ScriptableObject
{
    public string question;
    public List<string> answers;
    public int correctAnswer;
//make this a nested list, wherein that list is the questions to call from in an index. (so make it like this: a list that contains a list, and index. inside that list, have the question, answers, and correct answer. then using that, call that from the side bar thing


}

