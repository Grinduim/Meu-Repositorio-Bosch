# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 13:29:12 2021

@author: Luis Hamilton Balem
"""

##########GRÁFICO DE PARES E ÍMPARES
'''
import matplotlib.pyplot as plt

a = 0
b = 0
for i in range(5):
  var = int(input("Digite um número: "))
  if var % 2 == 0:
    a += 1
  else:
    b += 1

valores = [a, b]
nlabels = 'Pares', 'Ímpares'
plt.pie(valores, labels = nlabels,autopct='%1.1f%%')
plt.title('Gráfico de pares e ímpares')
plt.axis('equal')
plt.show()
'''




##########GRÁFICO TWITTER
'''
import tweepy as tw

api_key = 'mwWW2gFGzoQV0INxKyfp1kjJv'
api_key_secret = 'HhDiMZ7GkXbuEEbM0zVjZnD1M4efUvW80BWfA21YZ0BKzO9v12'
access_token = '1268387756608282630-M1SIHEXGSmtSpsWq8bQpOwG93XhxpE'
access_token_secret = 'jG9F1I1nej0oqw3ROPH7IqepOxbwlzI6TmScXy3mR6XZn'

auth = tw.OAuthHandler(api_key, api_key_secret)
auth.set_access_token(access_token, access_token_secret)

api = tw.API(auth)
'''
###ACESSAR MINHA TIMELINE
'''
ler_tweets = api.home_timeline()
for tweet in ler_tweets:
	print(tweet.text)
'''




###ACESSAR TWEETS DE UM USUÁRIO
'''
def obter_tweets(usuario, limite = 10):
	resultados = api.user_timeline(screen_name = usuario, count = limite, tweet_mode = "extended")
	tweets =[]
	for i in resultados:
		tweets.append(i.full_text)
	return tweets
tt = obter_tweets('GabrielGenski')
print('\n'.join(tt))

##########SALVAR EM UM ARQUIVO
arquivo = open('tweets.txt', 'w')
arquivo.write('\n'.join(tt))
arquivo.close()
'''




###BUSCA POR ASSUNTO DETERMINADO
'''
query = "#calamidade" + "-filter:retweets"
cursor = tw.Cursor(api.search, q = query).items(5)

for tweet in cursor:
	print(tweet.created_at)
	print(tweet.text)
'''
###ARMAZANAR EM UM DATAFRAME
'''
import pandas as pd
df = pd.DataFrame(data=[tweet.text for tweet in cursor], columns=['Tweets'])
df.head()
'''




###ANALISAR SENTIMENTOS
'''
from textblob import TextBlob
from textblob.sentiments import NaiveBayesAnalyzer

analise = TextBlob("i am happy", analyzer = NaiveBayesAnalyzer())
print(analise.sentiment)
'''



###CRIAÇÂO DE GRÁFICOS
'''
import matplotlib.pyplot as plt
valores = [100,200,350]

nlabels = 'amor','amor mas em laranja','amor mas em verde'
plt.pie(valores, labels = nlabels,autopct='%1.1f%%')
plt.title('O que eu sinto pelo professor')
plt.axis('equal')
plt.show()
'''






###EXERCÍCIO - GRÁFICO COM SENTIMENTOS DE TWEETS

###USANDO UM USUARIO ESPECIFICO
'''
positive = 0
negative = 0
from textblob import TextBlob
from textblob.sentiments import NaiveBayesAnalyzer
import matplotlib.pyplot as plt

def obter_tweets(usuario, limite = 20):
	resultados = api.user_timeline(screen_name = usuario, count = limite, tweet_mode = "extended")
	tweets =[]
	for i in resultados:
		tweets.append(i.full_text)
	return tweets
tt = obter_tweets('realDonald_Trmp')

for i in tt:
	print(i)
	analise = TextBlob(i, analyzer = NaiveBayesAnalyzer())
	if analise.sentiment.classification == 'pos':
		positive += 1
	elif analise.sentiment.classification == 'neg':
		negative += 1
print(negative, positive)


valores = [positive, negative]
nlabels = 'feliz', 'triste'
plt.pie(valores, labels = nlabels,autopct='%1.1f%%')
plt.title('Gráfico de sentimentos de tweets')
plt.axis('equal')
plt.show()
'''

###USANDO UMA HASHTAG
'''
positive = 0
negative = 0
from textblob import TextBlob
from textblob.sentiments import NaiveBayesAnalyzer
import matplotlib.pyplot as plt

query = "#trump" + "-filter:retweets"
cursor = tw.Cursor(api.search, q = query, lang='en').items(5)

for i in cursor:
	analise = TextBlob(i.text, analyzer = NaiveBayesAnalyzer())
	if analise.sentiment.classification == 'pos':
		positive += 1
	elif analise.sentiment.classification == 'neg':
		negative += 1
print(negative, positive)

valores = [positive, negative]
nlabels = 'feliz', 'triste'
plt.pie(valores, labels = nlabels,autopct='%1.1f%%')
plt.title('Gráfico de sentimentos de tweets')
plt.axis('equal')
plt.show()
'''