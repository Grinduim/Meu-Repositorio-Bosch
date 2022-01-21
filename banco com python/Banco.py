# esse é um projeto de branco que estou criando 
import pyodbc

def login():
    conta = input('Insira o numero da conta para fazer login: ' )
    senha = input('Digite a sua senha: ')

    #iniciando toda a parte de conexão com o BD
    server = 'JVLPC0581'
    database = 'ServicoBancario'
    username = 'vinicius'
    password = 'admin'
    conexao   = pyodbc.connect('DRIVER={SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)

    cursor = conexao.cursor()
    cmdTotal = 'SELECT COUNT(Num) as total FROM CONTA' # comando para o selecet
    cursor.execute(cmdTotal) # executando o comando sql
    count  = cursor.fetchone().total # pegando o primeiro valor do resultado e a coluna total

    cursor.execute('SELECT * FROM CONTA')# selecionando todas as contas
    contas = cursor.fetchall()

    for i in range(count):
        if(conta ==contas[i].Num and senha==contas[i].senha ):
            print('Entrou')
        elif (i == count-1):
            print('Senha e Conta incorreto! ')

def cadastrar():
    conta = input('Insira o numero da conta para cadastrar: ' )
    senha = input('Digite a sua senha: ')
    server = 'JVLPC0581'
    database = 'ServicoBancario'
    username = 'vinicius'
    password = 'admin'
    conexao   = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+password+'')

    cursor = conexao.cursor()
    cursor.execute(f'INSERT INTO CONTA(NUM,SENHA,ACESSO,SALDO) VALUES ({conta},{senha},1,200)')
    cursor.commit()
    print('okay')



opc = 2
if(opc == 2):
    cadastrar()
print("saiu")

    





