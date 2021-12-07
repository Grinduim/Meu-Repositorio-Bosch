# -*- coding: utf-8 -*-
"""
Created on Thu Aug 26 14:59:37 2021

@author: Luis Hamilton
"""

################EXERCÍCIO 5
'''varA = int(input("Digite o primeiro valor: "))
varB = int(input("Digite o segundo valor: "))
print("A varíavel A é: %i \nA variável B é: %i" % (varA, varB))
input("Aperte enter para trocar o valor  das variáveis A e B")
temp = varA
varA = varB
varB = temp
print("A variável A agora é: %i \nA variável B agora é: %i" % (varA, varB))'''




################EXERCÍCIO 6
'''celsius = float(input("Digite o valor da temperatura em Celsius: "))
fahrenheit = (9 * celsius + 160) / 5
print(f"O valor da temperatura em fahrenheit é {fahrenheit} graus")'''




################EXERCÍCIO 7
'''dolar = float(input("Digite quantos dólares você quer converter : "))
cotacao = float(input("Digite a cotação do dólar atual: "))
real = dolar * cotacao
print(f"O valor convertido em reais é: {real}")'''




################EXERCÍCIO 8
'''byte = float(input("Digite o valor de bytes para converter: "))
gigabyte = byte / 1024 ** 3
print("A conversão de %0.1f bytes para gigabytes é igual a: %0.91f" % (byte, gigabyte))'''




################EXERCÍCIO 9
'''peso1 = 4
peso2 = 6
nota1 = float(input("Digite o valor da primeira nota: "))
nota2 = float(input("Digite o valor da segunda nota: "))
media1 = nota1 * peso1
media2 = nota2 * peso2
mediap = (media1 + media2) / (peso1 + peso2)
print(f"A média ponderada das duas notas é igual a: {mediap}")'''




################EXERCÍCIO 1
'''nota = float(input("Digite o valor de sua nota: "))
if nota >= 0 and nota <= 10:
    if nota >= 8:
        print("Nota excelente, parabéns!")
    elif nota >= 5:
        print("Nota azul, continue assim!")
    else:
        print("Nota vermelha, estude mais!")
else:
    print("Nota inválida, tente novamente!")'''
    
    
    
    
################EXERCÍCIO 2
'''nomec = "Luis Hamilton"
nome = input("Digite o nome correto: ")
if nome == nomec:
    print("Nome correto!")
else:
    print("Nome incorreto!")'''




################EXERCÍCIO 3
'''pesoe = float(input("Digite a capecidade de peso do elevador: "))
peso = float(input("Digite o peso da primeira pessoa: "))
peso1 = float(input("Digite o peso da segunda pessoa: "))
peso2 = float(input("Digite o peso da terceira pessoa: "))
peso3 = float(input("Digite o peso da quarta pessoa: "))
peso4 = float(input("Digite o peso da quinta pessoa: "))

pesop = peso + peso1 + peso2 + peso3 + peso4

if pesop < pesoe:
    print("Elevador Liberado")
else:
    print("Carga máxima excedida!!!")'''
    
    
    

################EXERCÍCIO 4
'''ano = int(input("DIgite o ano: "))
if ano % 400 == 0:
    print("Ano bissexto")
elif ano % 4 == 0 and ano % 100 != 0:
    print("Ano bissexto")
else:
    print("Ano não é bissexto")'''
    
    
    
    
    
'''mes = int(input("Digite o número do mês correspondente: "))
if mes >= 1 and mes <= 12:
    if mes <= 7:
        if mes % 2 != 0:
            print("Esse mês tem 31 dias")
        elif mes == 2:
            print("Esse mês tem 28 dias")
        else:
            print("Esse mês tem 30 dias")
    elif mes % 2 == 0:
        print("Esse mês tem 31 dias")
    else:
        print("Esse mês tem 30 dias")
else:
    print("Número de mês inválido")'''
    
    
    
    
    
'''peso = float(input("Digite seu peso em quilos: "))
altura = float(input("Digite sua altura em metros: "))
imc = peso / altura ** 2
if imc < 20:
    print("IMC igual a: %0.1f, abaixo do peso" % imc)
elif imc <= 25:
    print("IMC igual a: %0.1f, peso normal" % imc)
elif imc <= 30:
    print("IMC igual a: %0.1f, acima do peso" % imc)
else:
    print("IMC igual a: %0.1f, obesidade" % imc)'''
    
    
    
    
    
'''nome = input("Digite o nome do aluno: ")
dias = int(input("Digite a quantidade de dias na semana: "))
curso = input("Digite B para o curso básico, I para intermediário e A para avançado: ").upper()
print("Aluno: %s" % nome)
if curso == "B":
    valorT = dias * 7 * 15
    print("Valor total: %i reais" % valorT)
elif curso == "I":
    valorT = dias * 8.5 * 20
    print("Valor total: %i reais" % valorT)
elif curso == "A":
    valorT = dias * 10 * 25
    print("Valor total: %i reais" % valorT)
else:
    print("Opção de curso inválida")'''
    
    
    
    
    
'''numeros = input("Digite 3 números: ")
N1 = int(numeros.split()[0])
N2 = int(numeros.split()[1])
N3 = int(numeros.split()[2])
lista = [N1, N2, N3]
lista.sort(reverse=True)
print(lista)'''





'''num = int(input("Digite um número menor que 1000: "))
if num < 1000:
    unidade = num % 10
    numd = (num - unidade) / 10
    dezena = numd % 10
    numc = (numd - dezena) / 10
    centena = numc
    print("A número %i, possui %i centenas, %i dezenas e %i unidades" % (num, centena, dezena, unidade))
else:
    print("Número grande demais, tente novamente")'''