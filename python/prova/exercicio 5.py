# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 14:55:23 2021

@author: DISRCT
"""
import random
pedra = 1 
papel = 2 
tesoura = 3
x = 5
while x == 5:
	op = int(input(" escolha sua jogada : \n 1 para pedra \n 2 para papel \n 3 para tesoura \n R:"))
	pc = random.randint(1,3)
	if op == 1:
		op = pedra
	elif op == 2:
		op = papel
	elif op == 3:
		op = pedra
	else:
		print("valor invalido, por favor digite novamente")
		continue
	if op == 1:
		op = "pedra"
	elif op == 2:
		op = "papel"
	elif op == 3:
		op = "pedra"
	if pc == 1:
		pc = "pedra"
	elif pc == 2:
		pc = "papel"
	elif pc == 3:
		pc = "pedra"
	if pc == op:
		print(f"Empate, a maquina jogou {pc}")
	elif pc =="pedra":
		if op == 'papel':
			print(f"Você ganhor! a maquina jogou {pc}")
		elif op =="tesoura":
			print(f"VocÊ perdeu! a maquina jogou{pc}")
	elif pc =="papel":
		if op == 'pedra':
			print(f"Você perdeu! a maquina jogou {pc}")
		elif op =="tesoura":
			print(f"VocÊ ganhou! a maquina jogou{pc}")
	elif pc =="tesoura":
		if op == 'pedra':
			print(f"Você ganhou! a maquina jogou {pc}")
		elif op =="papel":
			print(f"VocÊ perdeu! a maquina jogou{pc}")
	
	while x == 5:
		cond = int(input("Você quer continuar jogando ? 1 para sim 0 para não \n R: "))
		if cond == 0 or cond == 1:
			if cond == 1:
				break
			else:
				print(" encerrando o jogo")
				x = 1
		else:
			print(" Digito errado, por favor insira novamente")
	