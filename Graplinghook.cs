using UnityEngine;
using System.Collections;

public class Graplinghook : MonoBehaviour {
	DistanceJoint2D joint;
	Vector3 target;
	RaycastHit2D hit;
	public float distance = 10f;
	public LayerMask mask;
    public LineRenderer line;
    public float step =.2f;
    private Player player;
    // Use this for initialization
    void Start () {
		joint = gameObject.GetComponent<DistanceJoint2D>();
		joint.enabled = false;
        line.enabled = false;
        line.sortingOrder = 99;

        player = gameObject.GetComponentInParent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        if(joint.distance > 1f)
        {
            joint.distance -= step;
        }
        else
        {
            line.enabled = false;
            joint.enabled = false;
        }

		if(Input.GetKeyDown(KeyCode.E))
			{
			    target = Camera.main.ScreenToWorldPoint(new Vector2((Input.mousePosition.x), (Input.mousePosition.y)));

			    target.z = 0;

				hit = Physics2D.Raycast(transform.position, target - transform.position, distance, mask);
			if(hit.collider != null && hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
				{

                joint.enabled = true;
                line.enabled = true;
				    joint.connectedBody = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                Vector2 connectPoint = hit.point - new Vector2(hit.collider.transform.position.x, hit.collider.transform.position.y);
                connectPoint.x = connectPoint.x / hit.collider.transform.localScale.x;
                connectPoint.y = connectPoint.y / hit.collider.transform.localScale.y;
                //Debug.Log(connectPoint);
                joint.connectedAnchor = connectPoint;
                joint.distance = Vector2.Distance(transform.position, hit.point);
                line.SetPosition(0, player.transform.position);
                line.SetPosition(1, hit.point);
				}
		}
        if(line.enabled == true)
        line.SetPosition(1, joint.connectedBody.transform.TransformPoint(joint.connectedAnchor));

        if (Input.GetKey(KeyCode.E))
        {

            line.SetPosition(0, player.transform.position);
        }
        if (Input.GetKeyUp(KeyCode.E))
				{ joint.enabled = false;
            line.enabled = false;
		}

	}
}
