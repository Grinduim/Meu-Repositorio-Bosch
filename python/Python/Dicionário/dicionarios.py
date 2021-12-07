# -*- coding: utf-8 -*-
"""
Created on Thu Sep  9 13:57:19 2021

@author: Luis Hamilton
"""

##########EXERCÍCIO 1 - AGENDA
'''
def function():
    dicionario ={}
    a = 1
    while True:
        dicionario['nome%i' % a] = input('Digite o nome da pessoa: ')
        dicionario['telefone%i' % a] = input('Digite o telefone da pessoa: ')
        decision = input('Você quer continuar?(s/n): ')
        try:
            if decision == 'n':
                break
            elif decision == 's':
                a += 1
        except Exception as erro:
            print('Opção inválida', erro)
            break
    return dicionario
arq = open('dicionario.txt', 'w')
arq.close()
lista =[]
dicionariofinal = function()
for i in dicionariofinal.items():
    lista.append(i)
try:
    arq = open('dicionario.txt', 'a')
    for a in lista:
        arq.write(str(a))
        arq.write('\n')
except Exception as erro:
    print('Erro ao salvar', erro)
finally:
    arq.close()
'''




##########EXERCÍCIO 2 - CADASTRO(estudar mais)
'''
dicionario ={}
lista =[]
lista_menor =[]

while True:
    nome = input('Digite um nome: ')
    while True:
        try:
            idade = int(input('Digite a sua idade: '))
        except Exception:
            print('Valor inválido! Tente novamente. ')
            continue
        break
    cpf = input('Digite o seu CPF: ')
    dicionario['Nome'] = nome
    dicionario['Idade'] = idade
    dicionario['CPF'] = cpf
    lista.append(dicionario.copy())
    decision = input('Você quer continuar?(s/n): ')
    try:
        if decision == 'n':
            break
        elif decision == 's':
            continue
    except Exception:
        print('ERRO')
for c in lista:
    if c['Idade'] < 18:
        lista_menor.append(c)
    
try:
    arq = open('ArquivoGe.txt', 'w')
except Exception:
    print('ERRO')
finally:
    arq.close()

try:
    arq = open('ArquivoMe.txt', 'w')
except Exception:
    print('ERRO')
finally:
    arq.close()

try:
    arq = open('ArquivoGe.txt', 'rt+')
    for c in lista:
        for k, v in c.items():
            arq.write(f'{k}: {v}\n')
        arq.write('\n')
except Exception:
    print('ERRO')
finally:
    arq.close()
    
try:
    arq = open('ArquivoMe.txt', 'rt+')
    for c in lista_menor:
        for k, v in c.items():
            arq.write(f'{k}: {v}\n')
        arq.write('\n')
except Exception:
    print('ERRO')
finally:
    arq.close()
'''




##########EXERCíCIO 3 - CADASTRO 2.0
'''
dicionario ={}

while True:
    nome = input('Digite um nome: ')
    while True:
        try:
            idade = int(input('Digite a sua idade: '))
        except Exception:
            print('Valor inválido! Tente novamente. ')
            continue
        break
    cpf = input('Digite o seu CPF: ')
    decision = input('Você quer continuar?(s/n): ')
    dicionario[cpf] = [nome, idade]
    try:
        if decision == 'n':
            break
        elif decision == 's':
            continue
    except Exception:
        print('ERRO')

print()
for k, v in dicionario.items():
    print(f'{k}: {v[0]} - {v[1]}\n')'''