# -*- coding: utf-8 -*-
"""
Created on Thu Jan 27 15:30:29 2022

@author: DISRCT
"""

import matplotlib.pyplot as plt
import pyodbc
import numpy as np
import seaborn as sns
import pandas as pd

#dados de conexão com o sql
print("V Inicio")
server = "JVLPC0581"
database = "ProvaSQLVinicius"
username = "vinicius"
password = "admin"
driver= '{ODBC Driver 17 for SQL Server}'
conn= pyodbc.connect('DRIVER='+driver+';SERVER='+server+';PORT=1433;DATABASE='+database+';UID='+username+';PWD='+ password)
print("V Conexao")
cursor=conn.cursor() 
cursor.execute("SELECT Temperatura, humidade,momento FROM dbo.Dados") #executando comando sql
row = cursor.fetchone(); #pegando a primeira linha
print("V Select")
lista=[]
listatempo=[]
listahu = [ ]

while row:
    lista.append(row[0])
    listatempo.append((row[1]))
    listahu.append(row[2])
    row = cursor.fetchone()


df = pd.DataFrame({"Temperatura":lista, "Tempo":listatempo}) #criando o dataFrame
df["Tempo"] = pd.to_datetime(df["Tempo"]) #formatando o datetime
sns.relplot(x = "Tempo", y = "Temperatura", data=df, kind = "line")
plt.title("Temperatura por tempo")
plt.xticks(rotation=90)

df = pd.DataFrame({"Umidade":listahu, "Tempo":listatempo})
df["Tempo"] = pd.to_datetime(df["Tempo"])
sns.relplot(x = "Tempo", y = "Umidade", data=df, kind = "line")
plt.title("Umidade por tempo")
plt.xticks(rotation=90)