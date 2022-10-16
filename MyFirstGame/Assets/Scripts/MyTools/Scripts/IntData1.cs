using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData1 : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(IntData1 obj)
    {
        if (value >= obj.value)
        {
            
        }
        else
        {
            value = obj.value;
        }
    }
    
    public void SetValue(IntData1 obj)
    {
        value = obj.value;
    }
    
    public void UpdateValue(int num)
    {
        value += num;
    }
    
}