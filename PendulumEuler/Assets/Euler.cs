using UnityEngine;
using System.Collections;

public class Euler : MonoBehaviour {
	Rigidbody rb;
	float fi;
	public float l;
	public float g ;
	float w0,w,psi;float x, y;

	private float t;
	Vector3 now;

	// Use this for initialization
	void Start () {
		fi = Mathf.PI / 2f;
		l = 7f;
		g = 9.8f;
		rb = GetComponent<Rigidbody> ();
		w0 = Mathf.Sqrt (g / l);
		rb.position=new Vector3(x=l*Mathf.Sin(fi),y=-l*(Mathf.Cos(fi)),0f);
		Debug.Log ("start  "+t+",  " +x + ", " +y);
	}

	// Update is called once per frame
	void Update () {
		
		t = Time.deltaTime;

			psi = fi + w * t;
			w = w0 - (g / l) * Mathf.Sin (psi) * t;
			rb.MovePosition (new Vector3 (x = l * Mathf.Sin (psi), y = -l * (Mathf.Cos (psi)), 0f));

			fi = psi;
			w0 = w;

		Debug.Log (t+",  "+x + ", " +y);
	}

}
