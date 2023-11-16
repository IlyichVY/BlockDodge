using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.y < -6f)
		{
			Destroy(gameObject);
			GameObject.Find("GameManager").GetComponent<GameManager>().Score++; // only if the player dodges the crate successfully, the point is scored
			GameObject.Find("GameManager").GetComponent<GameManager>().ScoreText.text = GameObject.Find("GameManager").GetComponent<GameManager>().Score.ToString();

        }
	}
}

