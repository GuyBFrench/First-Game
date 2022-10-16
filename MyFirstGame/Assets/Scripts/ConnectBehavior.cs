using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ConnectBehavior : MonoBehaviour
{
    public UnityEvent connectEvent;
    public ID idObj;
    public string debug;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            yield break;


        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            connectEvent.Invoke();
            Debug.Log(debug);
        }
        else
        {
            Debug.Log("No" + debug);
        }
    }
}