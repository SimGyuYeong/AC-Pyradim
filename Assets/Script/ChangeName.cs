using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    [SerializeField] private Fungus.Character Name;
    [SerializeField] private InputField input;

    public void NameChange()
    {
        Name.nameText = input.text;
    }
}
