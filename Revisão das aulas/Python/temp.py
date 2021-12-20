# -*- coding: utf-8 -*-
"""
Spyder Editor

Este é um arquivo de script temporário.
"""

import pandas as pd

df = pd.read_csv("exercicioedjalma.csv")



print(df["data"].value_counts())
df = pd.DataFrame( df , df["data"].value_counts(), columns =  "quantiadde", "data" )
print(df)
