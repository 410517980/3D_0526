using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hospitalTP : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public GameObject player;
    public GameObject door;
    // Update is called once per frame
    void Update()
    {
        float tmp = Vector3.Distance(player.transform.position, door.transform.position);

        if (tmp < 10)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.LoadLevel("town");

            }
        }
    }
}
