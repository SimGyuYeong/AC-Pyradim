using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharaterName : MonoBehaviour
{
    [SerializeField] private Fungus.Character Name;
    [SerializeField] private Fungus.Character PlayerName;

    [SerializeField] private Fungus.Flowchart chart;

    public void NameChange()
    {
        var name = chart.Variables[2];
        Name.nameText = "Ä«¸£¸¸";
        PlayerName.nameText = name.ToString();
    }

    public void afterNameChange()
    {
        var name = chart.Variables[2];
        PlayerName.nameText = name.ToString();
    }
}
