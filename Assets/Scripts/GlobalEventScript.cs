using UnityEngine;
using System;

public static class GlobalEventScript
{
    public static event Action InitiateChange;

    public static void TriggerEvent()
    {
        InitiateChange?.Invoke();
    }
}
