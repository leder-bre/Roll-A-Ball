using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	Random rnd = new Random();
	// Update is called once per frame
	void Update () {
	   transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	   transform.Rotate (new Vector3 (Random.value * 10, Random.value * 10, Random.value * 10) * Time.deltaTime);
	}
}
