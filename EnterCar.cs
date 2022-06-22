using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using TMPro;
using Mirror;

public class EnterCar : MonoBehaviour
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
    TextMeshProUGUI CarName;
    [SerializeField]
    int TriggerCheck;
    // Start is called before the first frame update
    void Start()
    {
        // try
        // {
        //     ThePlayer = GameObject.Find("FPSController 2(Clone)");
        // }
        // catch (NullReferenceException n2)
        // {
        //     ThePlayer = GameObject.Find("FPSController 2 [connId=0]");
        // }

        // ExitTrigger = transform.parent.gameObject.transform.Find("ExitTrigger").gameObject;
    // }
    // [Command]
    // void CmdAwake()
    // {
    //     ThePlayer = GameObject.Find("FPSController 2(Clone)");
    //     ExitTrigger = transform.parent.gameObject.transform.Find("ExitTrigger").gameObject; 
    // }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            TriggerCheck = 1;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            TriggerCheck = 0;
        }
    }
    void Update()
    {
        if(TriggerCheck == 1)
        {
            if(Input.GetButtonDown("Action"))
            {
                // try
                // {
                //     ThePlayer = GameObject.Find("FPSController 2(Clone)").gameObject;
                //     if(ThePlayer.tag == "Player")
                //     {
                //         ThePlayer.SetActive(false);
                //         ThePlayer.transform.parent = TheCar.transform;
                //     }
                // }
                // catch (NullReferenceException n)
                // {
                //     ThePlayer = GameObject.Find("FPSController 2 [connId=0]").gameObject;
                //     if(ThePlayer.tag == "Player")
                //     {
                //         ThePlayer.SetActive(false);
                //         ThePlayer.transform.parent = TheCar.transform;
                //     }
                // }
                ThePlayer.SetActive(false);
                ThePlayer.transform.parent = TheCar.transform;
                // CmdDisablePlayer();
                // try
                // {
                //     ThePlayer = GameObject.FindGameObjectsWithTag("Player")[0];
                //     ThePlayer.SetActive(false);
                //     ThePlayer.transform.parent = TheCar.transform;
                // }
                // catch (NullReferenceException n)
                // {
                //     ThePlayer = GameObject.Find("FPSController 2 [connId=0]");
                //     ThePlayer.SetActive(false);
                //     ThePlayer.transform.parent = TheCar.transform;
                // }
                // ThePlayer.SetActive(false);
                // ThePlayer.transform.parent = TheCar.transform;
                //     // ThePlayer = GameObject.Find("FPSController 2 [connId=0]").gameObject;
                // }
                // catch (NullReferenceException e)
                // {
                //     try 
                //     {
                //         ThePlayer = GameObject.Find("FPSController 2 [connId=0]").gameObject;
                //         ThePlayer.SetActive(false);
                //         ThePlayer.transform.parent = TheCar.transform;                    }
                //     catch (NullReferenceException n)
                //     {
                //         ThePlayer = GameObject.Find("FPSController 2(Clone)").gameObject;
                //         ThePlayer.SetActive(false);
                //         ThePlayer.transform.parent = TheCar.transform;
                //     }
                // }
                CarCam.SetActive(true);
                // ThePlayer.SetActive(false);
                // ThePlayer.transform.parent = TheCar.transform;
                TheCar.GetComponent<CarController>().enabled = true;
                TheCar.GetComponent<CarUserControl>().enabled = true;
                CarName.text = TheCar.name;
                // ExitTrigger = .Find("ExitTrigger").gameObject;
                ExitTrigger.SetActive(true);
            }
        }
    }
}
    // [Command]
    // void CmdDisablePlayer()
    // {
    //     GameObject[] otherPlayers = GameObject.FindGameObjectsWithTag("OtherPlayer");
    //     for(int i=0;i<otherPlayers.Length;i++)
    //     {
    //         GameObject otherPlayer = otherPlayers[i];
    //         if(otherPlayer.transform.parent.gameObject == transform.parent.gameObject)
    //         {
    //             ThePlayer = otherPlayer;
    //             break;
    //         }
    //     }
    //     ThePlayer = transform.parent.transform.gameObject;
    //     ThePlayer.SetActive(false);
    //     ThePlayer.transform.parent = TheCar.transform;
    // }
