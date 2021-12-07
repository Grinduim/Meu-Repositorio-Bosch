# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 14:26:32 2021

@author: DISRCT
"""
dic = {'ngols': [], "nome": [], "qtp": []} 
jogador = input('Qual o nome do jogador ? ')
part = int(input("Qual o numero de partidas que ele jogou ? "))
dic["nome"].append(jogador)
dic["qtp"].append(part)
for i in range(part):
	gols = int(input(f'O jogador {jogador} fez quantos gols na {i + 1 }º partida ? '))
	dic['ngols'].append(gols)
dic["nome"].append(jogador)
dic["qtp"].append(part)
print(dic)