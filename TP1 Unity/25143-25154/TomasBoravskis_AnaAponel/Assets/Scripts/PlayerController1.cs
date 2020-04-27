using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController1 : MonoBehaviour
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
	private AudioSource myAudio;
	float yBall;
	   float yPlane;
    Vector3 resetPos;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
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
			resetPosition = new Vector3 (-6.25f,1.314f,-6.35f);
			ResetPlayer();
		}
		
	}
	
void Update()
{

		    if (Input.GetKeyDown (KeyCode.Space) && count>=8) {
                         Application.LoadLevel ("level2");
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
			if(count>=8)
			{
				winText.text = "You Won. Press Space to enter Level 2";
			
			}
        }
    }

	
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString() + " / 8";

	}
	
	void ResetPlayer()
	{
		transform.position = resetPosition;
		GetComponent<Rigidbody> ().velocity = new Vector3 (0.0f, 0.0f, 0.0f);
	}
	
}

