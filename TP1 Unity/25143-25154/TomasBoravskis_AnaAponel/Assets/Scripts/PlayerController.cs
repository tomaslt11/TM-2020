using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	 GameObject ball;
     GameObject plane;
	public float speed;
	public Text countText;
	public Text winText;
	public Text winText2;
	private Rigidbody rb;
	private int count;
	private Vector3 resetPosition;
	float yBall;
	   float yPlane;
    Vector3 resetPos;
	private AudioSource myAudio;

	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
		resetPosition = new Vector3 (26.09f, 2.0f, -6.25f);
		myAudio = GetComponent<AudioSource>();
	}
	
    void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
	
		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
		rb.AddForce (movement * speed);
		
		if (transform.position.y <=-10)
		{
			ResetPlayer();
		}
		
	}

	
 void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
			myAudio.Play();
            other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
			if(count>=16)
			{
				winText.text = "You Won.";
			
			}
        }
    }

	
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString() + " / 16";

	}
	
	void ResetPlayer()
	{
		transform.position = resetPosition;
		GetComponent<Rigidbody> ().velocity = new Vector3 (0.0f, 0.0f, 0.0f);
	}
	void elevatorCheckpoint()
	{
		resetPosition = new Vector3 (25.842f,7.2112f,64.373f);
	}
	
	void elevatorCheckpoint2()
	{
		resetPosition = new Vector3 (30.93208f,12.830689f,24.41f);
	}
}

