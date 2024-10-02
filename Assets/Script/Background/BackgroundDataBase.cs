using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class BackgroundDataBase : ScriptableObject
{
    public BackgroundSelection[] background;
    public int BackgroundCount
    {
        get
        {
            return background.Length;
        }
    }
    public BackgroundSelection GetBackground(int index)
    {
        return background[index];
    }
}
