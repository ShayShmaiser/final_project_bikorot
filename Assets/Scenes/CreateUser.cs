using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class CreateUser : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CreateUserRequest("input1", "input2"));
    }

    IEnumerator CreateUserRequest(string username, string password)
    {
        string url = "https://eu-central-1.aws.data.mongodb-api.com/app/data-sdmufjz/endpoint/data/v1/action/insertOne";

        // Create JSON payload
        string jsonPayload = "{\"collection\":\"Users\",\"database\":\"bikorotDB\",\"dataSource\":\"players\",\"document\":{\"username\":\"" + username + "\",\"password\":\"" + password + "\"}}";

        // Create UnityWebRequest
        UnityWebRequest request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonPayload);
        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("api-key", "9ldJUzqDeLjFT04YBq5j2z4ukOK1xslJOHNJRHRuXfolnP7X0O7ilDaCtGJbIEHt");

        // Send the request
        yield return request.SendWebRequest();

        // Handle response
        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("User created successfully");
        }
        else
        {
            Debug.LogError("Failed to create user: " + request.error);
        }
    }
}
