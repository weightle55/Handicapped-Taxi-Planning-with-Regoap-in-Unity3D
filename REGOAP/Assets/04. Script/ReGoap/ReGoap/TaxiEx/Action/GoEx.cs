using UnityEngine;
using System.Collections;

public class GoEx : MonoBehaviour
{
	public float distance = 1.0f;

	public GameObject customertr;

	private Transform tr;
	private Transform nexttr;
	private Vector3 godir;
	private MeshRenderer trmet;

	public float moveSpeed=10.0f;
	// Use this for initialization
	void Start ()
	{
		tr = GetComponent<Transform> ();
		trmet = GetComponent<MeshRenderer> ();
		nexttr = customertr.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		moveTo (nexttr.position);
	}

	protected void moveTo(Vector3 position){
		godir = position - tr.position;
		if (godir.sqrMagnitude>distance) {
			tr.Translate (godir.normalized * Time.deltaTime * moveSpeed, Space.Self);
		} else {
			Material after = Resources.Load ("Hospital", typeof(Material)) as Material;
			trmet.material = after;
		}
	}
}

