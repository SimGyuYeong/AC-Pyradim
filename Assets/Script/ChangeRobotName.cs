using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRobotName : MonoBehaviour
{
    [SerializeField] private Fungus.Character Name;
    [SerializeField] private Fungus.Character PlayerName;

    public void NameChange()
    {
        ChangeName changeName = FindObjectOfType<ChangeName>();

        Name.nameText = "Ä«¸£¸¸";
        Destroy(gameObject);
        PlayerName.nameText = changeName.PlayerName;
    }
}
