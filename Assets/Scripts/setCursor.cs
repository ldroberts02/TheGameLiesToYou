using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCursor : MonoBehaviour
{
    // You must set the cursor in the inspector.
    public List<Texture2D> crosshair;
    public int index = 0;

    void Start()
    {

        //set the cursor origin to its centre. (default is upper left corner)
        Vector2 cursorOffset = new Vector2(crosshair[0].width / 6, crosshair[0].height / 6);

        //Sets the cursor to the Crosshair sprite with given offset 
        //and automatic switching to hardware default if necessary
        Cursor.SetCursor(crosshair[0], cursorOffset, CursorMode.Auto);  
    }
 
    public void updateCursor()
    {
        index++;
        if (index >= crosshair.Count)
            index = 0;

        //set the new cursor
        Vector2 cursorOffset = new Vector2(crosshair[index].width / 6, crosshair[index].height / 6);

        //Sets the cursor to the Crosshair sprite with given offset 
        //and automatic switching to hardware default if necessary
        Cursor.SetCursor(crosshair[index], cursorOffset, CursorMode.Auto);
    }



}