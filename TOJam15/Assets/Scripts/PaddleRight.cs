using UnityEngine;
using System.Collections;

public class PaddleRight : MonoBehaviour
{

    public static HingeJoint hinge;// = GetComponent<HingeJoint>();
    public static JointMotor motor;// = hinge.motor;

    public float targetVel = 400;
    public float power = 3000;
    public string inputKeyName = "right";
    public AudioSource SpatulaSound;

    // Use this for initialization
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        motor = hinge.motor;
        motor.force = 0;
        motor.targetVelocity = 90;
        motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;

        if (Input.GetKey(inputKeyName))
        {
            //Debug.Log ("Space Was Pressed");
            motor.force = power;
            motor.targetVelocity = targetVel;
            motor.freeSpin = false;
            hinge.motor = motor;
            hinge.useMotor = true;
            //SpatulaSound.Play();
        }
        else
        {
            motor.force = 0;
            motor.targetVelocity = targetVel;
            motor.freeSpin = false;
            hinge.motor = motor;
            hinge.useMotor = true;
        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("paddleright"))
        //    {
        //        //Debug.Log ("Space Was Pressed");
        //        motor.force = power;
        //        motor.targetVelocity = targetVel;
        //        motor.freeSpin = false;
        //        hinge.motor = motor;
        //        hinge.useMotor = true;
        //        //SpatulaSound.Play();
        //    }
        //}
        //else
        //{
        //    motor.force = 0;
        //    motor.targetVelocity = targetVel;
        //    motor.freeSpin = false;
        //    hinge.motor = motor;
        //    hinge.useMotor = true;
        //}
    }
}
