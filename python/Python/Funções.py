# -*- coding: utf-8 -*-
"""
Created on Tue Aug 31 14:48:36 2021

@author: Luis Hamilton
"""

##########FUNÇÕES
'''
def teste(n):
    return n*2
def numepar(argumento1, agr2):
    func = teste(4)
    print(func)
    if(argumento1 % 2 == 0):
        return True
    else:
        return False
v1 = 2
v2 = 4
num = numepar(v1, v2)
print(num)
'''




##########EXERCÍCIO 1 - TABUADA
'''
def function(arg1):
    for i in range(11):
        num = arg1 * i
        print(num)
n1 = int(input("Digite um número: "))
function(n1)
'''




##########EXERCÍCIO 2 - OPERAÇÃO DO BANCO
'''
from time import sleep
def a(arg4):
    print("\nO SEU SALDO ATUAL É DE R$", arg4)
def b(arg, arg1):
    resultado = arg - arg1
    if resultado >= 0:
        print("\nSAQUE REALIZADO")
        return resultado
    print("\nSALDO INSUFICIENTE")
    return arg
def c(arg3, arg2):
    total = arg3 + arg2
    print("\nDEPÓSITO REALIZADO")
    return total
saldo = 0
pepino = 0
user = "Vinicius"
user2 = "Luis"
user3 = "Murilo"
user4 = "Bruno"
user5 = "Alexandre"
user6 = "Professor"
password = "Gribel"
password2 = "Hamilton"
password3 = "Henrique"
password4 = "Viotto"
password5 = "Wilian"
password6 = "Algeu"
login = input("\nDIGITE SEU NOME DE USUÁRIO: ")
lp = input("\nDIGITE SUA SENHA: ")
if login == user and lp == password or login == user2 and lp == password2:
    sleep(2)
    print("\nSEJA BEM VINDO AO BANCO HAMILTON S.A.")
    sleep(2)
    while pepino < 1:
        v1 = input("\nPARA CONSULTAR SALDO DIGITE 'a' \nPARA SAQUE DIGITE 'b' \nPARA DEPÓSITO DIGITE 'c' \nE PARA SAIR DIGITE 'd' \nQUAL OPERAÇÃO DESEJA FAZER: ")
        if v1 == "a":
            a(saldo)
        elif v1 == "b":
            saque = float(input("\nDIGITE O VALOR A SER SACADO: "))
            saldo = b(saldo, saque)
        elif v1 == "c":
            deposito = float(input("\nDIGITE O VALOR A SER DEPOSITADO: "))
            saldo = c(saldo, deposito)
        elif v1 == "d":
            print("\nOBRIGADO, VOLTE SEMPRE")
            break
        sleep(2)
elif login == user3 and lp == password3 or login == user4 and lp == password4:
    sleep(2)
    print("\nSEJA BEM VINDO AO BANCO HAMILTON S.A.")
    sleep(2)
    while pepino < 1:
        v1 = input("\nPARA CONSULTAR SALDO DIGITE 'a' \nPARA SAQUE DIGITE 'b' \nPARA DEPÓSITO DIGITE 'c' \nE PARA SAIR DIGITE 'd' \nQUAL OPERAÇÃO DESEJA FAZER: ")
        if v1 == "a":
            a(saldo)
        elif v1 == "b":
            saque = float(input("\nDIGITE O VALOR A SER SACADO: "))
            saldo = b(saldo, saque)
        elif v1 == "c":
            deposito = float(input("\nDIGITE O VALOR A SER DEPOSITADO: "))
            saldo = c(saldo, deposito)
        elif v1 == "d":
            print("\nOBRIGADO, VOLTE SEMPRE")
            break
        sleep(2)
elif login == user5 and lp == password5 or login == user6 and lp == password6:
    sleep(2)
    print("\nSEJA BEM VINDO AO BANCO HAMILTON S.A.")
    sleep(2)
    while pepino < 1:
        v1 = input("\nPARA CONSULTAR SALDO DIGITE 'a' \nPARA SAQUE DIGITE 'b' \nPARA DEPÓSITO DIGITE 'c' \nE PARA SAIR DIGITE 'd' \nQUAL OPERAÇÃO DESEJA FAZER: ")
        if v1 == "a":
            a(saldo)
        elif v1 == "b":
            saque = float(input("\nDIGITE O VALOR A SER SACADO: "))
            saldo = b(saldo, saque)
        elif v1 == "c":
            deposito = float(input("\nDIGITE O VALOR A SER DEPOSITADO: "))
            saldo = c(saldo, deposito)
        elif v1 == "d":
            print("\nOBRIGADO, VOLTE SEMPRE")
            break
        sleep(2)
else:
    print("\nUSUÁRIO OU SENHA INVÁLIDO(S)")
'''




