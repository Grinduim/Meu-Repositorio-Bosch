# -*- coding: utf-8 -*-
"""
Created on Fri Sep  3 13:38:45 2021

@author: Luis Hamilton
"""

##########EXEMPLO PROFESSOR
'''
try:
    arq = open('meuarquivo.txt', 'w')
except Exception:
    print("Erro ao salvar")
    
finally:
    arq.close()
'''




##########EXERCÍCIO 1 - IPV4
'''
def function(ip):
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
pepino = 0
archive = open('IPV4DataBase.txt', 'w')
archive.close()
while pepino < 1:
    globalip = input("Digite o endereço IPV4: ")
    verify = function(globalip)
    if verify == True:
        print("IP Válido")
        try:
            archive = open('IPV4DataBase.txt', 'a+')
            archive.write(f"{globalip}, ")
            archive.seek(0)
            print(archive.read(),'Ip salvo com sucesso')
        except Exception:
            print('Erro Inesperado, não foi possível salvar o ip')
        finally:
            archive.close()
    else:
        print("IP Inválido")
    sair = input('Deseja continuar?(S/N): ')
    if sair == "S":
        continue
    elif sair == "N":
        break
'''




##########EXERCÍCIO 2 - IPV4 VAL/INV (incompleto)
def function(ip):
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
pepino = 0
listaV =['\n', 'IP Válido: ']
listaI =['IP Inválido: ']
archive = open('IPV4DataBase.txt', 'w')
archive.close()
while pepino < 1:
    globalip = input("Digite o endereço IPV4: ")
    verify = function(globalip)
    if verify == True:
        print("IP Válido")
        listaV.append(globalip)
        try:
            archive = open('IPV4DataBase.txt', 'a+')
            archive.write(listaV[0])
            archive.write(listaV[1])
            archive.write(listaV[-1])
            archive.seek(0)
            print(archive.read(),'Ip salvo com sucesso')
        except Exception:
            print('Erro Inesperado, não foi possível salvar o ip')
        finally:
            archive.close()
    else:
        print("IP Inválido")
        listaI.append(globalip)
        try:
            archive = open('IPV4DataBase.txt', 'a+')
            archive.write(listaV[0])
            archive.write(listaI[0])
            archive.write(listaI[-1])
            archive.seek(0)
            print(archive.read(),'\nIp salvo com sucesso')
        except Exception:
            print('Erro Inesperado, não foi possível salvar o ip')
        finally:
            archive.close()
    sair = input('Deseja continuar?(S/N): ')
    if sair == "S":
        continue
    elif sair == "N":
        break