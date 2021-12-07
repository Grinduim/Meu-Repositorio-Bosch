# -*- coding: utf-8 -*-
"""
Created on Mon Nov 29 15:55:55 2021

@author: DISRCT
"""
#PARTE !
# import pandas as pd

# df = pd.read_csv('datas.csv')

# country = []
# year = []
# #row = linha
# for row in range(len(df)):
#     #index das letras
#     index = 0
#     # estou pegando o texto da linha row coluna= 6
#     text = df.iloc[row,6]
#     #percorrer o char na frase
#     for char in text:
#         # COmos segue um padrão eu posso apenas  ler até quando o char for numerico, parar e adicionar ele as listas
        
#         if(char.isnumeric() == True):
#             country.append(text[:index])
#             year.append(text[index:])
#             break
#         index = index +1

# #excluindo a coluna
# del df["country-year"]
# del df["HDI for year"]
# #adicionando as colunas
# df.insert(6,"Country",country,True)
# df.insert(7,"Year",year,True)

# df = df.loc[ (df['Year'] >= '1987') & (df['Country'] == "Brazil") & (df["generation"]=="Boomers")]

import pip
pip.main(["install","matplotlib"])
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt

#abrindo todos DF

df = pd.read_csv('datas.csv')
''' Setar todos os data frames e percorrer eles '''

#Filtrando o DataFrame com as gerações que preciso
GenX = df.loc[df["generation"] == "Generation X"]
Silent = df.loc[df["generation"] == "Silent"]
GIGen = df.loc[df["generation"] == "G.I. Generation"]
Boomers = df.loc[df["generation"] == "Boomers"]
Milleniais = df.loc[df["generation"] == "Millenials"]
Genz = df.loc[df["generation"] == "Generation Z"]

#declarando valores para nao esquercer
MGenX = 0
MSilent = 0
MGIGen = 0
MBooomers = 0
MMillenials = 0
MGenz = 0

FGenX = 0
FSilent = 0
FGIGen = 0
FBooomers = 0
FMillenials = 0
FGenz = 0

# Lista para adicionar valores 
Masc = []
Fem = []
#passando item por item em na coluna sexo e verificando se é M ou F
for row in range(len(GenX)):
         sexo = GenX.iloc[row,1]
         if(sexo == "male"):
             MGenX= MGenX + 1
         else:
             FGenX = FGenX +1
 
Masc.append(MGenX)
Fem.append(FGenX)

for row in range(len(Silent)):
         sexo = Silent.iloc[row,1]
         if(sexo == "male"):
             MSilent= MSilent + 1
         else:
             FSilent = FSilent +1
 
Masc.append(MSilent)
Fem.append(FSilent)  
 
for row in range(len(GIGen)):
         sexo = GIGen.iloc[row,1]
         if(sexo == "male"):
             MGIGen= MGIGen + 1
         else:
             FGIGen = FGIGen +1
             
Masc.append(MGIGen)
Fem.append(FGIGen)  
         
for row in range(len(Boomers)):
         sexo = Boomers.iloc[row,1]
         if(sexo == "male"):
             MBooomers= MBooomers + 1
         else:
             FBooomers = FBooomers +1
             
Masc.append(MBooomers)
Fem.append(FBooomers)  
             
for row in range(len(Milleniais)):
         sexo = Milleniais.iloc[row,1]
         if(sexo == "male"):
             MMillenials= MMillenials + 1
         else:
             FMillenials = FMillenials +1
             
Masc.append(MMillenials)
Fem.append(FMillenials)  
             
for row in range(len(Genz)):
         sexo = Genz.iloc[row,1]
         if(sexo == "male"):
             MGenz= MGenz + 1
         else:
             FGenz = FGenz +1
             
Masc.append(MGenz)
Fem.append(FGenz)  

barWidth = 0.25
plt.figure(figsize =(10,5))

r1 = np.arange(len(Masc))
r2 = [x+ barWidth for x in r1]

plt.bar(r1,Masc, color = '#6A5ACD', width = barWidth, label = "Masculino")
plt.bar(r2,Fem, color = '#6A95ED', width = barWidth, label = "feminino")           

plt.xlabel('Gen')
plt.xticks([ r + barWidth for r in range(len(Masc))], ['Gen X', 'Silent', 'G.I Gen', 'Boomers',"Millenais", 'Gen Z'])
plt.ylabel('Count')

plt.legend()
plt.show()