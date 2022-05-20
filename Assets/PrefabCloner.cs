using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabCloner : MonoBehaviour
{
	public GameObject prefab;

	public Text inputCloneAmount;
	public int counter = 0;

	public Text displayClonesLeft;

	public InputField IField;

    // Start is called before the first frame update
    void Start()
    {
		displayClonesLeft.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ClonePrefab()
	{
		if (inputCloneAmount.text != "")
		{
			IField.readOnly = true;

			int cloneAmount = int.Parse(inputCloneAmount.text);
			if (counter < cloneAmount)
			{
			Instantiate(prefab);
			counter++;
			displayClonesLeft.text = (cloneAmount - counter).ToString();
			}
			else
			{
				displayClonesLeft.text = "No hay más";
			}
		}
		else
		{
			displayClonesLeft.text = "ERROR. Ingrese un valor";
		}
		
		
	}
}
