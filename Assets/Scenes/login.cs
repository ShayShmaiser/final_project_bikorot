using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Text;


public class login : MonoBehaviour
{
    private string inputtt;
    private string inputttt;
    [SerializeField] private GameObject LOGIN;
    [SerializeField] private GameObject STARTGAME;
    [SerializeField] private GameObject FAILED;
    public void ReadStringInput(string s)
    {
        inputtt = s;
        Debug.Log(inputtt);
    }

    public void ReadStringInput2(string s)
    {
        inputttt = s;
        Debug.Log(inputttt);
    }

    private string url = "https://eu-central-1.aws.data.mongodb-api.com/app/data-sdmufjz/endpoint/data/v1/action/findOne";
    private string apiKey = "9ldJUzqDeLjFT04YBq5j2z4ukOK1xslJOHNJRHRuXfolnP7X0O7ilDaCtGJbIEHt";

    public void ValidatePassword()
    {
        StartCoroutine(ValidatePasswordCoroutine(inputtt, inputttt));
    }

    private IEnumerator ValidatePasswordCoroutine(string inputtt, string inputttt)
    {
        // Manually construct the JSON payload
        string payload = "{\"collection\":\"Users\",\"database\":\"bikorotDB\",\"dataSource\":\"players\",\"filter\":{\"username\":\"" + inputtt + "\"}}";

        UnityWebRequest request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(payload);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("Access-Control-Request-Headers", "*");
        request.SetRequestHeader("api-key", apiKey);

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("Error: " + request.error);
            yield break;
        }

        string responseText = request.downloadHandler.text;
        Response response = JsonUtility.FromJson<Response>(responseText);

        if (response.document == null)
        {
            Debug.Log("invalid");
            yield break;
        }

        string userPassword = response.document.password;
        bool validatePassword = userPassword == inputttt;

        if (validatePassword)
        {
            Debug.Log("valid");
            LOGIN.SetActive(true);
            STARTGAME.SetActive(true);
            FAILED.SetActive(false);
        }
        else
        {
            Debug.Log("invalid");
            LOGIN.SetActive(false);
            STARTGAME.SetActive(false);
            FAILED.SetActive(true);
        }
    }

    [System.Serializable]
    public class Response
    {
        public Document document;
    }

    [System.Serializable]
    public class Document
    {
        public string password;
    }
}
