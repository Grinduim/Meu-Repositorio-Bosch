# -*- coding: utf-8 -*-
"""
Created on Fri Aug 27 13:47:09 2021

@author: Luis Hamilton
"""

##########EXEMPLO SINTAXE WHILE
'''
numero = 0
while numero < 10:
    print("Execute ação")
    print("outra ação")
'''
##########ENCERRAR LOOP WHILE
'''
numero = 0
while numero < 10:
    print("oi")
    numero = numero + 1
'''
##########OU
'''
numero = 0
while numero < 10:
    print("oi")
    numero += 1
'''
##########EXEMPLO SINTAXE FOR
'''
cesta_de_frutas = ["Maçã", "Laranja", "Uva", "Melancia"]
for fruta in cesta_de_frutas:
    print(fruta)
'''
##########RANGE
'''
palavra = ""       #MIN, MAX, STEP
for iterador in range(4, 20, 3):
    print(iterador)
'''




##########EXERCÍCIO 1
##########WHILE
'''
lupi = 0
soma = 0
while lupi < 5:
    num = int(input("Digite um número: "))
    soma = soma + num
    lupi += 1
print("\nA soma dos 5 números é: %0.1f" % soma)
'''
##########FOR
'''
soma = 0
for laco in range(5):
    num = int(input("Digite um número: "))
    soma = soma + num
print("A soma dos 5 números é: %0.1f" % soma)
'''




##########EXERCÍCIO 2
##########WHILE
'''
lupi = 0
lista = []
while lupi < 10:
    lista.append(int(input("Digite um número: ")))
    lupi += 1
lista.sort()
print("\nMenor número: ",lista[0], "\nMaior número: ",lista[9])
'''
##########FOR
'''
lista = []
for laco in range(10):
    lista.append(int(input("Digite um número: ")))
lista.sort()
print("\nMenor número: ",lista[0], "\nMaior número: ",lista[9])
'''




##########EXERCÍCIO 3
##########WHILE
'''
lupi = 1000
while lupi < 2000:
    print(lupi)
    lupi += 1
'''
##########FOR
'''
for laco in range(1000, 2000):
    print(laco)
'''




##########EXERCÍCIO 4
##########WHILE
'''
numerop = 0
numeroi = 0
num = 0
while num <= 1000:
    num = int(input("Digite um número: "))
    if num <= 1000:
        if num % 2 == 0:
            numerop = numerop + num
        else:
            numeroi = numeroi + num
print("\nA soma de todos os números pares é: %i \nA soma de todos os números ímpares é: %i" % (numerop, numeroi))
'''
##########FOR
'''
impossível
'''





##########EXERCÍCIO 5
##########WHILE
'''
listaP = []
listaI = []
num = 0
while num < 10:
    var = int(input("Digite um número: "))
    if var % 2 == 0:
        listaP.append(var)
    else:
        listaI.append(var)
    num += 1
print("\nLista dos pares: ", listaP[0:])
print("\nLista dos ímpares: ", listaI[0:])
'''
##########FOR
'''
listaP = []
listaI = []
for laco in range(10):
    var = int(input("Digite um número: "))
    if var % 2 == 0:
        listaP.append(var)
    else:
        listaI.append(var)
print("\nLista dos pares: ", listaP[0:])
print("\nLista dos ímpares: ", listaI[0:])
'''




##########EXERCÍCIO 6
##########WHILE
'''
countdown = 0
countdown2 = 0
lista = []
while countdown < 8:
     lista.append(int(input("Digite um número: ")))
     countdown += 1
while countdown2 < 8:
    print(lista[7 - countdown2])
    countdown2 += 1
'''
##########FOR
'''
lista = []
laco2 = 0
for laco in range(8):
    lista.append(int(input("Digite um número: ")))
for laco2 in range(8):
    print(lista[7 - laco2])
'''




