# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 15:36:02 2021

@author: DISRCT
"""
MODE_ENCRYPT = 1
MODE_DECRYPT = 0
def caesar(frase, key, mode):
    alfabeto = 'abcdefghijklmnopqrstuvwyzàáãâéêóôõíúçABCDEFGHIJKLMNOPQRSTUVWYZÀÁÃÂÉÊÓÕÍÚÇ'
    new_data = ''
    for c in frase:
        index = alfabeto.find(c)
        if index == -1:
            new_data += c
        else:
            new_index = index + key if mode == MODE_ENCRYPT else index - key
            new_index = new_index % len(alfabeto)
            new_data += alfabeto[new_index:new_index+1]
    return new_data


key = int(input("digite a quatidade de casas" ))
frase = input("digite a frase a ser encriptografada")
print('  Original:', frase)
cifra = caesar(frase, key, MODE_ENCRYPT)
print('Encriptada:', cifra)

