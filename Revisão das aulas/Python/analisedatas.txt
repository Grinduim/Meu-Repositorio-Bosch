# -*- coding: utf-8 -*-
"""
Spyder Editor

Este é um arquivo de script temporário.
"""

import pandas as pd
import matplotlib.pyplot as plt
import matplotlib as mpl

#separando a os dados com /
df = pd.read_csv("exercicioedjalma.csv", sep="/", names=["Dia", "Mês", "Ano"])
count  = pd.DataFrame(df['Ano'].value_counts())
#agrupando os valores por ano com um contador

count =count.rename(columns = {'Ano': 'QTD'})
count.index.name = 'Ano'
#substituindo o nome das colunas
print(count.iloc[1])
maior = count.iloc[1,0]
#pegando a primeira linha do DataFrame, que é o q mais nasceu gente
count =count.sort_index()
#ordenando o count
print(count.iloc[1])
menor = count.iloc[1,0]
#pegando o  que menos nasceu gente

#definindo as caracrteristica do grafico
mpl.rcParams['lines.linewidth'] = 2
# tamanho da linha
mpl.rcParams['lines.linestyle'] = '--'
#estilo da linha
plt.style.use('dark_background')
#tema
plt.figure(figsize = (25,5))
#tamanho
plt.xlabel("Ano")
plt.ylabel("Quantidade")
data = count
plt.plot(data,)
#plotando ele

qtd = 0

#for para percorrer as colunas
for row in range(len(count)):
    qtd += count.iloc[row,0]
    
#output dos dados
print(f'A Quantidade total de nascidos registrados é de : {qtd}')
media = qtd/len(count)
print(f'A média por ano de nascimentos é de {media:.2f}/ano')
print(f'O recorde de nascidos em um ano é de {maior}')
print(f'A menor quantidade de nascido em um ano é de {menor}')

