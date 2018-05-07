using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// up => 1
	// down => 2
	// left => 3
	// right => 4
	// turn => 5
	// tap = 6
	List<float> whichBlock = new List<float>() {1, 2, 1, 1, 3, 4, 5, 6, 6, 4};

	public int blockMark = 0;
	public Transform blockObj;
	public string timerReset = "y";
	public string blockType;
	public float xPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (timerReset == "y")
		{
			StartCoroutine (spawnBlock ());
			timerReset = "n";
		}
	}

	IEnumerator spawnBlock ()
	{
		yield return new WaitForSeconds (1);

		if (whichBlock [blockMark] == 1)
		{
			blockType = "up";
		}
		if (whichBlock [blockMark] == 2)
		{
			blockType = "down";
		}
		if (whichBlock [blockMark] == 3)
		{
			blockType = "left";
		}
		if (whichBlock [blockMark] == 4)
		{
			blockType = "right";
		}
		if (whichBlock [blockMark] == 5)
		{
			blockType = "turn";
		}
		if (whichBlock [blockMark] == 6)
		{
			blockType = "tap";
		}

		blockMark += 1;
		timerReset = "y";
		Instantiate (blockObj, new Vector3(0.05f, 1.8f, -3.2f), blockObj.rotation);
	}
}
