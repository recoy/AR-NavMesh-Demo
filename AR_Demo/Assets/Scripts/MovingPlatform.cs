using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public float endY;
    public PlatformButton button;
    public Vector3 targetPos;
    public float speed = 0.3f;


	// Use this for initialization
	void Start () {

        targetPos = new Vector3(transform.position.x, endY, transform.position.z);

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (button.movePlatform == true)
            MovePlatform();
	}

    void MovePlatform()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);
    }
}
