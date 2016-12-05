using UnityEngine;
using System.Collections;

public class partControl : MonoBehaviour {
	private ParticleSystem  particle;
	private Camera camera;
	// Use this for initialization
	void Start () {
		particle = gameObject.GetComponent<ParticleSystem>();
		camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 p = camera.ScreenToWorldPoint (new Vector2 ((Input.mousePosition.x), (Input.mousePosition.y)));
		particle.transform.position = p;
	}
}
