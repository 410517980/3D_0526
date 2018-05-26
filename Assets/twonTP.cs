using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twonTP : MonoBehaviour {

    // Use this for initialization
	void Start () {

        float x = PlayerPrefs.GetFloat("playertownX");
        float y = PlayerPrefs.GetFloat("playertownY");
        float z = PlayerPrefs.GetFloat("playertwonZ");
        player.transform.position = new Vector3(x, y, z);
    }
    public GameObject player;
    public GameObject door;
    // Update is called once per frame
    void Update () {
        float tmp = Vector3.Distance(player.transform.position, door.transform.position);
        
        if (tmp < 10) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerPrefs.SetFloat("playertownX", player.transform.position.x);
                PlayerPrefs.SetFloat("playertwonY", player.transform.position.y);
                PlayerPrefs.SetFloat("playertwonZ", player.transform.position.z);
                Application.LoadLevel("hospital");

            }
        }
	}
}
