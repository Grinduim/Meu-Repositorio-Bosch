# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 13:50:45 2021

@author: DISRCT
21
10"""

# Prova Bosch
# Exercicio 1 

import math
def  bhask (a,b,c):
	math.sqrt
	x1 = 0
	x2 = 0  
	delta = (b**2) - (4 * a * c)
	if delta > 0: 
		x1 = (-b  + math.sqrt(delta)) /(2* a) 
		x2 = (-b - math.sqrt(delta))/(2 * a)
		return ' Os resultados das raizes respectivamente são {} e {}' .format(x1, x2)
	if delta == 0: 
		x1 = (-b  + math.sqrt(delta)) /(2 * a) 
		return " A raiz é {}" .format(x1)
	if delta < 0:
		return " não há raizes"
	
n1 = int(input("Digite o valor de A "))
n2 = int(input("Digite o valor de B "))
n3 = int(input("Digite o valor de C "))
func = bhask(n1,n2,n3)
print(func)