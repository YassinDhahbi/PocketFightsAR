using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputReferenceHolder", menuName = "Data Holder/InputReferenceHolder")]
public class InputHolder : ScriptableObject
{
    public List<InputDataHolder> listOfInputActionReferences;
}


[System.Serializable]
public class InputDataHolder
{
    public string name;
    public InputActionReference actionReference;
}
