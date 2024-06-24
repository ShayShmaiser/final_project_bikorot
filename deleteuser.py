import requests
import json
 
def deleteuser(username):
    url = "https://eu-central-1.aws.data.mongodb-api.com/app/data-sdmufjz/endpoint/data/v1/action/deleteOne"
    payload = json.dumps({
        "collection": "Users",
        "database": "bikorotDB",
        "dataSource": "players",
        "filter": {"username": username}
    })
    headers = {
        'Content-Type': 'application/json',
        'api-key': '9ldJUzqDeLjFT04YBq5j2z4ukOK1xslJOHNJRHRuXfolnP7X0O7ilDaCtGJbIEHt',
    }
    response = requests.post(url, headers=headers, data=payload)
    if response.status_code == 200:
        response_data = response.json()
        if response_data.get("deletedCount", 0) > 0:
            print(f"User '{username}' deleted successfully.")
        else:
            print(f"No user found with username '{username}'.")
    else:
        print(f"Failed to delete user: {response.text}")
 
# Example usage
deleteuser("testuser")