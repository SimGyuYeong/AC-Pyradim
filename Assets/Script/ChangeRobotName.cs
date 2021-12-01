using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRobotName : MonoBehaviour
{
    [SerializeField] private Fungus.Character Name;

    public void NameChange()
    {
        Name.nameText = "Ä«¸£¸¸";
        Destroy(gameObject);
    }
}
