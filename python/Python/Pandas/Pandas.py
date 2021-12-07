# -*- coding: utf-8 -*-
"""
Created on Fri Sep 10 13:51:31 2021

@author: Luis Hamilton
"""

##########EXERCíCIO 1 -  NOME, TELEFONE, IDADE (criei em um csv)

##########EXERCÍCIO 2 -  ORDENAR PELA 3 IDADES MAIS FREQUENTES
'''
import pandas as pd

salve = pd.read_csv('salve.csv', index_col='ID')

print(salve['IDADE'].value_counts().head(3))
'''




##########EXERCÍCIO 3 -  NOME, IP: ORDERNAR POR IP (bugado)
'''
import pandas as pd
exer3 = pd.read_csv('exer3.csv', index_col='id')
print(exer3.sort_values(by='ip'))
'''




##########EXERCÍCIO 4 - NOME, IDADE: MÉDIA DE IDADES
'''
import pandas as pd
salve = pd.read_csv('salve.csv', index_col='ID')
print(salve['IDADE'].mean())
'''




##########EXERCÍCIO 5 - MÚSICA, ANO - PRINT MAIOR QUE A MÉDIA DE ANO
'''
import pandas as pd
df = {'nome': [], 'ano': []}
while True:
    df['nome'].append(input('Digite o título da música: '))
    df['ano'].append(int(input('Digite o ano de lançamento: ')))
    decision = input('Deseja inserir mais músicas?(s/n): ')
    if decision == 'n':
        break
    elif decision == 's':
        continue
var = pd.DataFrame(df)
var.to_csv('musica.csv')
csv = pd.read_csv('musica.csv', usecols=['nome', 'ano'])
media = csv['ano'].mean()
print(csv.loc[csv['ano'] > media])
'''




##########EXERCÍCIO 6 - MAIOR QUE METADE DO CSV
'''
import pandas as pd
csv = pd.read_csv('salve.csv')
metade = csv['ID'].mean()
print(csv.loc[csv['ID'] > metade])
'''




#########EXERCíCIO 7 - VENDAS 2020

import pandas as pd

df= {'valor': [], 'qtd': [], 'data': []}
while True:
    df['valor'].append(input('Digite o valor da venda: '))
    df['qtd'].append(int(input('Digite a quantidade de produtos vendidos: ')))
    df['data'].append(int(input('Digite a data da venda: ')))
    decision = input('Você quer inserir mais vendas?(s/n): ')
    if decision == 'n':
        break
    elif decision == 's':
        continue
var = pd.DataFrame(df)
var.to_csv('vendas.csv')
csv = pd.read_csv('vendas.csv', usecols=['valor', 'qtd', 'data'])
print(csv.loc[csv['data'] > 2019])