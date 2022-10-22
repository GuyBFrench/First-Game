using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{

    
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    public ID idObj;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            yield break;


        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
