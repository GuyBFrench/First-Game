using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehavior
{
    public ColorIDDataList colorIDDataListObj, SetGreen;
    
    

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;
    }
}
