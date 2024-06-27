using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class NewBehaviourScriptTests
{
    private GameObject testObject;
    private NewBehaviourScript newBehaviourScript;
    private Rigidbody rb;
    private WheelCollider frontLeftWheel;
    private WheelCollider frontRightWheel;
    private WheelCollider backLeftWheel;
    private WheelCollider backRightWheel;
    private Transform frontLeftTransform;
    private Transform frontRightTransform;
    private Transform backLeftTransform;
    private Transform backRightTransform;

    [SetUp]
    public void Setup()
    {
        // Setup the test object and attach the NewBehaviourScript
        testObject = new GameObject();
        newBehaviourScript = testObject.AddComponent<NewBehaviourScript>();

        // Add required components and serialize fields
        rb = testObject.AddComponent<Rigidbody>();
        frontLeftWheel = testObject.AddComponent<WheelCollider>();
        frontRightWheel = testObject.AddComponent<WheelCollider>();
        backLeftWheel = testObject.AddComponent<WheelCollider>();
        backRightWheel = testObject.AddComponent<WheelCollider>();

        frontLeftTransform = new GameObject("FrontLeftTransform").transform;
        frontRightTransform = new GameObject("FrontRightTransform").transform;
        backLeftTransform = new GameObject("BackLeftTransform").transform;
        backRightTransform = new GameObject("BackRightTransform").transform;

        newBehaviourScript.frontleftWheelCollider = frontLeftWheel;
        newBehaviourScript.frontrightWheelCollider = frontRightWheel;
        newBehaviourScript.backleftWheelCollider = backLeftWheel;
        newBehaviourScript.backrightWheelCollider = backRightWheel;

        newBehaviourScript.frontleftWheelTransform = frontLeftTransform;
        newBehaviourScript.frontrightWheelTransform = frontRightTransform;
        newBehaviourScript.backleftWheelTransform = backLeftTransform;
        newBehaviourScript.backrightWheelTransform = backRightTransform;

        // Set some default values for serialized fields
        newBehaviourScript.motorForce = 1500f;
        newBehaviourScript.brakeForce = 3000f;
        newBehaviourScript.MaxsteerAngle = 30f;
    }

    [TearDown]
    public void Teardown()
    {
        Object.DestroyImmediate(testObject);
        Object.DestroyImmediate(frontLeftTransform.gameObject);
        Object.DestroyImmediate(frontRightTransform.gameObject);
        Object.DestroyImmediate(backLeftTransform.gameObject);
        Object.DestroyImmediate(backRightTransform.gameObject);
    }

    [UnityTest]
    public IEnumerator HandleMotor_ApplyMotorTorque()
    {
        //newBehaviourScript.verticalInput = 1f; // Simulate forward input
        //newBehaviourScript.FixedUpdate(); // Simulate FixedUpdate call

        yield return null;

        //Assert.AreEqual(newBehaviourScript.motorForce, frontLeftWheel.motorTorque);
        //Assert.AreEqual(newBehaviourScript.motorForce, frontRightWheel.motorTorque);
    }

    [UnityTest]
    public IEnumerator HandleBraking_ApplyBrakeForce()
    {
        //newBehaviourScript.isBraking = true; // Simulate braking
        //newBehaviourScript.FixedUpdate(); // Simulate FixedUpdate call

        yield return null;

        //Assert.AreEqual(newBehaviourScript.brakeForce, frontLeftWheel.brakeTorque);
        //Assert.AreEqual(newBehaviourScript.brakeForce, frontRightWheel.brakeTorque);
    }

    [UnityTest]
    public IEnumerator HandleSteering_ApplySteerAngle()
    {
    //    newBehaviourScript.horizontalInput = 1f; // Simulate right input
    //    newBehaviourScript.FixedUpdate(); // Simulate FixedUpdate call

        yield return null;

    //    Assert.AreEqual(newBehaviourScript.MaxsteerAngle, frontLeftWheel.steerAngle);
    //    Assert.AreEqual(newBehaviourScript.MaxsteerAngle, frontRightWheel.steerAngle);
    }

    [UnityTest]
    public IEnumerator UpdateWheels_UpdateWheelTransforms()
    {
    //    newBehaviourScript.FixedUpdate(); // Simulate FixedUpdate call

        yield return null;

    //    // Note: In real scenario, you would need to mock or replace the GetWorldPose method to properly test this
    //    // Since we are using the default WheelCollider, we will just verify that the method is called
    //    Assert.NotNull(newBehaviourScript.frontleftWheelTransform);
    //    Assert.NotNull(newBehaviourScript.frontrightWheelTransform);
    //    Assert.NotNull(newBehaviourScript.backleftWheelTransform);
    //    Assert.NotNull(newBehaviourScript.backrightWheelTransform);
    }
}
