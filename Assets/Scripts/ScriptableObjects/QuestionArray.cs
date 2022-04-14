using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Empty Array", menuName = "Question Array")]

//this gives a right click menu that is basically just a list for questions

public class QuestionArray : ScriptableObject
{
		public List<QuestionCard> Question;
}