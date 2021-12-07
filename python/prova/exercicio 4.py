# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 14:46:45 2021

@author: DISRCT
"""
lista1 = []
lista2 = []
lista3 = []
lista = ["1_palmeiras","2_curitiba","1_corintians","3_juventude","2_fluminense","3_bahia","1_cuiaba","2_cascavel","3_ ponte preta","2_parana clube","3_volta redonda"]
for aux in lista:
	x = aux.split('_')
	if x[0] == '1':
		lista1.append(x[1])
	elif x[0] == '2':
		lista2.append(x[1])
	elif x[0] =="3":
		lista3.append(x[1])
		
print(f"Primeira divisão:", lista1)
print(f"Segunda divisão:",lista2)
print(f"Terceira divisão:" ,lista3)