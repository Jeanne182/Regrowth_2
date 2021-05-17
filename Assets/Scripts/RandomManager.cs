using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomManager : MonoBehaviour
{
    public static RandomManager instance { get; private set; }
    
    public bool lifeMustPop = false;

    private void Awake()
    {
        if(instance != null){
          Debug.LogWarning("Il y a plus d'un PlayerMovement");
          return ;
        }
        instance = this;
    }
}
