using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodeChecker : MonoBehaviour
{
    [SerializeField]
    MultipleDigitSelector multipleDigitSelector;
    string PassCode = "6D1";

    public void ConfirmButtonClick()
    {
        if(multipleDigitSelector != null)
        {
            if(string.Compare(multipleDigitSelector.GetHexValue(),PassCode) == 0)
            {
                Debug.Log("CORRECT CODE");
                SceneManager.LoadScene("DoorOpen");
            }
            else
            {
                Debug.Log("INCORRECT CODE ("+ multipleDigitSelector.GetHexValue() +" != " + PassCode + ")");
            }
        }
    }
}
