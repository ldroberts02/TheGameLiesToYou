using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Question Card")]





public class QuestionCard : ScriptableObject
{
    public string question;
    public List<string> answers;
    public int correctAnswer;


}