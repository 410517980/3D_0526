using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class talk : MonoBehaviour {
    public static Flowchart flowchartManager;
    public Flowchart talkFlowchart;
    public string onCollosionEnter;
    Rigidbody playerRigigbody;
	void Awake () {
        flowchartManager = GameObject.Find("talkcontroller").GetComponent<Flowchart>();
        playerRigigbody = FindObjectOfType<UnityChanControlScriptWithRgidBody>().GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static bool isTalking {
        get { return flowchartManager.GetBooleanVariable("ing"); }
    }
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            playerRigigbody.Sleep();
            Block targetBlock = talkFlowchart.FindBlock(onCollosionEnter);
            talkFlowchart.ExecuteBlock(targetBlock);
        }
    }
}
