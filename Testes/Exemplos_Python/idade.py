nome = 'Nelson'
sobrenome = 'Dressler'
anoNascimento = 1990
anoAtual = 2019
aniversarioAnoAtual = True

idade = anoAtual - anoNascimento if aniversarioAnoAtual else (anoAtual - 1 - anoNascimento)



lista = [['Pro', 'fes', 'sor'], 'da', 'ByLearn', ':)']

if idade >= 18:
    dirigir = True
else:
    dirigir = False

print(idade)

print("Teste nova linha")