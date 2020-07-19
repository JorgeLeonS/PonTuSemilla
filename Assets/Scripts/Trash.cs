using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
	private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

	if (other.gameObject.tag == "InorganicTrashcan" && gameObject.tag == "InorganicTrash") {
            Destroy(gameObject);
	if(!entered)
		TrashController.trashCounter -= 1;
	entered = true;
        }
        if (other.gameObject.tag == "OrganicTrashcan" && gameObject.tag == "OrganicTrash")
        {
            Destroy(gameObject);
	if(!entered)
		TrashController.trashCounter -= 1;
	entered = true;
        }
    }
}



