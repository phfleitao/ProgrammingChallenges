mapaCaracteres = ["*","."]
quantidade = int(input())

for i in range(quantidade):
    qtdLinhas, qtdColunas = [int(valor) for valor in input().split()]
    for i in range(qtdLinhas):
        for j in range(qtdColunas):
            if i % 2 == 0:
                print(mapaCaracteres[j % 2], end = "")
            else:
                print(mapaCaracteres[j % 2 - 1], end = "")
        print()