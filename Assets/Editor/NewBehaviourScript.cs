using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public const string HORIZONTAL = "Horizontal";
    public const string VERTICAL = "Vertical";

    public float horizontalInput;
    public float verticalInput;
    public float currentsteerAngle;
    public float currentbrakeForce;
    public bool isBraking;


    [SerializeField] public float motorForce;
    [SerializeField] public float brakeForce;
    [SerializeField] public float MaxsteerAngle;

    [SerializeField] public WheelCollider frontleftWheelCollider;
    [SerializeField] public WheelCollider frontrightWheelCollider;
    [SerializeField] public WheelCollider backleftWheelCollider;
    [SerializeField] public WheelCollider backrightWheelCollider;

    [SerializeField] public Transform frontleftWheelTransform;
    [SerializeField] public Transform frontrightWheelTransform;
    [SerializeField] public Transform backleftWheelTransform;
    [SerializeField] public Transform backrightWheelTransform;
    public void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }
    public void HandleMotor()
    {
        frontleftWheelCollider.motorTorque = verticalInput * motorForce;
        frontrightWheelCollider.motorTorque = verticalInput * motorForce;
        currentbrakeForce = isBraking ? brakeForce : 0f;

        if (isBraking)
        {
          Brake();
        }
        else
        {
            unBrake();
        }
       
            
    }
    Rigidbody m_Rigidbody;

    public void Brake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
    }
    public void unBrake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotationZ; 
       
    }
    public void ApplyBraking()
    {
        frontleftWheelCollider.brakeTorque = currentbrakeForce;
        frontrightWheelCollider.brakeTorque = currentbrakeForce;
       backleftWheelCollider.brakeTorque = currentbrakeForce;
       backleftWheelCollider.brakeTorque = currentbrakeForce;

    }

    public void HandleSteering()
    {
        currentsteerAngle = MaxsteerAngle * horizontalInput;
        frontleftWheelCollider.steerAngle = currentsteerAngle;
        frontrightWheelCollider.steerAngle = currentsteerAngle;
    }
    public void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBraking = Input.GetKey(KeyCode.Space);
        
        
    }
    public void UpdateWheels()
    {
        UpdateSingleWheel(frontleftWheelCollider, frontleftWheelTransform);
        UpdateSingleWheel(frontrightWheelCollider, frontrightWheelTransform);
        UpdateSingleWheel(backleftWheelCollider, backleftWheelTransform);
        UpdateSingleWheel(backrightWheelCollider, backrightWheelTransform);
    }
    public void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot
     ;   wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
   
}

