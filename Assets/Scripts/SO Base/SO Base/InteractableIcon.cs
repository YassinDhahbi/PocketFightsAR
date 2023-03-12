using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Icon", menuName = "Interactive Icon")]
public class InteractableIcon : ScriptableObject
{
    public Sprite iconSprite;

    public GameEvent functionality;
}