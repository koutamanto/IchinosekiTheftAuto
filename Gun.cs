using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	[SerializeField]
	GameObject FireEffect;
	[SerializeField]
	double CoolTimeForFire = 1.0;
	double time_before;
	// [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        time_before = Time.time;
    }
    void Fire()
    {
        if(Input.GetButton("Fire1"))
        {
        	FireEffect.SetActive (true);
        }
    }
    // Update is called once per frame
    void Update()
    {
    	if((Time.time - time_before) > CoolTimeForFire){
    		Fire();
    	}
    }
    void DeFire()
    {
    	FireEffect.SetActive (false);
    }
}
