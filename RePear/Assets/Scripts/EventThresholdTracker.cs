using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class EventThresholdTracker : MonoBehaviour
{
    [FormerlySerializedAs("sacrifices")] public IntVariable intValue;
    public IntVariable eventNumber;
    public List<GameEvent> events;
    public List<int> valueThresholds;


    public void CheckThreshold()
    {

        if (intValue.Value > valueThresholds[eventNumber.Value] && (events.Count-1) >= eventNumber.Value)
        {
            if (events[eventNumber.Value] != null)
            {
                events[eventNumber.Value].Raise();
                IncreaseEventNumber();

            }
            else
            {
                print("Sacrifices went out of range");
            }
        }
    }
    public void IncreaseEventNumber()
    {
        eventNumber.ApplyChange(+1);
    }
}
