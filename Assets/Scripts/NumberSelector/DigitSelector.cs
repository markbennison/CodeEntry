using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DigitSelector : MonoBehaviour
{
    int value = 0;

	[SerializeField] TextMeshProUGUI DigitText;

	Dictionary<int, string> symbols = new Dictionary<int, string>();

	private void Start()
	{
		UpdateUI();

		symbols.Add(0, "∆");
        symbols.Add(1, "Ꝣ");
        symbols.Add(2, "Ꚗ");
        symbols.Add(3, "დ");
        symbols.Add(4, "Ꝟ");
        symbols.Add(5, "ℓ");
        symbols.Add(6, "ֆ");
        symbols.Add(7, "Ზ");
        symbols.Add(8, "₪");
        symbols.Add(9, "֏");
        symbols.Add(10, "Ꝝ");
        symbols.Add(11, "ꞗ");
        symbols.Add(12, "ל");
        symbols.Add(13, "Ⴟ");
        symbols.Add(14, "Ლ");
        symbols.Add(15, "Ꚛ");

    }


	public int GetValue()
	{
		return value;
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
		string t;
		symbols.TryGetValue(value, out t);

        DigitText.text = t;
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
