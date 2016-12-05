using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    private Vector2 velocity;

    public float smoothTimeY;
    public float smoothTimeX;

	public Camera camera;

    public GameObject player;

	//float mapX = 100;
	//float mapY = 100;

	//private float minX;
	//private float maxX;
	//private float minY;
	//private float maxY;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
		camera = gameObject.GetComponent<Camera>();
		camera.orthographicSize= 7; 

		//var vertExt = camera.orthographicSize;
		// horzExt = vertExt * Screen.width / Screen.height;

		//minX = horzExt - mapX / 2.0f;
		//maxX = mapX / 2.0f - horzExt;
		//minY = vertExt - mapY / 2.0f;
		//maxY = mapY / 2.0f - vertExt;
    }

    void FixedUpdate()
    {
        float posx = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posy = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posx, posy, transform.position.z);
    }

	//void LateUpdate()
	//{
		//Vector3 v2 = camera.transform.position;
		//v2.x = Mathf.Clamp (v2.x, minX, maxX);
		//v2.y = Mathf.Clamp (v2.y, minY, maxY);
		//transform.position = v2;
	//}
}
