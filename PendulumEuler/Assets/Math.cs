using UnityEngine;using System.Collections;

public class Math : MonoBehaviour {
	Rigidbody rb;
	float fi;
	public float l;
	public float g ;
	float w,psi;float x, y;

	float t;
	Vector3 now;

	// Use this for initialization
	void Start () {
		t = 0.0f;
		fi = Mathf.PI / 2f;
		l = 7f;
		g = 9.8f;
		rb = GetComponent<Rigidbody> ();
		w = Mathf.Sqrt (g / l);
		rb.position=new Vector3(x=l*Mathf.Sin(fi),y=-l*(Mathf.Cos(fi)),0f);
		Debug.Log ("start  "+0.0f+",  " +x + ", " +y);
	}
	
	// Update is called once per frame
	void Update () {

		t += Time.deltaTime;
	
		psi = fi * Mathf.Cos (w * t);

		rb.position= (new Vector3(x=l*Mathf.Sin(psi),y=-l*(Mathf.Cos(psi)),0f));
		//Debug.Log (t+",  "+x + ", " +y);
	}
}
