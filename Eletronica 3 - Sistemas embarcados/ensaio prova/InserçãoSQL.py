# -*- coding: utf-8 -*-
"""
Created on Thu Jan 27 14:51:38 2022

@author: Vinicius
"""

import requests
import pyodbc
import time

def PegarDados():
    proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'} #proxi da bosch
    url_Firebase = "https://esp32-457c3-default-rtdb.firebaseio.com/SensorLuz/Luminosidade" # url do firebase
    Luminosidade = int(requests.get(url_Firebase,proxies=proxies).content) #fazend o request do dado
    print(Luminosidade)
    return Luminosidade

def InserirBD(Luminosidade):
    server = JVLPC0565\SQLEXPRESS
    database = 
    username = 
    password = 
    conexao = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)#  CONEXAO
    cursor = conexao.cursor()
    cursor.execute(f"INSERT INTO TABLE (LUMINOSIDADE) VALUES({Luminosidade})") #EXECUTANDO COMANDO sql DE INSERT
    cursor.commit()
    print("Inserido com sucesso")

while(true):
    Luminosidade = PegarDados()
    InserirBD(Luminosidade)
