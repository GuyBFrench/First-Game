using UnityEngine;

public class TransformBehavior : MonoBehaviour
{
    public Vector3Data v3Data;
    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }

    public void SetV3Value()
    {
        v3Data.value = transform.position;
    }

    private void Update()
    {
        SetV3Value();
    }
}
