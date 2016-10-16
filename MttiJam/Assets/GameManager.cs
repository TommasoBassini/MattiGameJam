using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public string gameState = "wait";
    Player playerRef;

    void Awake()
    {
        playerRef = FindObjectOfType<Player>();
    }

    void WaitState()
    {
        gameState = "setRamp";
    }
    void SetRampState()
    {
        gameState = "setPower";
    }
    void SetPowerState(float value)
    {
        playerRef.wheelChairPower = value;
    }
    void StartState()
    {
        playerRef.rbRef.constraints = RigidbodyConstraints2D.None;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WaitState();
            SetRampState();
            SetPowerState(0.5f);
            StartState();
        }
    }
}

