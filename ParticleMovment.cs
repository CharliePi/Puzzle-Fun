using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ParticleMovment : MonoBehaviour {
	private ParticleSystem  particle;
	private Camera camera;
	private Player player;
	private int sceneIndex;

	// Use this for initialization
	void Start () 
	{
		camera = Camera.main;
		particle = gameObject.GetComponent<ParticleSystem>();
		player = gameObject.GetComponentInParent<Player>();
		sceneIndex = SceneManager.GetActiveScene().buildIndex;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButton (0) && sceneIndex > 4 && player.death == false && player.clickTime > 0) {
			particle.Play();
		}
		else if(particle.isPlaying)
			particle.Stop();
	}
}
