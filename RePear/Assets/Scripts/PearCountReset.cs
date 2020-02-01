using System;

namespace DefaultNamespace
{
    public class PearCountReset : UnityEngine.MonoBehaviour
    {
        public IntVariable pearCounter;

        public void Awake()
        {
            pearCounter.SetValue(0);
        }
    }
}