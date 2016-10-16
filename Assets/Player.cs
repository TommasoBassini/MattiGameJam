using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    GameManager gmRef;

    public Rigidbody2D rbRef;

    public float wheelChairPower;
    public float rampAngle;

    public bool leftRamp;

    public GameObject rampRef;
    private PlayerVisual playerVisual;

	// Use this for initialization
	void Awake ()
    {
        rbRef = GetComponent<Rigidbody2D>();
        gmRef = FindObjectOfType<GameManager>();
        playerVisual = FindObjectOfType<PlayerVisual>();
	}

    void OnCollision2DExit(Collision2D other)
    {
        if (other.gameObject == rampRef)
        {
            leftRamp = true;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {        
        ContactPoint2D contact = col.contacts[0];
        playerVisual.AlwaysDritto(Quaternion.FromToRotation(Vector3.up, contact.normal));
    }
}
