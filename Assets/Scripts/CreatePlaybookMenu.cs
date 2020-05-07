using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlaybookMenu : MonoBehaviour
{
    [SerializeField] Text OffDefBtn;
    public bool off_def { get; private set; } = true;

    public void ToggleOffenseDefenseButton()
    {
        off_def = !off_def; 
        OffDefBtn.GetComponent<Text>().text = off_def ? "Offense" : "Defense";
    }



}
