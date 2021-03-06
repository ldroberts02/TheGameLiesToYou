/*MascotActions.cs
This script sets variables and actions that will set the rendering process for the Mascot Character's sprite/texture set
Variable list
    MascotMood - An integer that will slide up and down depending on performance in questions
    MascotAngry - A boolean that is a simple "is mascot angry?" question, wil be used in checks
    MascotHappy  - Similar to the last one, but with a happy value
    MascotImage - TBA
    MascotSprite - TBA, i need to write what this and MascotImage do in detail and what it means to call it, before i forget, same with MascotImage

*/      



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;






public class MascotActions : MonoBehaviour
{

    public int MascotMood = 8;
    //default mood should be around 8, could always change based on how the algorithm works
    public bool MascotAngry = false;
	public bool MascotHappy = true;
    public bool MascotShock = false;
	public Image MascotImage;
	public Sprite MascotSprite;
	//change to maybe a list for the texture 2d and make the naming less confusing
    public List<MascotTexture> MascotList;
    
    public MultipleChoiceQuestions multipleChoiceQuestions;

    public TMP_Text debugText;
    public int debugMood;





    // Start is called before the first frame update
    void Start()
    {
		MascotImage.sprite = MascotSprite;
		Debug.Log(MascotSprite);
		
        debugText.SetText(debugMood.ToString()); //sets the text for the debug text number, to what the integer is.
        
		if (MascotHappy && (MascotMood == 8)) //if mascothappy is true, and mascotmood is equal to 8, then do below this
		{
			//set sprite to happy
           // MascotList["Happy"]

			//check for this, and see how to change the material, maybe use "Material.SetTexture"


		}
		
    }

public int getMascotIndex(string n) //n is local variable to call
{
    for(int i = 0; i < MascotList.Count; i++)
    {
        if (MascotList[i].namecode == n)
        return i;
    }
    return 0;
}    

public void correctMascot()
{
    //Debug.Log("updateMascot Called");
    //MascotImage.sprite = MascotList[getMascotIndex("Sad")].spritefunction; //use this to call function based on mascotlist
    if((MascotMood > 4) && (MascotHappy == true))
    {
        MascotImage.sprite = MascotList[getMascotIndex("Happy")].spritefunction;
        //Debug.Log("CHANGED SPRITE TO HAPPY");


    }
    if((MascotMood > 4) && (MascotHappy == false))
    {
        MascotImage.sprite = MascotList[getMascotIndex("Default")].spritefunction;
        //Debug.Log("CHANGED SPRITE TO DEFAULT");

        
    }

    if(MascotAngry == true)
    {
        MascotAngry = false;
        MascotImage.sprite = MascotList[getMascotIndex("Unimpressed")].spritefunction;
    }


    if(MascotMood < 8)
    {
        MascotMood += 1;
        debugMood += 1;
        debugText.SetText(debugMood.ToString()); //sets the text for the debug text number, to what the integer is.
    }



}

public void wrongMascot()
{
    MascotMood -= 1;
    debugMood -= 1;
    //Debug.Log("WRONG UPDATED");
    debugText.SetText(debugMood.ToString());
    
    if(MascotShock == false )
    {
        MascotImage.sprite = MascotList[getMascotIndex("Unhappy Shock")].spritefunction;

    }

    if(MascotHappy == true)
    {
        MascotImage.sprite = MascotList[getMascotIndex("Default")].spritefunction;
    }

    if(MascotShock == true)
    {
        MascotImage.sprite = MascotList[getMascotIndex("Mischievous")].spritefunction;
    }


    MascotHappy = false;
    
    
}




void Update()
{
   // MascotMood = debugMood;
}


}

[System.Serializable]
public class MascotTexture //using this class, the code will call for a sprite change for the mascot entity, using this, it will assign sprites to strings, so you could call the string "happy" and it will give a happy sprite.
{
    public string namecode;
    public Sprite spritefunction; //change later




}

