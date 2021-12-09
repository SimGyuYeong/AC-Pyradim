using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRobotName : MonoBehaviour
{
    [SerializeField] private Fungus.Character Name;
    [SerializeField] private Fungus.Character PlayerName;

    [SerializeField] private Fungus.Flowchart chart;

    public void NameChange()
    {
        var name = chart.Variables[3];

        Name.nameText = "ī����";
        Destroy(gameObject);
        PlayerName.nameText = name.ToString();
    }
}
