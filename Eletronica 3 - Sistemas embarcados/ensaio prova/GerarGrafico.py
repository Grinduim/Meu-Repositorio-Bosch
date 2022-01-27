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
server = 
database =
username = 
password = 
driver= '{ODBC Driver 17 for SQL Server}'
conn= pyodbc.connect('DRIVER='+driver+';SERVER='+server+';PORT=1433;DATABASE='+database+';UID='+username+';PWD='+ password)
cursor=conn.cursor() 
cursor.execute("SELECT Luminosidade, timestamp, FROM table") #executando comando sql
row = cursor.fetchone(); #pegando a primeira linha

listaLuminosidade = []
listaTempo = []

while row:
    listaLuminosidade.append(row[0])
    listaTempo.append(row[1])
    row = cursor.fetchone() #pegando a proxima linha
    
df = pd.DataFrame({"Luminosidae":listaLuminosidade,"Tempo":listaTempo})
df["Tempo"] = pd.to_datetime(df["Tempo"])
sns.relplot(x="Luminosidade",y="Tempo",data=df,kind = line)
plt.title("Luminosidade em função do tempo")
plt.xticks(rotation= 90)