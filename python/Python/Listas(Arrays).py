# -*- coding: utf-8 -*-
"""
Created on Thu Aug 26 15:01:39 2021

@author: Luis Hamilton
"""

##########EXERCÍCIO 1
'''pesop = input("Digite o peso das 5 pessoas: ")
P1 = float(pesop.split()[0])
P2 = float(pesop.split()[1])
P3 = float(pesop.split()[2])
P4 = float(pesop.split()[3])
P5 = float(pesop.split()[4])
lista = [P1, P2, P3, P4, P5]
lista.sort()
print("A pessoa com mais peso tem: ", lista[4], "quilos")'''




##########EXERCÍCIO 2
'''numA = input("Digite 5 valores para a lista A: ")
A1 = int(numA.split()[0])
A2 = int(numA.split()[1])
A3 = int(numA.split()[2])
A4 = int(numA.split()[3])
A5 = int(numA.split()[4])
numB = input("Digite 5 valores para a lista B: ")
B1 = int(numB.split()[0])
B2 = int(numB.split()[1])
B3 = int(numB.split()[2])
B4 = int(numB.split()[3])
B5 = int(numB.split()[4])
listaA = [A1, A2, A3, A4, A5]
listaB = [B1, B2, B3, B4, B5]
listaC = listaA + listaB
print("\n", listaC)
remove = int(input("Digite o item que deseja remover: "))
ind = listaC.index(remove)
listaC.pop(ind)
print("\n", listaC)'''




##########EXERCÍCIO 3
'''lista = [6, 2, 9, 4, 1, 7, 3, 8, 0, 5]
print(lista)
lista.sort()
lista.pop(0)
print(lista)'''




##########EXERCÍCIO 4
'''lista = ["Jorge", "Rodolfo", 41998765432, 41912345678, 35, 52]
print(lista)
lista.pop(0) and lista.pop(0)
print(lista)'''




##########EXERCÍCIO 5
'''lista = [[5,2,1,4,3], ["Melissa", "Carlos", "Bruno", "João", "Alexandre"]]
print(lista)
lista[0].sort()
lista[1].sort()
print(lista)'''




##########EXERCÍCIO 6
'''lista = [765, 534, 6574, 3546, 245]
print(lista)
remove = int(input("Digite um item para ser removido: "))
ind = lista.index(remove)
lista.pop(ind)
print(lista)
add = int(input("Digite um novo item para adicionar: "))
lista.insert(ind, add)
print(lista)'''




##########EXERCÍCIO 7
'''lista = [837, 72, 377, 28237, 7373, 9032, 26, 3737]
print(lista)
start = int(input("Digite a posição do item para ser o início do print: "))
print(lista[start:])'''




##########EXERCÍCIO 8
'''lista = [837, 72, 377, 28237, 7373, 9032, 26, 3737, 273, 15, 76, 837, 9817]
print(lista)
remove = int(input("Digite um item para ser removido: "))
ind = lista.index(remove)
lista.pop(ind)
print(lista)
remove2 = int(input("Digite mais um item para ser removido: "))
ind2 = lista.index(remove2)
lista.pop(ind2)
lista.sort()
print(lista)
imprimir = input("Digite a posição dos itens para ser o início e o final do print: ")
pr1 = int(imprimir.split()[0])
pr2 = int(imprimir.split()[1])
print(lista[pr1:pr2])'''