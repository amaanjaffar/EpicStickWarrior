using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeptheVibesGoing : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        
    }
}
