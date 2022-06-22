using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField]
    GameObject NPC;
    bool is_alive = true;
    [SerializeField]
    AudioSource audioData;
    // [SerializeField]
    // GameObject blood;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionStay(Collision other)
    {
    	if(other.gameObject.tag == "Car" && is_alive)
    	{
    		is_alive = false;
    		Animator animator = NPC.GetComponent<Animator>();
    		animator.runtimeAnimatorController = null;
	        Vector3 worldAngles = NPC.transform.eulerAngles;
	        Vector3 NPCPos = NPC.transform.position;
	        worldAngles.x += -90f;
	        NPCPos.y = 70;
    		NPC.transform.eulerAngles = worldAngles;
    		NPC.transform.position = NPCPos;
    	}
        else if(other.gameObject.tag == "Bullet" && is_alive)
        {
            is_alive = false;
            // blood.SetActive(true);
            // audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Animator animator = NPC.GetComponent<Animator>();
            animator.runtimeAnimatorController = null;
            Vector3 worldAngles = NPC.transform.eulerAngles;
            Vector3 NPCPos = NPC.transform.position;
            worldAngles.x += -90f;
            NPCPos.y = 70;
            NPC.transform.eulerAngles = worldAngles;
            NPC.transform.position = NPCPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
    	if(is_alive)
    	{
	        Transform NPCTransform = NPC.transform;
	        Vector3 pos = NPCTransform.position;
	        pos.x += 0.02f;
	        NPCTransform.position = pos;
    	}
    }
}
