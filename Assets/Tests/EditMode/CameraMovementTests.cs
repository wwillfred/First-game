using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CameraMovementTests
{
    [Test]
    public void MoveCameraRight_NoInput_True()
    {
        var gameObject = new GameObject();
        var cameraController = gameObject.AddComponent<CameraController>();

        Vector3 initialCamPosition = cameraController.transform.position;
        Debug.Log("initial cam pos is: " + initialCamPosition.ToString());

        cameraController.MoveCameraRight();
        Debug.Log("after moving right, cam pos is: " + cameraController.transform.position.ToString());

        Assert.AreEqual(new Vector3(initialCamPosition.x + 10, initialCamPosition.y, initialCamPosition.z), cameraController.transform.position);
    }

    [Test]
    public void MoveCameraLeft_NoInput_True()
    {
        var gameObject = new GameObject();
        var cameraController = gameObject.AddComponent<CameraController>();

        Vector3 initialCamPosition = cameraController.transform.position;
        Debug.Log("initial cam pos is: " + initialCamPosition.ToString());

        cameraController.MoveCameraLeft();
        Debug.Log("after moving left, cam pos is: " + cameraController.transform.position.ToString());

        Assert.AreEqual(new Vector3(initialCamPosition.x - 10, initialCamPosition.y, initialCamPosition.z), cameraController.transform.position);
    }

    [Test]
    public void MoveCameraUp_NoInput_True()
    {
        var gameObject = new GameObject();
        var cameraController = gameObject.AddComponent<CameraController>();

        Vector3 initialCamPosition = cameraController.transform.position;
        Debug.Log("initial cam pos is: " + initialCamPosition.ToString());

        cameraController.MoveCameraUp();
        Debug.Log("after moving up, cam pos is: " + cameraController.transform.position.ToString());

        Assert.AreEqual(new Vector3(initialCamPosition.x, initialCamPosition.y + 9, initialCamPosition.z), cameraController.transform.position);
    }

    [Test]
    public void MoveCameraDown_NoInput_True()
    {
        var gameObject = new GameObject();
        var cameraController = gameObject.AddComponent<CameraController>();

        Vector3 initialCamPosition = cameraController.transform.position;
        Debug.Log("initial cam pos is: " + initialCamPosition.ToString());

        cameraController.MoveCameraDown();
        Debug.Log("after moving down, cam pos is: " + cameraController.transform.position.ToString());

        Assert.AreEqual(new Vector3(initialCamPosition.x, initialCamPosition.y - 9, initialCamPosition.z), cameraController.transform.position);
    }
}
