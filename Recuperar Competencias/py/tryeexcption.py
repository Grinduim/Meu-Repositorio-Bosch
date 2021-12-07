# -*- coding: utf-8 -*-
"""
Created on Mon Nov 29 22:29:41 2021

@author: Vinic
"""
lista = []
while(True):
    try:
        num = float(input("\nInsira um numero inteiro para ser o numerador"))
        num2 = float(input("\nInsira um numero para ser o Denominador"))
        div = num/num2
    except ZeroDivisionError:
        print("\nO valor não pode ser dividido por Zero")
        break

    except ImportError:
        print("\nDeu Algum erro, tente novamente, por favor")
        continue
    finally:
        print(f"\n A divisão de {num} por {num2} restou em {div:.2f}")
