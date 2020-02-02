using System.Collections.Generic;
using UnityEngine;


    [UnityEngine.CreateAssetMenu(fileName = "ObjectList", menuName = "ObjectList", order = 0)]
    public class GameObjectList : UnityEngine.ScriptableObject
    {
        public List<GameObject> objects;
    }
