# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 16:57:55 2021

@author: DISRCT
"""
datae = input('Digite a data: ').strip(' ').lower()
datae.split('de')
datae.split('de')
# o meu codigo apagoooouuu 
print (datae)
if datae[1] == "janeiro":
	datae[1] =  "01"
if datae[1] == "fevereiro":
	datae[1] =  "02" 
if datae[1] == "março":
	datae[1] = "03"
if datae[1] == "abril":
	datae[1] = "04"
if datae[1] == "maio":
	datae[1] = "05"	
if datae[1] == "junho":
	datae[1] = "06"	
if datae[1] == "julho":
	datae[1] = "07"	
if datae[1] == "agosto":
	datae[1] = "08"
if datae[1] == "setembro":
	datae[1] = "09"
if datae[1] == "outubro":
	datae[1] = "10"
if datae[1] == "novembro":
	datae[1] = "11"
if datae[1] == "dezembro":
	datae[1] = "12"

print(f"\n {datae[0]}/{datae[1]}/{datae[2]}")		