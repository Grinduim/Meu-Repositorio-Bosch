# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 16:24:06 2021

@author: DISRCT
"""
import numpy as np
import matplit.lib as plt
import pandas as pd
DT  = pd.DataFrame(pd.read_csv("netflix_titles.csv"))
aux1 = DT.loc[DT["country"] ==  "United States"]
a2015 = aux1.loc[aux1['release_year'] == 2015 ]
a2016 = aux1.loc[aux1['release_year'] == 2016 ]	
a2017 = aux1.loc[aux1['release_year'] == 2017 ]	
a2018 = aux1.loc[aux1['release_year'] == 2018 ]	
a2019 = aux1.loc[aux1['release_year'] == 2019 ]	
a2020 = aux1.loc[aux1['release_year'] == 2020 ]	
qtd2015 = ((a2016.shape))[0]	
qtd2016 = ((a2016.shape))[0]
qtd2017 = ((a2016.shape))[0]
qtd2018 = ((a2016.shape))[0]
qtd2019 = ((a2016.shape))[0]
qtd2020 = ((a2016.shape))[0]
ano = [2015,2016,2017,2018,2019 ]
dados = [qtd2015,qtd2016,qtd2017,qtd2018,qtd2019,qtd2020]
plt.bar(ano,dados, color = "red")
plt.xticks('ano')
plt.ylabel("Qtd")
plt.xlabel("anos")
plt.title("Anos de lançamento")
plt.show()