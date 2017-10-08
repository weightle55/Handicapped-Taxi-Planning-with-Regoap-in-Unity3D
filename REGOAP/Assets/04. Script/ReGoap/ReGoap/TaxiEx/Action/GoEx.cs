using UnityEngine;
using System.Collections;

public class GoEx : MonoBehaviour
{
	public float h = 0.0f;
	public float v = 0.0f;

	public GameObject customertr;

	private Transform tr;
	private Transform nexttr;
	private Vector3 godir;

	public float moveSpeed=10.0f;
	// Use this for initialization
	void Start ()
	{
		tr = GetComponent<Transform> ();
		nexttr = customertr.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		moveTo (nexttr.position);
	}

	protected void moveTo(Vector3 position){
		godir = position - tr.position;
		tr.Translate (godir.normalized * Time.deltaTime * moveSpeed, Space.Self);
	}
}

