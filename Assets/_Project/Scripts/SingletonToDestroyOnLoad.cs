using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonToDestroyOnLoad : GenericSingleton<SingletonToDestroyOnLoad>
{

    protected override bool ShouldBeDestroyedOnLoad()
    {
        return true;
    }
}
