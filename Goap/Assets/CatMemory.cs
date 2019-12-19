using System.Collections;
using System.Collections.Generic;
using ReGoap.Unity;
using UnityEngine;

public class CatMemory : ReGoapMemory<string,object>
{
    protected override void Awake()
    {
        base.Awake();
        
        GetWorldState().Set("hungry",true);
        GetWorldState().Set("fullBowl",false);
        GetWorldState().Set("atHuman",false);
        
        
    }
}
