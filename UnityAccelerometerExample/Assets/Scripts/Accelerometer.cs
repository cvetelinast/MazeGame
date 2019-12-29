using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accelerometer : MonoBehaviour
{
    private Rigidbody rigid;
    private float speedCoeff = 1;

    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    public void AdjustSpeed(float coeff)
    {
        speedCoeff = coeff;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 acc = Input.acceleration;
        acc = Quaternion.Euler(90, 0, 0) * acc;
        var force = acc * speedCoeff * Time.deltaTime;
        Debug.Log("Force: " + force + ", acc: " + acc + ", Input.acceleration: " + Input.acceleration + ", speedCoeff: " + speedCoeff + " , deltaTime: " + Time.deltaTime);
        rigid.AddForce(force);
    }
}
