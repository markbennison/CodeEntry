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
    [SerializeField] Dictionary<int, Sprite> symbols;

	private void Start()
	{
		UpdateUI();
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
        Sprite t;
		symbols.TryGetValue(value, out t);

        DigitSymbol.sprite = t;
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
