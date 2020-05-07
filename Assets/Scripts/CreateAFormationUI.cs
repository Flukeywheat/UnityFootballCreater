using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.XR;

public class CreateAFormationUI : MonoBehaviour
{
    [SerializeField] private Text InputField;
    [SerializeField] private TMP_Text PlaybookName;
    [SerializeField] private GameObject previousUI, NextUI;
    [SerializeField] private GameObject PlaybookNameValidationLbl;
    private bool Off_Def;
    public void UpdateNewPlaybookName()
    {
        if ( InputField.text != string.Empty)
        {
            if ( InputField.text.Length < 10)
            {
                ValidEntryUpdateUI();
            }
            else
            {
                PlaybookNameValidationLbl.SetActive(true);
                TMP_Text validationText = PlaybookNameValidationLbl.GetComponent<TMP_Text>();
                validationText.text = "Name Can only take up 10 spaces...";
            }          
        }
        else
        {
            PlaybookNameValidationLbl.SetActive(true);
            TMP_Text validationText = PlaybookNameValidationLbl.GetComponent<TMP_Text>();
            validationText.text = "Please enter a Playbook name...";
        }
    }

    private void ValidEntryUpdateUI()
    {
        PlaybookName.text = InputField.text;
        previousUI.SetActive(false);
        NextUI.SetActive(true);
        PlaybookNameValidationLbl.SetActive(false);
    }
}
