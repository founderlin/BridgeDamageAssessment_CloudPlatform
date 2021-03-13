import requests
from celery import Celery


zipfile = "C:/Users/flin/PycharmProjects/wisib/SOFI/task50.zip"
with open(zipfile, 'rb') as f:
    r = requests.post('https://file.io/', files={'file': f})
jsonresponce = r.json()
if r.status_code == 200:
    filelink = jsonresponce['link']

# print(filelink)

app = Celery('tasks',
             broker='amqp://sofuser:sardela2@1.tcp.eu.ngrok.io:24955/sofhost',
             result_backend = 'rpc://',
             broker_api='http://guest:guest@1.tcp.eu.ngrok.io:24955/api')

app.conf.broker_heartbeat=59
app.conf.result_backend='rpc://sofhost'

# This line doesn't work. In execution there is endless processing with out any reponses
calc =app.send_task("softasks.submit_calc", args=[filelink])
calc.get()

result=app.send_task("softasks.get_results", args=[filelink])
url = result.get()
print(url)
# print(result.get)