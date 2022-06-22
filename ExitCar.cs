using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using static EnterCar;
using TMPro;
// using Mirror;

public class ExitCar : MonoBehaviour
{
    [SerializeField]
    GameObject CarCam;
    [SerializeField]
    GameObject ThePlayer;
    [SerializeField]
    GameObject ExitTrigger;
    [SerializeField]
    GameObject TheCar;
    [SerializeField]
    GameObject ExitPlace;
    [SerializeField]
    TextMeshProUGUI CarName;
    bool is_taken = false;
    //int TriggerCheck;
    // Start is called before the first frame update
    void Start()
    {
        // try
        // {
        //     ThePlayer = GameObject.Find("FPSController 2 [connId=0]");
        // }
        // catch (NullReferenceException n)
        // {
        //     ThePlayer = GameObject.Find("FPSController 2(Clone)");
        // }
        // ExitTrigger = transform.parent.gameObject.transform.Find("ExitTrigger").gameObject;
        // CmdAwake();
        // try
        // {
        //     ThePlayer = GameObject.Find("FPSController 2 [connId=0]").gameObject;
        // }
        // catch (NullReferenceException e)
        // {
        //     ThePlayer = GameObject.Find("FPSController 2(Clone)").gameObject;
        // }
    }

    // [Command]
    // void CmdAwake()
    // {
    //     ThePlayer = GameObject.Find("FPSController 2(Clone)").gameObject;
    //     ExitTrigger = transform.Find("ExitTrigger").gameObject;
    // }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
            // if(!is_taken)
            // {
            //     ThePlayer = GameObject.Find("FPSController 2 [connId=0]").gameObject;
            //     is_taken = true;
            // }
                // try
                // {
                //     ThePlayer.SetActive(true);
                //     ThePlayer.transform.parent = null;
                // }
                // catch (NullReferenceException n)
                // {
                // try
                // {
                //     // ThePlayer = transform.parent.gameObject.transform.Find("FPSController 2(Clone)").gameObject;
                //     try
                //     {
                //         ThePlayer = transform.parent.gameObject.transform.Find("FPSController 2(Clone)").gameObject;
                //         if(ThePlayer.tag == "Player")
                //         {
                //             ThePlayer.SetActive(true);
                //             ThePlayer.transform.parent = null;                        
                //         }
                //     }
                //     catch (NullReferenceException n)
                //     {
                //         ThePlayer = transform.parent.gameObject.transform.Find("FPSController 2 [connId=0]").gameObject;
                //         if(ThePlayer.tag == "Player")
                //         {
                //             ThePlayer.SetActive(true);
                //             ThePlayer.transform.parent = null;                        
                //         }
                //     }

                // }
                // catch (NullReferenceException n2)
                // {
                //     try
                //     {
                //         ThePlayer = GameObject.Find("FPSController 2(Clone)");
                //         if(ThePlayer.tag == "Player")
                //         {
                //             ThePlayer.SetActive(true);
                //             ThePlayer.transform.parent = null;         
                //         }
                //     }
                //     catch (NullReferenceException n3)
                //     {
                //         ThePlayer = GameObject.Find("FPSController 2 [connId=0]");
                //         if(ThePlayer.tag == "Player")
                //         {
                //             ThePlayer.SetActive(true);
                //             ThePlayer.transform.parent = null;         
                //         }
                //     }
                // }
            // ThePlayer = transform.Find("FPSController 2(Clone)").gameObject;
            // ThePlayer.SetActive(true);
            // ThePlayer.transform.parent = null;

            // try
            // {
            //     ThePlayer.SetActive(true);
            //     ThePlayer.transform.parent = null;
            //     // ThePlayer = GameObject.Find("FPSController 2 [connId=0]").gameObject;
            // }
            // catch (NullReferenceException e)
            // {
            //     try 
            //     {
            //         ThePlayer = TheCar.transform.Find("FPSController 2 [connId=0]").gameObject;
            //         ThePlayer.SetActive(true);
            //         ThePlayer.transform.parent = null;
            //     }
            //     catch (NullReferenceException n)
            //     {
            //         ThePlayer = TheCar.transform.Find("FPSController 2(Clone)").gameObject;
            //         ThePlayer.SetActive(true);
            //         ThePlayer.transform.parent = null;
            //     }
            // }
            // ThePlayer.transform.position = TheCar.transform.position;
            ThePlayer.SetActive(true);
            ThePlayer.transform.parent = null; 
            CarCam.SetActive(false);
            TheCar.GetComponent<CarUserControl>().enabled = false;
            TheCar.GetComponent<CarController>().enabled = false;
            // CarName.text = "";
            // try
            // {
            ExitTrigger.SetActive(false);
            // }
            // catch (NullReferenceException n)
            // {
            //     ExitTrigger = transform.Find("ExitTrigger").gameObject;
            //     ExitTrigger.SetActive(false);
            // }
            // CmdExitCar();
        }
    }
    // [Command]
    // void CmdExitCar()
    // {
    //     try
    //     {
    //         ThePlayer.SetActive(true);
    //         ThePlayer.transform.parent = null;
    //     }
    //     catch (NullReferenceException n)
    //     {
    //         try
    //         {
    //             ThePlayer = GameObject.Find("FPSController 2 [connId=0]").gameObject;
    //             ThePlayer.SetActive(true);
    //             ThePlayer.transform.parent = null;
    //         }
    //         catch (NullReferenceException n2)
    //         {
    //             ThePlayer = GameObject.Find("FPSController 2(Clone)").gameObject;
    //             ThePlayer.SetActive(true);
    //             ThePlayer.transform.parent = null;
    //         }
    //     }

    //     GameObject ExitTrigger = GameObject.Find("ExitTrigger").gameObject;
    //     ExitTrigger.SetActive(false);

    // }
}
