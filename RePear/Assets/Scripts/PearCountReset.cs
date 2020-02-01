using System;

namespace DefaultNamespace
{
    public class PearCountReset : UnityEngine.MonoBehaviour
    {
        public IntVariable pearCounter, pearAdder, sacrifices, sacrificeEventNumber, totalEventNumber;

        public void Awake()
        {
            pearCounter.SetValue(0);
            pearAdder.SetValue(0);
            sacrifices.SetValue(0);
            sacrificeEventNumber.SetValue(0);
            totalEventNumber.SetValue(0);
        }
    }
}