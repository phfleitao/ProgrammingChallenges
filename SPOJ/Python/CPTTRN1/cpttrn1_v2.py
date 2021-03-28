mapaCaracteres = ["*","."]
quantidade = int(input())

for i in range(quantidade):
    qtdLinhas, qtdColunas = [int(valor) for valor in input().split()]
    for i in range(qtdLinhas):
        for j in range(qtdColunas):
            print(mapaCaracteres[(i+j) % 2], end = "")
        print()