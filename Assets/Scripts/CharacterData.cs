using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "CharacterCreation/CharacterData")]
public class CharacterData : ScriptableObject
{
    public CharacterClass characterClass;
    public int indexInList;

    [Range(100f, 200f)]
    public float hp;

    [Range(50f, 70f)]
    public float speed;

    [Range(5f, 10f)]
    public float cooldown;

    public Vector3 characterOffset;

    public List<InteractableIcon> buttons;
}

public enum CharacterClass
{
    Warrior,
    Monk,
    Mage
}

public enum ButtonInteraction
{
    Attack,
    Block,
    Skill,
    Potion
}