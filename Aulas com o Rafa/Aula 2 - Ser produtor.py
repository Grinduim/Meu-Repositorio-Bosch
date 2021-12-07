# -*- coding: utf-8 -*-
"""
Created on Fri Nov 26 14:03:49 2021

@author: DISRCT
"""
# 1 - Ler arquivo CSV e jogar no dicionario
# 2 -  De tempo em tempo ler  novo arquivo
# 3 -  

#import pandas as pd
#import csv
#
##abre o arquivo
#file = open('S:/TEC/Production_System/03.Shared/26. Transferencia/ETS/vinicius/stat010/1637947000.csv')
##print do tipo
#print(type(file))
#
## lê o arquivo
#csvreader = csv.reader(file)
##header
#header = []
#header = next(csvreader)
#header
## le os valores
#rows = []
#for row in csvreader:
#    rows.append(row)
#    
#rows
## fecha o arquivo
#file.close()


import os
import pandas as pd
import time
from kafka import KafkaProducer
import json

#função para mandar a msg
def SendMensage(msg):
    producer.send("testCt-ETS", msg)
    
    
    
# PRODUTOR CRIADO
producer =  KafkaProducer(bootstrap_servers = ["ct-br.exaas.bosch.com:9092"],value_serializer=lambda v: json.dumps(v).encode('utf-8'))


while(True):
    path = r'\\bosch.com\dfsrb\dfsBR\LOC\Ct\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\datastream\vinicius\stat010'
    
    # lista todos os arquivos no diretorio
    file = os.listdir(path)
    
    # para guardas os dicionarios
    lista = []
    
    # para percocorrer os file
    for f in file:
        # ele entra na pasta 
        fileName = os.path.join(path,f)
        # abre o csv
        dict_from_csv = pd.read_csv(fileName)
        # adiciona coluna no dicionario
        dict_from_csv['ntuser']= 'vinicius'
        
        #ENVIANDO AO BROKER
        try:
            SendMensage(dict_from_csv.to_dict("records"))
            print("foi")
        except:
            print("Não foi")

        #adiciona o dicionario em  uma lista
#        lista.append(dict_from_csv.to_dict("records"))
        
        # remove o arquivo
        os.remove(fileName)
    
    
    # adiciona a lista no data frame

    
    time.sleep(1)
    print("Foi um ciclo")


