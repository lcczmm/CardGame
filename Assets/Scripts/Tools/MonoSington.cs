using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSington <T>: MonoBehaviour where T:MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get {
            if (instance == null)
            {
                
            }
            return instance;
        }
    }

}
