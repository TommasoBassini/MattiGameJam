using UnityEngine;
using System.Collections;

public class PlayerVisual : MonoBehaviour {

    Player playerRef;

	// Use this for initialization
	void Awake () {
        playerRef = FindObjectOfType<Player>();
	}

    RaycastHit2D findNormalHit;

	// Update is called once per frame
	void Update ()
    {
        transform.position = playerRef.transform.position;

        if (!playerRef.leftRamp)
        {
            findNormalHit = Physics2D.Raycast(transform.position, -transform.up);
            this.transform.rotation = Quaternion.FromToRotation(Vector3.up, findNormalHit.normal);
        }
    }

    public void AlwaysDritto(Quaternion quat)
    {
        this.transform.transform.rotation = quat;
    }

 
}
