# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 15:15:24 2021

@author: DISRCT
"""

arq = open("alunos.txt", "r+")
x = 0
while True:
	nome = input("Insira o nome do aluno a ser cadastrado: ")
	curso = input("\nInsira o curso do aluno: ")
	matri = input("\ninsira a matricula do aluno: ")
	if x == 0:
		arq.write(f"{nome},{curso},{matri}")
		print("\n Cadastro realizado")
	else:
		arq.write(f"\n{nome},{curso},{matri}")
		print("Cadastro realizado")
	x += 1 
	print(f" você já inseriu {x} aluno")
	cond = input(" Você quer inserir mais alunos ? [S/N] ").strip().upper()
	if cond == "S" or cond =="N":
		if cond == "S":
			continue
		if cond == "N":
			print(f"Ao todo você inseriu {x}" )
			print("encerrando registros")
			arq.close()
			break 