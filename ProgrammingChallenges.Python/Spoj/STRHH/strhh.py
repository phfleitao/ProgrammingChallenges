quantidade = int(input())

for qtd in range(quantidade):
    palavra = input()
    resultado = palavra[0:int(len(palavra)/2):2]
    print(resultado)