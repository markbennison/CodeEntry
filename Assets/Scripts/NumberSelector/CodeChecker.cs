using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodeChecker : MonoBehaviour
{
    [SerializeField]
    MultipleDigitSelector multipleDigitSelector;

    [SerializeField]
    GameObject lockoutText;

    string PassCode = "6D1";

    bool lockout = false;
    float lockoutTimer = 0;

    private void Start()
    {
        lockoutText.SetActive(false);
    }

    private void Update()
    {
        if(lockoutTimer > 0)
        {
            lockoutTimer -= Time.deltaTime;
            if (lockoutTimer <= 0)
            {
                lockoutTimer = 0;
                lockoutText.SetActive(false);
                Debug.Log("Active FALSE");
            }

            Debug.Log(lockoutTimer);
            SetTimerTextUI();
        }
    }

    public void ConfirmButtonClick()
    {
        if(multipleDigitSelector != null && lockoutTimer <= 0)
        {
            if(string.Compare(multipleDigitSelector.GetHexValue(),PassCode) == 0)
            {
                Debug.Log("CORRECT CODE");
                SceneManager.LoadScene("DoorOpen");
            }
            else
            {
                Debug.Log("INCORRECT CODE ("+ multipleDigitSelector.GetHexValue() +" != " + PassCode + ")");
                lockoutTimer = 20f;
                SetTimerTextUI();
                lockoutText.SetActive(true);
                Debug.Log("Active TRUE");
            }
        }
    }

    private void SetTimerTextUI()
    {
        lockoutText.GetComponent<TextMeshProUGUI>().text = "LOCKED OUT..." + Mathf.Floor(lockoutTimer).ToString();
    }


}
