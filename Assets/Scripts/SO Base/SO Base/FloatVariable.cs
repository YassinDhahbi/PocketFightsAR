using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="FloatVariable")]
public class FloatVariable : ScriptableObject
{
    [SerializeField]
     float value;

    public float GetValue()
    {
        return value;
    }
    public void SetValue(float x)
    {
        value = x;
    }
}
