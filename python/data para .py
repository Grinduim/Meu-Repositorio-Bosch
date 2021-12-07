# -*- coding: utf-8 -*-
"""
Created on Mon Sep 27 15:07:48 2021

@author: DISRCT
"""

data = input("Insira a data:").strip()
data = data.split(" ")

dia = int(data[0])
mes = data[2].title()

meses  = ["Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"]

count = 0
for aux in meses:
    
    if mes == aux:
        mes = int(meses.index(aux) + 1)
        if dia > 0 and dia < 31:
            if mes >= 1 and mes <= 12:
                if mes < 10:
                    print(f"{dia}/0{mes}/{data[4]}")
                    break
                else:
                    print(f"{dia}/{mes}/{data[4]}")
                    break
        else:
            print("data Invalida")
            
    count= count +1
    
    
    if count == 12:
        print("Data Invalida")
        break
   
    

    

