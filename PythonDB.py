from xmlrpc.client import DateTime
import pyodbc
import os
from datetime import date
os.system('cls')

dados_conexao = (
    "Driver={SQL Server};"
    "Server=brm3907\SQLEXPRESS;"
    "Database=FixManutencaoDB;"
)

conn = pyodbc.connect(dados_conexao)   

dataHoje = date.strftime(date.today(), '%Y-%m-%d')






cursor = conn.cursor()

cmd = f"select * from Fix_ManutencaoNew where saida like '%{dataHoje}%'"

cursor.execute(cmd)
cursor.commit()

print(f"Conexão realizada com sucesso! \n{dataHoje}")

