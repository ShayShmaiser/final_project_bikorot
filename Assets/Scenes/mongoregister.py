import requests
import json
 
def createuser(username, password):

    url = "https://eu-central-1.aws.data.mongodb-api.com/app/data-sdmufjz/endpoint/data/v1/action/insertOne"

    payload = json.dumps({

        "collection": "Users",

        "database": "bikorotDB",

        "dataSource": "players",

        "document": {"username": username, "password": password}

    })

    headers = {

        'Content-Type': 'application/json',

        'api-key': '9ldJUzqDeLjFT04YBq5j2z4ukOK1xslJOHNJRHRuXfolnP7X0O7ilDaCtGJbIEHt',

    }

    response = requests.post(url, headers=headers, data=payload)

    if response.status_code == 200:

        print("User created successfully")

    else:

        print(f"Failed to create user: {response.text}")
 
# Example usage

#createuser("erel", "123")
