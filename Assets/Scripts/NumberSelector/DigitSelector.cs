using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DigitSelector : MonoBehaviour
{
    int value = 0;

	[SerializeField] Image DigitSymbol;

    [SerializeField] List<Sprite> symbol;

	private void Start()
	{
		UpdateUI();
    }


	public int GetValue()
	{
		return value;
	}

    public string GetHexValue()
    {
		string hexValue = value.ToString();

		switch (value)
		{
			case 10:
				hexValue = "A";
				break;
			case 11:
				hexValue = "B";
				break;
			case 12:
				hexValue = "C";
				break;
			case 13:
				hexValue = "D";
				break;
			case 14:
				hexValue = "E";
				break;
			case 15:
				hexValue = "F";
				break;
		}

        return hexValue;
    }

    public void SetValue(int value)
	{
		this.value = value;
		UpdateUI();
	}

	public void SetValue(char character)
	{
		int.TryParse(character.ToString(), out value);
		UpdateUI();
	}

	public void SetValue(string character)
	{
		int.TryParse(character, out value);
		UpdateUI();
	}

	private void UpdateUI()
	{
        DigitSymbol.sprite = symbol[value];
	}

	public void UpButtonClick()
	{
		IncrementValue();
	}

	public void DownButtonClick()
	{
		DecrementValue();
		
	}

	void IncrementValue()
	{
		value++;
		if (value > 15)
		{
			value = 0;
		}
		UpdateUI();
	}

	void DecrementValue()
	{
		value--;
		if (value < 0)
		{
			value = 15;
		}
		UpdateUI();
	}
}
