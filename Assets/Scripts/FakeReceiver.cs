using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeReceiver : MonoBehaviour
{
    
    public void PlayerDied()
    {
        Debug.Log("Player has died!");
    }

    public void PlayerGotHealth(int value)
    {
        Debug.Log("Player got health: " + value);
    }
}
