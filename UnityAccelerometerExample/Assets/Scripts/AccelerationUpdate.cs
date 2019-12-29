using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerationUpdate : MonoBehaviour
{
    public Text acceleration = null;

    // Update is called once per frame
    void Update()
    {
        acceleration.text = "Acceleration: " + Input.acceleration;
    }
}
