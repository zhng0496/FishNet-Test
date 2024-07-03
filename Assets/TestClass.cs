using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestClass : MonoBehaviour
{
    [SerializeField] public List<TestEvent> testEvents;

    [Serializable]
    public struct TestEvent
    {
        public string Name;
        public UnityEvent Event; 
    }
}
