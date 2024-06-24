using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Rgstrusrnm : MonoBehaviour
{
    private string input;
    private string inputt;
    [SerializeField] private GameObject Continue;
    [SerializeField] private GameObject Created;
    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
    
    public void ReadStringInput2(string s)
    {
        inputt = s;
        Debug.Log(input);
    }
    
    public void Create()
    {
        StartCoroutine(CreateUserRequest(input, inputt));
    }

    IEnumerator CreateUserRequest(string input, string inputt)
    {
        string url = "https://eu-central-1.aws.data.mongodb-api.com/app/data-sdmufjz/endpoint/data/v1/action/insertOne";

        // Create JSON payload
        string jsonPayload = "{\"collection\":\"Users\",\"database\":\"bikorotDB\",\"dataSource\":\"players\",\"document\":{\"username\":\"" + input + "\",\"password\":\"" + inputt + "\"}}";

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
            Continue.SetActive(true);
            Created.SetActive(true);
        }
        else
        {
            Debug.LogError("Failed to create user: " + request.error);

        }
    }
}
