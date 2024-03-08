using System.Collections;
using UnityEngine;

public class PLayerEventsRaiser : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO playerDied_EventChannel;
    [SerializeField] private IntEventChannelSO playerGotHealth_EventChannel;

    private void Start()
    {
        // A courutine that waits for a few seconds and then triggers the event
        StartCoroutine(WaitAndTrigger(2));
    }

    public void TriggerPlayerDied()
    {
        playerDied_EventChannel.RaiseEvent();
    }

    public void TriggerPlayerGotHealth(int value)
    {
        playerGotHealth_EventChannel.RaiseEvent(value);
    }

    private IEnumerator WaitAndTrigger(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        TriggerPlayerGotHealth(100);
    }
}