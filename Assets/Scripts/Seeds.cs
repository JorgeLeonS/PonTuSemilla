using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeds : MonoBehaviour
{


	public GameObject plant;
    private bool plantado = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Grass") {
			SequenceController.semillasAventadas = true;
			Vector3 localPos = gameObject.transform.position;
			Destroy(gameObject);
			Instantiate(plant, new Vector3(localPos.x, localPos.y, localPos.z), Quaternion.identity);
            Debug.Log("SP");
            if(!plantado)
                SeedsController.seedCounter -= 1;
            plantado = true;
		}
	}
}
