using UnityEngine;

[CreateAssetMenu]
public class FloatData1 : ScriptableObject
{
    public float value;

    public void SetValue(float num)
    {
        value = num;
    }
    
    public void UpdateValue(float num)
    {
        value += num;
    }
}