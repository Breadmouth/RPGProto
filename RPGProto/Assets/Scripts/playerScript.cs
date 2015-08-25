using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 newVelocity = new Vector3(0, 0, 0);

		if (Input.GetKey(KeyCode.W))
		{
			newVelocity += new Vector3(0, 1, 0);
		}
		if (Input.GetKey(KeyCode.S))
		{
			newVelocity += new Vector3(0, -1, 0);
		}
		if (Input.GetKey(KeyCode.A))
		{
			newVelocity += new Vector3(-1, 0, 0);
		}
		if (Input.GetKey(KeyCode.D))
		{
			newVelocity += new Vector3(1, 0, 0);
		}

		newVelocity = Vector3.Normalize(newVelocity);

		gameObject.transform.position += newVelocity * speed * Time.deltaTime;

	}
}
