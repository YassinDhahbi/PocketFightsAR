using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TagScript : MonoBehaviour
{
    public Tag tagValue;
}

public enum Tag
{
    Player, Enemy, Projectile
}