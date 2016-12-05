using UnityEngine;
using System.Collections;

public class fourwaylazer : MonoBehaviour {

    public SwitchScript laz3;
    public SwitchScript laz1;
    public SwitchScript laz2;
    public SwitchScript laz4;
    private LazerScript me;

    // Use this for initialization
    void Start () {
        me = gameObject.GetComponentInParent<LazerScript>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (!(laz4.getActive()) && !(laz3.getActive()) && !(laz2.getActive()) && !(laz1.getActive()))
            me.active = false;
        else
            me.active = true;
    }
}
