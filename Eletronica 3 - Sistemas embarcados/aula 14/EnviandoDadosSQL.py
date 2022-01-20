# -*- coding: utf-8 -*-
"""
Created on Thu Jan 20 15:34:40 2022

@author: Vinicius
"""
import requests
import pyodbc
import time

def sinal():
    proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
    url_temperatura = 'https://vinicius-dht-default-rtdb.firebaseio.com/Sensor/temperatura.json'
    url_umidade = 'https://vinicius-dht-default-rtdb.firebaseio.com/Sensor/umidade.json' #urls da onde ele deve pegar os valores
    temperatura = float(requests.get(url_temperatura, proxies=proxies).content) # pegando o valor da temperatura
    umidade = float(requests.get(url_umidade, proxies=proxies).content) # pegando o valor da umidade
    print(temperatura)
    print(umidade)
    return temperatura, umidade #retorno


def InserirBD(sinal):
     server = 'JVLPC0581' #serivdor do sql
     database = 'testeaa' #nome do banco
     username = 'vinicius' #usuario
     password = 'admin' #senha
     cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)#  CONEXAO
     cursor = cnxn.cursor() # DIZENDO QUE VOU ESCREVER
     cursor.execute(f"INSERT dbo.Sensor (Temperatura, Umidade) VALUES ({sinal[0]},{sinal[1]});") # EXECUTANDO O MYSQL
     cursor.commit() #SALVANDO A INSERÇÃO
     print("Inserido com sucesso!")

while(True):
    InserirBD(sinal())
    time.sleep(60)

