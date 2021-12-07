# -*- coding: utf-8 -*-
"""
Created on Mon Nov 29 13:35:31 2021

@author: Vinicius 
"""

# 03.Faça um programa que leia e valide as seguintes informações:
# Nome: maior que 3 caracteres;
# Idade: entre 0 e 150;
# Salário: maior que zero;
# Sexo: 'f' ou 'm';
# Estado Civil: 's', 'c', 'v', 'd';
# Use a função len(string) para saber o tamanho de um texto (número de caracteres).


# nome = input("Qual o seu nome ?  Insira um nome com mais de 3 caracteres: ")

# idade = int(input("\nQual a sua idade ? "))

# salario = float(input("\n Qual o seu salário ? "))

# sexo = input("\nQual seu Sexo ? M ou F ?")

# estado = input("\n Qual o seu estado civil ?\n[S] para Solteiro \n[C] Para Casado\n[V] para Viuvo \n[D] para divorciado\n")


# while len(nome) <= 3:
#     nome = input("\nNome invalido! Insira o seu nome,  Ele deve ter mais de 3 caracteres!") 
# print("\nNome Valido")

# while (idade < 0) or (idade > 150):
#     idade = int(input("\n Idade invalida. Insira uma idade valida, insira um valor entre 0 e 150 "))
# print("\n Idade Valida")

# while salario < 0:
#     salario = float(input("\nSalario invalido. Insira um salario superior a R$0 (zero reais) "))
# print("\nSalário Valido!")

# while (sexo != 'M') and (sexo != 'F') and (sexo != 'm') and (sexo != 'f') :
#     sexo = input("\nSexo Invalido, por favor inseira um sexo valido: M ou F ")
# print("\nSexo Valido")

# while (estado !='S') and  (estado !='C') and (estado !='V') and (estado !='D') and (estado !='s') and  (estado !='c') and (estado !='v') and (estado !='d') :
#     estado = input("\n Estado Civil invalido! Por favor tente novamente\n[S] para Solteiro \n[C] Para Casado\n[V] para Viuvo \n[D] para divorciado\n")
#     estado.upper
# print("Estado Valido")


# qtd = int(input("Insira a quantidade de Valores que deseja inserir: "))

# lista =[]
# for i in range(qtd):
#     lista.append(input(f"\nInsira o {i+1}º valor:  "))
    
# print("\nComputando valores: ")
    
# for i in lista:
#     print(f" O {i} está na {lista.index(i)+1}º posição")
    

import pandas as pd
import numpy as np
from matplotlib import pyplot as plot

df = pd.read_csv('movies.csv')
df = df.loc[df['Year']>= 2010]
print(df);
ax = df.plot.bar(x ='Genre', y = 'Year')
plot.show(ax)


    