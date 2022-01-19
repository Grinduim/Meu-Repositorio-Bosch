import requests
import json

proxies = {'https': "http://disrct:saladigital0311@10.224.200.26:8080"}

url = 'https://random.dog/woof.json'
img_data = requests.get(url , proxies = proxies).content
new_url = json.loads(img_data)['url']
img  = requests.get(new_url,proxies = proxies).content              

with open ('dog.jpg','wb') as dog_file:
    dog_file.write(img)