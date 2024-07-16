using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Debug Mapping
/// </summary>
public static class DE
{

    
    public static void Log(string log_)
    {
#if UNITY_EDITOR
        Debug.Log($"{log_}");
#endif        
    }

    public static void LogWarning(string log_)
    {
#if UNITY_EDITOR
        Debug.LogWarning($"{log_}");
#endif
    }

    public static void LogError(string log_)
    {
#if UNITY_EDITOR
        Debug.LogError($"{log_}");
#endif
    }

    public static void Break()
    {
#if UNITY_EDITOR
        Debug.Break();
#endif
    }

}   // ClassEnd


