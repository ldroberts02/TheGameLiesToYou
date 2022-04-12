using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class setCursor : MonoBehaviour
{

    public Timer timer;
    public List<CursorSprites> cursorSprites;
    public int index = 0;
    public string cursorName;


    void Start()
    {
        timer.AutoRestart = true;
        timer.StartTimer(0.16f,true);
        // SetCursor
        UpdateCursor();


    }

    public void UpdateCursor()
    {
        //cs is local variable for update cursor using cursorsprites
        CursorSprites cs = new CursorSprites();

        for (int i = 0; i < cursorSprites.Count; i++)
            if (cursorSprites[i].CursorName == cursorName)
                cs = cursorSprites[i];

        index++;

        if (index >= cs.Sprites.Count)
            index = 0;
        Cursor.SetCursor(cs.Sprites[index], Vector2.zero, CursorMode.Auto);
    }

}