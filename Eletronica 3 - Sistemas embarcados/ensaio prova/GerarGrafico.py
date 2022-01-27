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

server = 
database =
username = 
password = 
driver= '{ODBC Driver 17 for SQL Server}'
conn= pyodbc.connect('DRIVER='+driver+';SERVER='+server+';PORT=1433;DATABASE='+database+';UID='+username+';PWD='+ password)
cursor=conn.cursor()
cursor.execute("SELECT Luminosidade, timestamp, FROM table")
row = cursor.fetchone();

listaLuminosidade = []
listaTempo = []

while row:
    listaLuminosidade.append(row[0])