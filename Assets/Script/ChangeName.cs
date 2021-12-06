using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    [SerializeField] private Fungus.Character Name;
    [SerializeField] private InputField input;

    public string PlayerName;

    public void NameChange()
    {
        PlayerName = input.text;
        Name.nameText = input.text;
    }
}
