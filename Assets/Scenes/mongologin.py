import requests
import json
def validatepassword(username, password):

    url = "https://eu-central-1.aws.data.mongodb-api.com/app/data-sdmufjz/endpoint/data/v1/action/findOne"

    payload = json.dumps({
        "collection": "Users",
        "database": "bikorotDB",
        "dataSource": "players",
        "filter": {"username":username}
    })
    headers = {
    'Content-Type': 'application/json',
    'Access-Control-Request-Headers': '*',
    'api-key': '9ldJUzqDeLjFT04YBq5j2z4ukOK1xslJOHNJRHRuXfolnP7X0O7ilDaCtGJbIEHt',
    }
    
    response = requests.request("POST", url, headers=headers, data=payload).json()
    if not response.get("document"):
        print ("invalid")
        return None
    userpassword = response.get("document")["password"]
    validatepassword = userpassword == password
    if validatepassword:
        print ("valid") 
    else: 
        print ("invalid")

        




