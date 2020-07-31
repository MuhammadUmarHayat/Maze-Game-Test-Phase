using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishHandler : MonoBehaviour {

	void OnCollisionEnter(Collision collisionInfo)
	{
		//print ("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
		//print ("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
		//print ("Their relative velocity is " + collisionInfo.relativeVelocity);
		print ("Winner " );
	}




	void OnCollisionStay(Collision collisionInfo)
	{
		print ("Winner " );



	}

	void OnCollisionExit(Collision collisionInfo)
	{
		print ("Winner " );
	}

	void OnTriggerEnter(Collider other)
	{
		print ("Winner " );
	}

	void OnTriggerStay(Collider other)
	{
		print ("Winner " );
	}

	void OnTriggerExit(Collider other)
	{
		print ("Winner ");
	}


}
