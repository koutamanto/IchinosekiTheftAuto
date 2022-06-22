using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetworkCarManager : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
    	if(isServer)
    	{
    		RpcMove(transform);
    	}
    	else
    	{
    		CmdMove(transform);
    	}
    }
    [ClientRpc]
    void RpcMove(Transform tf)
    {
    	transform.position = tf.position;
    	transform.rotation = tf.rotation;
    }
    [Command]
    void CmdMove(Transform tf)
    {
    	transform.position = tf.position;
    	transform.rotation = tf.rotation;
    }
}
