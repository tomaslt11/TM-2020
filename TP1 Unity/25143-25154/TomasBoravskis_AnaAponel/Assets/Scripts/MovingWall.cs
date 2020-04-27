using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
	public float speed = 3;
	public float startingX;
	public float targetX;
	
	void Update ()
	{
		transform.position = new Vector3(Mathf.PingPong(Time.time * speed,targetX) + startingX, transform.position.y, transform.position.z);
		
	}
  
}
