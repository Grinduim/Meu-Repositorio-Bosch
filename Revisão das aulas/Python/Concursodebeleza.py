# -*- coding: utf-8 -*-
"""
Created on Mon Dec 20 08:56:14 2021

@author: Vinicius

Criar um algoritimo para o  concursod e beleza de acordo com os dados fornecidos anterior mente 
"""

import pandas as pd
import matplotlib.pyplot as plt

#input dos dados de quantidade
tamm  = int(input("Quantos candidos masculinos você irá inserir? "))
tamf = int(input("Quantos Canditos femininos você irá inserir ?"))

#declaracao de listas e valores para count
nome = []
idade  = []
altura =  []
peso = []
resh = []
resid = []
reskg = []
final = []
aprov = 0
rep = 0

#input de dados para o homem
for i in range(0, tamm):
    nome.append(input(f"Insira o  {i+1}º nome do candidato  "))
    data = input(f"\nInsira a data de nascimento do {nome[i]}: ")
    data = data.split('/')
    idade.append( 2021 -int( data[2]))
    altura.append(float(input(f"\nInsira a altura do {nome[i]}  (Em metros) "  )))
    peso.append(float(input(f'Insira o peso do {nome[i]} ')))
    
#input dos dados para a mulheres
for i in range(0, tamf):
    nome.append(input(f"Insira o  {i+1}º nome da candidata  "))
    data = input(f"\nInsira a data de nascimento da {nome[i+tamm]}: ")
    data = data.split('/')
    idade.append( 2021 -int( data[2]))
    altura.append(float(input(f"\nInsira a altura da {nome[i+tamm]}   (Em metros)")))
    peso.append(float(input(f'Insira o peso da {nome[i+tamm]} ')))


#verificaao de dados dos homens
for i in range(0, tamm):
    if(idade[i] > 18 and idade[i] < 22):
        resid.append("V")
    else :
        resid.append('F')
    
    if(altura[i] == 170  or altura[i] == 1.70):
        resh.append('V')
    else:
        resh.append('F')
    
    if(peso[i] == 76):
        reskg.append("V")
    else :
        reskg.append("F")
        
    if(reskg[i]== 'F' or resh[i] == 'F' or resid[i] == 'F' ):
        final.append("F")
        #increvmentos de aprovado ou reprovado
        rep = rep + 1
    else:
        final.append("V")
        aprov = aprov +1 
        
#verificaao de de dados femininos
for i in range(tamm,tamf+tamm ):
     if(idade[i] > 16 and idade[i] < 20):
        resid.append("V")
     else:
        resid.append('F')
    
     if(altura[i] == 170  or altura[i] == 1.70):
        resh.append('V')
     else:
        resh.append('F')
    
     if(peso[i] == 70):
        reskg.append("V")
     else :
         reskg.append("F")
         
     if(reskg[i]== 'F' or resh[i] == 'F' or resid[i] == 'F' ):
         final.append("F")
        #incremento de aprovado ou reprovado
         rep = rep +1
     else:
         final.append("V")
         aprov = aprov + 1
        
# data Frame de aprovados ou reprovados
df = pd.DataFrame(list(zip(nome, idade, altura,peso,reskg,resid,resh,final)),
              columns=['NOME','IDADE', 'ALTURA','PESO','RESULTADO PESO','RESULTADO IDADE','RESULTADO ALTURA','RESUTADO FINAL'])

print(df)

#gerando o grafico
#lista com os valores
data = [ aprov, rep]
#tamanho da figura
fig = plt.figure(figsize = (10,7))
# gerando o grafico em si 
plt.pie(data, labels   = [ "APROVADOS", 'REPROVADOS'],autopct = '%1.1f%%')
plt.show()