# -*- coding: utf-8 -*-
"""
Created on Mon Sep 13 13:25:54 2021

@author: Luis Hamilton
"""

##########EXERCÍCIO 1 - PEÇAS FABRICADAS
'''
soma = 0
media = 0
mes = ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro']
arq = open('pecas_por_mes.txt', 'w')
arq.close()
arq2 = open('media_de_pecas.txt', 'w')
arq2.close()
arq = open('pecas_por_mes.txt', 'a+')
for i in mes:
    pecas = int(input('Digite a quantidade de peças fabricadas em ' + i + ': '))
    try:
        arq.write(i)
        arq.write(':  ')
        arq.write(str(pecas))
        arq.write('peças fabricadas.\n')
    except Exception as erro:
        print('Erro ao salvar', erro)
        break
    soma = soma + pecas
try:
    print('\nRelatório de peças fabricadas em cada mês: \n')
    arq.seek(0)
    print(arq.read())
except Exception:
    print('Erro ao acessar arquivo')
finally:
    arq.close()

media = soma / 12
try:
    arq2 = open('media_de_pecas.txt', 'a+')
    arq2.write('A quantidade média de peças fabricadas no ano foram: ')
    arq2.write(str(media))
    arq2.seek(0)
    print(arq2.read())
except Exception as erro:
    print('Erro ao acessar relatório de média', erro)
finally:
    arq2.close()
'''




##########EXERCÍCIO 2 - DATAS VÁLIDAS
'''
cancel = True
def function():
    lista=[]
    while True:
        data = input("Digite a data: ")
        if int(data[:2]) >= 1 and int(data[:2]) <= 31:
            if int(data[3:5]) >= 1 and int(data[3:5]) <= 12:
                lista.append(data)
                decision = input('Você quer inserir mais datas?(s/n): ')
                if decision == 'n':
                    return lista
                elif decision == 's':
                    continue
                else:
                    print('Opção inválida, foi considerado que não deseja mais inserir datas.')
                    return lista
            else:
                decision = input('Você quer inserir mais datas?(s/n): ')
                if decision == 'n':
                    return lista
                elif decision == 's':
                    continue
                else:
                    print('Opção inválida, foi considerado que não deseja mais inserir datas.')
                    return lista
        else:
            decision = input('Você quer inserir mais datas?(s/n): ')
            if decision == 'n':
                return lista
            elif decision == 's':
                continue
            else:
                print('Opção inválida, foi considerado que não deseja mais inserir datas.')
                return lista
var = function()
if cancel == True:
    print('\nDatas válidas: ',var)
'''




##########EXERCÍCIO 3 - IMPOSTO DE USUÁRIOS
'''
arq = open('dados_usuarios.txt', 'w')
arq.write('nome, valor, imposto\n')
arq.close()
arq2 = open('dados_impostos.txt', 'w')
arq2.close()
arq = open('dados_usuarios.txt', 'a+')
a = 0
b = 0
c = 0
d = 0
e = 0
while True:
    try:
        arq.write(input('Digite o nome do usuário: '))
        arq.write('/')
        var = int(input('Digite o valor para o cálculo: '))
        arq.write(str(var))
        arq.write('/')
        if var >= 4664.68:
            e += 1
            imposto = '27,5%'
            arq.write(imposto)
            arq.write('\n')
        elif var >= 3751.06:
            d += 1
            imposto = '22,5%'
            arq.write(imposto)
            arq.write('\n')
        elif var >= 2826.66:
            c += 1
            imposto = '15,0%'
            arq.write(imposto)
            arq.write('\n')
        elif var >= 1903.99:
            b += 1
            imposto = '7,5%'
            arq.write(imposto)
            arq.write('\n')
        elif var >= 0:
            a += 1
            imposto = 'ISENTO'
            arq.write(imposto)
            arq.write('\n')
    except Exception as erro:
        print('Erro ao salvar dados do usuário', erro)
    decision = input('Você quer inserir mais datas?(s/n): ')
    if decision == 'n':
        break
    elif decision == 's':
        continue
    else:
        print('Opção inválida, foi considerado que não deseja mais inserir usuários')
        break
arq.close()
try:
    arq2 = open('dados_impostos.txt', 'a+')
    arq2.write(str(a) + ' usuário(s) na faixa de ISENTO\n')
    arq2.write(str(b) + ' usuário(s) na faixa de 7,5%\n')
    arq2.write(str(c) + ' usuário(s) na faixa de 15,0%\n')
    arq2.write(str(d) + ' usuário(s) na faixa de 22,5%\n')
    arq2.write(str(e) + ' usuário(s) na faixa de 27,5%\n')
except Exception as erro:
    print('Não foi possível salvar os dados no arq(dados_impostos)', erro)
finally:
    arq2.close()
'''




##########EXERCÍCIO 4 - CSV FILMES
##########LETRA (A)
import pandas as pd

a = pd.read_csv('https://raw.githubusercontent.com/peetck/IMDB-Top1000-Movies/master/IMDB-Movie-Data.csv')