##########EXERCÍCIO 3 - CALCULADORA
'''
def functionA(arg1, arg2):
    total = arg1 + arg2
    print(f"\nA soma entre {arg1} e {arg2} é igual a: {total}")
def functionS(arg1, arg2):
    total = arg1 - arg2
    print(f"\nA subtração entre {arg1} e {arg2} é igual a: {total}")
def functionM(arg1, arg2):
    total = arg1 * arg2
    print(f"\nA multiplicação entre {arg1} e {arg2} é igual a: {total}")
def functionD(arg1, arg2):
    total = arg1 / arg2
    print(f"\nA divisão entre {arg1} e {arg2} é igual a: {total}")
pepino = 0
while pepino < 1:
    n1 = float(input("\nDigite o primeiro número: "))
    n2 = float(input("\nDigite o segundo número: "))
    oper = input("\nDigite qual operação deseja fazer: ")
    if oper == "soma":
        functionA(n1, n2)
    elif oper == "subtração":
        functionS(n1, n2)
    elif oper == "multiplicação":
        functionM(n1, n2)
    elif oper == "divisão":
        functionD(n1, n2)
'''




##########EXERCÍCIO 4 - LISTA INVERSA
'''
def function(lista):
    reverter =[]
    for i in range(8):
        var = lista[7 - i]
        reverter.append(var)
        i += 1
    return reverter
lista =[]
for i in range(8):
    lista.append(int(input("Digite um número: ")))
inverso = function(lista)
print("A lista inversa é: ", inverso)
'''




##########EXERCÍCIO 5 - ÁREA DE PI
'''
import math
def function(arg1):
    a = math.pi * arg1 ** 2
    return a
raio = float(input("Digite o valor do raio: "))
result = function(raio)
print("O valor da área é: %0.2f" % result)
'''




##########EXERCÍCIO 6 - CADEIA DE DNA
'''
def function(dna):
    lista = []
    for nuc in dna:
        if nuc == "G":
            lista.append("C")
        elif nuc == "C":
            lista.append("G")
        elif nuc == "T":
            lista.append("A")
        elif nuc == "A":
            lista.append("U")
    return lista
a = []
for i in range(5):
    a.append(input(f"Digite o {i + 1}° nucleotídeo do DNA: "))
rna = function(a)
print("\nOs seus complementares em um RNA são: ", rna)
'''




##########EXERCÍCIO 7 - BHASKARA
'''
import math
def function(a, b, c):
    resultA = (-b - math.sqrt((b ** 2) - 4 * a * c)) / (2 * a)
    resultB = (-b + math.sqrt((b ** 2) - 4 * a * c)) / (2 * a)
    lista = [resultA, resultB]
    return lista
a = float(input("Digite quantos X ao quadrado estão na equação: "))
b = float(input("Digite quantos X estão na equação: "))
c = float(input("Digite o último número da equação: "))
result = function(a, b, c)
print("As raízes da equação são: ", result)
'''




##########EXERCÍCIO 8 - ANAGRAMA
'''
def function(a, b):
    listaA = []
    listaB = []
    for x in a:
        listaA.append(x)
        listaA.sort()
    for y in b:
        listaB.append(y)
        listaB.sort()
    if listaA == listaB:
        boolean = True
    else:
        boolean = False
    return boolean
string1 = input("Digite a primeira palavra: ")
string2 = input("Digite a segunda palavra: ")
var = function(string1, string2)
if var == True:
    print("\nAs 2 palavras são anagramas")
elif var == False:
    print("\nAs 2 palavras NÃO são anagramas")
'''




##########EXERCÍCIO 9 - ENDEREÇO IPV4
'''
def function():
    ip = input("Digite o endereço IPV4: ")
    pp = ip.split(".")
    a = 0
    if len(ip) >= 7 and len(ip) <= 16:
        for i in pp:
            if i.isnumeric():
                if int(i) >= 0 and int(i) <= 255:
                    if a == 3:
                        return True
                    else:
                        a += 1
                else:
                    return False
            else:
                return False
verify = function()
if verify == True:
    print("IP Válido")
else:
    print("IP Inválido")
'''




##########EXERCÍCIO 10 - FATORIAL
'''
def function(a):
    fator = 1
    vezes = 0
    for i in range(a):
        vezes = (a - i)
        fator = fator * vezes
    return fator
num = int(input("Digite um número: "))
x = function(num)
print("O fatorial de %i é igual a: %i" % (num, x))
'''




##########EXERCÍCIO 11 - DATA SEM SPLIT (incompleto)
'''
def function(arg1):
    mes =["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"]
    if int(arg1[:2]) < 1 and int(arg1[:2]) > 31:
        return False
    if int(arg1[3:5]) < 1 and int(arg1[3:5]) > 12:
        return False
    x = f"{int(data[:2])} de {mes[int(data[3:5])- 1]} de  {int(data[6:10])}"
    return x
data = input("Digite a data: ")
var = function(data)
print(var)
'''