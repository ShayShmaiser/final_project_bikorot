using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentsteerAngle;
    private float currentbrakeForce;
    private bool isBraking;


    [SerializeField] private float motorForce;
    [SerializeField] private float brakeForce;
    [SerializeField] private float MaxsteerAngle;

    [SerializeField] private WheelCollider frontleftWheelCollider;
    [SerializeField] private WheelCollider frontrightWheelCollider;
    [SerializeField] private WheelCollider backleftWheelCollider;
    [SerializeField] private WheelCollider backrightWheelCollider;

    [SerializeField] private Transform frontleftWheelTransform;
    [SerializeField] private Transform frontrightWheelTransform;
    [SerializeField] private Transform backleftWheelTransform;
    [SerializeField] private Transform backrightWheelTransform;
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }
    private void HandleMotor()
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

    private void Brake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
    }
    private void unBrake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotationZ; 
       
    }
    private void ApplyBraking()
    {
        frontleftWheelCollider.brakeTorque = currentbrakeForce;
        frontrightWheelCollider.brakeTorque = currentbrakeForce;
       backleftWheelCollider.brakeTorque = currentbrakeForce;
       backleftWheelCollider.brakeTorque = currentbrakeForce;

    }
    
    private void HandleSteering()
    {
        currentsteerAngle = MaxsteerAngle * horizontalInput;
        frontleftWheelCollider.steerAngle = currentsteerAngle;
        frontrightWheelCollider.steerAngle = currentsteerAngle;
    }
    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBraking = Input.GetKey(KeyCode.Space);
        
        
    }
    private void UpdateWheels()
    {
        UpdateSingleWheel(frontleftWheelCollider, frontleftWheelTransform);
        UpdateSingleWheel(frontrightWheelCollider, frontrightWheelTransform);
        UpdateSingleWheel(backleftWheelCollider, backleftWheelTransform);
        UpdateSingleWheel(backrightWheelCollider, backrightWheelTransform);
    }
    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot
     ;   wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
   
}

