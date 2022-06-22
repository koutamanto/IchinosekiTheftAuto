using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MoneyManager : MonoBehaviour
{
	[SerializeField]
	UnityEngine.UI.Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
    	moneyText.text = "0$";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
