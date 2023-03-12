using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconTrigger : MonoBehaviour
{
    [SerializeField]
    private InteractableIcon iconData;

    private void Awake()
    {
        GetComponent<Image>().sprite = iconData.iconSprite;
    }

    public void EventRaiser()
    {
        iconData.functionality.Raise();
    }
}