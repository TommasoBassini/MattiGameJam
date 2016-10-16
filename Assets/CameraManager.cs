using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0, 0, 0);
        this.transform.position = FindObjectOfType<Player>().transform.position;
    }
}
