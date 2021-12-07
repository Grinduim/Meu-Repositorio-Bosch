# -*- coding: utf-8 -*-
"""
Created on Mon Aug 30 13:41:28 2021

@author: Vinicius Gribel 
"""
# 
'''a = 0
for i in range(15):
	print('for: ', i)
	while(a < 10):
		print('While: ', a)
		if(a == 4):
			print('entrou no if')
			break
		a += 1 '''
		
'''a = 0 
while(a <10):
	if(a == 5):
		print('executou continue')
		a += 1
		continue
	print(a)
	a += 1'''
	
'''lista = ['João', 'Maria' , 'Algeu', "antonio"]
for i in lista:
	if( i == 'Algeu'):
		continue
	print(i)'''
	
'''lista = ['João' ,"maria", "algeu", ['carla', 'jose'],'Antonio']
for i in lista:
	if( i == ['carla', 'jose']):
		continue
	print(i)'''
	
'''lista = ['João' ,"maria", "algeu", ['carla', 'jose'],'Antonio']
for i  in lista:
	if i == ['carla', 'jose']:
		for sublista in i:
			if sublista == 'Carla':
				continue
			print('Sublista: ' +sublista)
		continue
	print(i)'''

#exercico 1 

'''num1 = 0
lista = []
mult = 0
a = 1
while num1 > -1:
	
	num1 = int(input("Insira o {}º numero: " .format(a)))
	a = a+1
	if num1 <= -1:
		print(f' VocÊ inseriu {mult} multiplos de 10')	
		print(f'Sendo eles : {lista}') 
		break
	else: 
		if num1 %10 == 0 :
			mult = mult + 1 
			lista.append(num1)'''
				
#exercicio 2 
'''lista1 = []
lista2 = []
lista3 = []
a = 1
for i in range(10):
	lista1.append(int(input(f'Insira o {a}º da lista 1: ')))
	a += 1
a = 1 
for c in range(10):
	 
	lista2.append(int(input(f'Insira o {a}º da lista 2: ')))
	a = a + 1 
for b in range(10):
	lista3.append(lista1[b])
	lista3.append(lista2[b])
print(lista3)'''

#exercicio 3
cor1 = '\033[34m'
cor2 = '\033[35m'
altura = []
idade = []
x = 1
# contador de  alunos com mais de 13 com tamanho inferior a média
h = 0

for a in range(3):
	idade.append(float(input('Digite a idade da {}ª pessoa ' .format(x))))
	altura.append(float(input('Digite a altura da {}ª pessoa ' .format(x))))	
	x = x+1
#media de altura
mediah = (sum(altura))/3
for b in range(3):
	if altura[b] < mediah:
		if idade[b] > 13:
			h = h+1
print(f'{cor1}{h} tem altura inferiro a media e {cor2}tem mais de 13, A média é de {mediah}')
	
	
		
	

	