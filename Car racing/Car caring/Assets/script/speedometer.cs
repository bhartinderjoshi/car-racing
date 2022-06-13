using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class speedometer : MonoBehaviour
{
    public Rigidbody target;

    public float maxSpeed = 0.0f; // The maximum speed of the target ** IN KM/H **

    public float minSpeedArrowAngle;
    public float maxSpeedArrowAngle;

    [Header("UI")]
    public TextMeshProUGUI speedLabel; // The label that displays the speed;
    public TextMeshProUGUI speedLabell;

    private float speed = 0.0f;
    private void Update()
    {
        // 3.6f to convert in kilometers
        // ** The speed must be clamped by the car controller **
        speed = target.velocity.magnitude * 3.6f;

        if (speedLabel != null)
            speedLabel.text = ((int)speed) + " km/h";
        if (speed > 0)
        {
            speedLabell.text = "N";
        }
        if (speed > 1)
        {
            speedLabell.text = "1";
        }
        if (speed > 20)
        {
            speedLabell.text = "2";
        }
        if (speed > 25)
        {
            speedLabell.text = "3";
        }
        if (speed > 40)
        {
            speedLabell.text = "4";
        }
        if (speed > 60)
        {
            speedLabell.text = "5";
        }
    }
}
