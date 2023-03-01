using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
	public Camera MainCamera;
	private Vector2 screenBounds;
	private float objectWidth;
	private float objectHeight;

	// Use this for initialization
	void Start()
	{
		screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
		objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
		objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
	}

	// Update is called once per frame
	void LateUpdate()
	{
		Vector3 viewPos = transform.position;
		viewPos.x = Mathf.Clamp(viewPos.x, (screenBounds.x * -1)/3 + objectWidth/2, screenBounds.x/3 - objectWidth/2);
		transform.position = viewPos;
	}
}
