using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public float speed;

    public Image powerImage;
    public Image angleImage;
    public GameObject angleValue;
    public float strenght;
    public float angle;

    public int n = 0;
    private float p = 0;
    void Update()
    {
        if (n == 2)
        {
            p= 1;
            strenght = Mathf.PingPong(Time.time, p);
            powerImage.fillAmount = strenght;
        }

        if (n == 1)
        {
            angleValue.transform.eulerAngles =new Vector3(0,0,ProportionalValue(angle, 90));
            angle = Mathf.PingPong(Time.time, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (n)
            {
                case 0:
                    {
                        powerImage.gameObject.SetActive(true);
                        angleImage.gameObject.SetActive(true);
                        angleValue.gameObject.SetActive(true);
                        strenght = 0;
                        n++;
                        break;
                    }
                case 2:
                    {
                        n++;
                        strenght = ProportionalValue(strenght, 100);
                        break;
                    }
                case 1:
                    {
                        n++;
                        angle = ProportionalValue(angle, 90);
                        break;
                    }
                case 3:
                    {
                        Debug.Log("Forza " + strenght + " angolo " + angle);
                        break;
                    }
            }
        }
    }

    float ProportionalValue(float value, float valueMax)
    {
        return value * valueMax;
    }

    float PingPong(float aValue, float aMin, float aMax)
    {
        return Mathf.PingPong(aValue, aMax - aMin) + aMin;
    }
}
