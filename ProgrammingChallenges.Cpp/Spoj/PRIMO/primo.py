def ePrimo(numero):
    if(numero == 0 or numero == 1): 
        return "nao"
    for i in range(2, numero):
        if(numero % i == 0):
            return "nao"
    return "sim"

numero = int(input())
print(ePrimo(numero))