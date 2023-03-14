using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    [SerializeField]
    private InputManager manager;

    [SerializeField]
    private List<CharacterData> charactersData;

    [SerializeField]
    private GameObject characterContainer;

    [SerializeField]
    private List<GameObject> pooledCharacters;

    public int selectedCharacter;
}