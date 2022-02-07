# -*- coding: utf-8 -*-
"""
Created on Thu Jan 27 14:51:38 2022

@author: Vinicius
"""

import requests
import pyodbc
import time

# create table Dados
# (
# id int primary key Identity,
# Temperatura int not null,
# Humidade float not null,
# Momento Datetime default Current_Timestamp,
# )

# create table Dados
# (
# id int primary key Identity,
# Temperatura int not null,
# Humidade float not null,
# Momento Datetime default Current_Timestamp,
# )

def PegarDados():
    proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'} #proxi da bosch
    url_Firebase =  "https://prova-sistemas-embarcados-default-rtdb.firebaseio.com/Sensor/Temperatura.json" # url do firebase temperatura
    Temperatura = int(requests.get(url_Firebase,proxies=proxies).content)
    
    url_Firebase =  "https://prova-sistemas-embarcados-default-rtdb.firebaseio.com/Sensor/Humidade.json" # url do firebase da humidade
    Humidade = int(requests.get(url_Firebase,proxies=proxies).content)
    
    print(f"Temperatura: {Temperatura}")
    print(f"Humidade:{Humidade}")
    
    return Temperatura,Humidade

def InserirBD(Temperatura,Humidade):
    server = "JVLPC0581"
    database = "ProvaSQLVinicius"
    username = "vinicius"
    password = "admin"
    conexao = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)#  CONEXAO
    cursor = conexao.cursor()
    cursor.execute(f"INSERT INTO Dados (temperatura,humidade) VALUES({Temperatura},{Humidade})") #EXECUTANDO COMANDO sql DE INSERT
    cursor.commit()
    print("Inserido com sucesso")

while(True):
    InserirBD(PegarDados()[0],PegarDados()[1])
    time.sleep(1.5)