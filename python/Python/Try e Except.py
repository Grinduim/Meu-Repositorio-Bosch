# -*- coding: utf-8 -*-
"""
Created on Thu Sep  2 15:06:31 2021

@author: Luis Hamilton Balem
"""

##########EXEMPLO PROFESSOR
'''
try:
    print(5/0)
except NameError:
    print('Erro: caracter inválido!')
except ZeroDivisionError:
    print('Erro: divisão por zero!')
except Exception:
    print('Erro inesperado!')
finally:
    print('fechar arquivo')
'''
'''
try:
    print(5/0)
except Exception as erro:
    print('unexpected error', erro)
finally:
    print('fechar arquivo')
'''




##########EXERCÍCIO 1 - ERRO DNA
'''
def function(dna):
    lista = []
    for nuc in dna:
        try:
            if nuc == 'G':
                lista.append('C')
            elif nuc == 'C':
                lista.append('G')
            elif nuc == 'T':
                lista.append('A')
            elif nuc == 'A':
                lista.append('U')
            else:
                carlos = 5 / 0
                print(carlos)
        except Exception:
            lista = ['ERRO, CARACTERES INVÁLIDOS']
    return lista
a = []
for i in range(5):
    a.append(input(f'Digite o {i + 1}° nucleotídeo do DNA: '))
rna = function(a)
print('\nOs seus complementares em um RNA são: ', rna)
'''




##########EXERCÍCIO 2 - ERRO CALCULADORA
'''
def functionA(arg1, arg2):
    total = arg1 + arg2
    print(f'\nThe sum total between {arg1} and {arg2} is equal to: {total}')
def functionS(arg1, arg2):
    total = arg1 - arg2
    print(f'\nThe subtraction between {arg1} and {arg2} is equal to: {total}')
def functionM(arg1, arg2):
    total = arg1 * arg2
    print(f'\nThe multiplication between {arg1} and {arg2} is equal to: {total}')
def functionD(arg1, arg2):
    try:
        total = arg1 / arg2
        print(f'\nThe division between {arg1} and {arg2} is equal to: {total}')
    except ZeroDivisionError:
        print('\nImpossible to divide by zero')
try:
    n1 = float(input('\nType the first number: '))
    n2 = float(input('\nType the second number: '))
    oper = input('\nType which math operation you wanna do: ')
    if oper == 'sum':
        functionA(n1, n2)
    elif oper == 'subtraction':
        functionS(n1, n2)
    elif oper == 'multiplication':
        functionM(n1, n2)
    elif oper == 'division':
        functionD(n1, n2)
    else:
        print('Invalid Operation')
except ValueError:
    print('\nInvalid Character')
'''