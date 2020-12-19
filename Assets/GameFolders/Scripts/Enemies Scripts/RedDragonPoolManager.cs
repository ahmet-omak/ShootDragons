using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controllers;
using UnityEngine;

public class RedDragonPoolManager : GenericPoolManager<RedDragonManager>
{
    public static RedDragonPoolManager Instance { get; private set; }
    protected override void SingletonThisObject()
    {
        if (Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);  
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
