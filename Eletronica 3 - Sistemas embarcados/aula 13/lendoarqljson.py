import requests
import json

proxies = {'https': "http://disrct:saladigital0311@10.224.200.26:8080"} #comando para passa ro proxie

url = 'https://random.dog/woof.json' #url  ou caminho do json
img_data = requests.get(url , proxies = proxies).content #coisas dois
new_url = json.loads(img_data)['url']
img  = requests.get(new_url,proxies = proxies).content              

with open ('dog.jpg','wb') as dog_file:
    dog_file.write(img)