using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMover : MonoBehaviour
{
	public GameObject elevator;
	private bool elevatorMoving = false;
	public GameObject player;
	
	void FixedUpdate()
	{
	  if (elevatorMoving == true)
	  {
		if(elevator.transform.position.y <=-1.89f)
		{
			elevator.transform.position = new Vector3(elevator.transform.position.x, elevator.transform.position.y + 0.1f, elevator.transform.position.z);
		}
	  }
	}
	  
	  void OnCollisionEnter(Collision col)
	  {
		  if(col.collider.gameObject.tag == "Player")
		  {
			  elevatorMoving = true;
			  
		  }
	  }
	  void OnCollisionExit(Collision col)
	  {
		  if(col.collider.gameObject.tag=="Player")
		  {
			  player.SendMessage("elevatorCheckpoint");
		  }
	  }
	  
	}
	
