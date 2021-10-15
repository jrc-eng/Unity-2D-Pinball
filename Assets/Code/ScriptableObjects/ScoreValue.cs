using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score/ScoreValue")]
public class ScoreValue : ScriptableObject
{
    [SerializeField] private long value = 100L;


    public long GetValue()
    {
        return value;
    }

}
