# link: https://matplotlib.org/api/_as_gen/matplotlib.pyplot.plot.html#matplotlib.pyplot.plot
import matplotlib.pyplot as plt

x = [1, 3, 5, 7, 9]
y = [2, 3, 7, 1, 0]
z = [200, 25, 400, 3300, 100]

titulo = "Scatterplot: gráfico de dispersão"
eixoX = "Eixo X"
eixoY = "Eixo Y"

# Legendas
plt.title(titulo)
plt.xlabel(eixoX)
plt.ylabel(eixoY)

plt.scatter(x, y, label="Meus pontos", color="k", marker=".", s=z)
plt.plot(x, y, color="#000000", linestyle="--")
plt.legend()

plt.show()