##########EXERCÍCIO 7
##########WHILE
'''
countdown = 0
lista = []
while countdown < 8:
    num = int(input("Digite um número: "))
    if num < 0:
        num = 0
        lista.append(num)
    else:
        lista.append(num)
    countdown += 1
print(lista[0:])
'''
##########FOR
'''
lista = []
for laco in range(8):
    num = int(input("Digite um número: "))
    if num < 0:
        num = 0
        lista.append(num)
    else:
        lista.append(num)
print(lista[0:])
'''




##########EXERCÍCIO 8
##########WHILE
'''
countdown = 0
var = int(input("Digite um número: "))
while countdown < 11:
    total = var * countdown
    print(var, "vezes", countdown, "igual a:", total)
    countdown += 1
'''
##########FOR
'''
laco = 0
var = int(input("Digite um número: "))
for laco in range(11):
    total = var * laco
    print(var, "vezes", laco, "igual a:", total)
'''




##########EXERCÍCIO 9
##########WHILE
'''
numero = 0
nums = ["x"]
numerolis = "x"
while numero != numerolis:
    numero = int(input("Digite um número: "))
    numerolis = nums[0]
    nums.insert(0, numero)
ind = nums.index("x")
nums.pop(ind)
last = nums[-1]
nums.pop(last)
print(sum(nums))
'''
##########EXEMPLO PROFESSOR
'''
nums = []
saoIguais = False
i = 0
while(not saoIguais):
    nums.append(int(input("Digite um número: ")))
    if(len(nums) > 1):
        if(nums[i] == nums[i-1]):
            saoIguais = True
    i += 1
if(saoIguais):
    print("São Iguais")
'''
##########FOR
'''
impossible
'''




##########EXEMPLO BREAK
'''
a = 0
for i in range(15):
    print("for: ", i)
    while(a < 10):
        print("while: ", a)
        if(a == 4):
            print("entrou no if")
            break
        a += 1
'''
##########EXEMPLO CONTINUE
'''
a = 0
while(a < 10):
    if(a == 5):
        print("executou continue")
        a += 1
        continue
    print(a)
    a += 1
'''
#########EXEMPLO 2
'''
lista = ["João", "Maria", "Algeu", ["Carla", "José"], "Antonio"]
for i in lista:
    if(i == "Carla"):
        continue
    print(i)
'''

'''
lista = ["João", "Maria", "Algeu", ["Carla", "José"], "Antonio"]
for i in lista:
    for sublista in i:
        if(sublista == "Carla"):
            continue
        print("Sublista: " + sublista)
'''    

'''
lista = ["João", "Maria", "Algeu", ["Carla", "José"], "Antonio"]
for i in lista:
    if(i == ["Carla", "Jose"]):
        for sublista in i:
            if(sublista == "Carla"):
                continue
            print(sublista)
        continue
    print(i)
'''
    
    
    
    
    
##########EXERCÍCIO 1 - ESTUDAR(FOTO)
'''
lista = []
listaM = []
num = 0
while num >= 0:
    num = int(input("Digite um número: "))
    if num < 0:
        break
    if num % 10 == 0:
        listaM.append(num)
    else:
        lista.append(num)
print("\nOs números múltiplos de 10 dessa lista são: ", listaM)
print("\nOs números que não são múltiplos são: ", lista)
'''




##########EXERCÍCIO 2
'''
lista1 =[]
lista2 =[]
lista3 =[]
for lium in range(10):
    lista1.append(int(input(f"Digite o {lium + 1}° número para a primeira lista: ")))
for lidois in range(10):
    lista2.append(int(input(f"Digite o {lidois + 1}° número para a segunda lista: ")))
for vini in range(10):
    lista3.append(lista1[vini])
    lista3.append(lista2[vini])
print(lista3)
'''




##########EXERCÍCIO 3
'''
lista =[]
lista2 =[]
resultado = 0
for a in range(4):
    lista.append(int(input(f"\nDigite a idade do {a + 1}° aluno: ")))
    lista2.append(float(input(f"\nDigite a altura do {a + 1}° aluno: ")))
mediah = sum(lista2) / 4
for i in range(4):
    if lista[i] > 13:
        if lista2[i] < mediah:
            resultado += 1
print(resultado, "\nalunos são maiores de 13 anos e sua altura é menor do que a média")
'''