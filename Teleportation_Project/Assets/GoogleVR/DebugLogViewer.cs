using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogViewer: MonoBehaviour {
    public void DebugMessage(string s)
    {
        Debug.Log(s);
    }
}
