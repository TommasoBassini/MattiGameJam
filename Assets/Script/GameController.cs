using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

	void Start ()
    {
	
	}
	
	void Update ()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            
        }
    }
}
