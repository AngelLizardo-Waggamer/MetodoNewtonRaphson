# Metodo Newton Raphson
El método de Newton-Raphson nos permite encontrar la raíz de una función a partir de un límite inferior de un intervalo dado. Este número se conocerá más adelante como $ x_n $. Un nuevo número será generado en base a la primera derivada de la función entregada, y este se conocerá como $ x_{n+1} $, el cual pasadas las ejecuciones necesarias será el valor de la raíz que se encontró.

## Formula
$$ x_{n+1} = x_n - ( \frac{f(x)}{f'(x)} ) $$

## Aplicación
La manera de utilizar la fórmula es primero calcular la derivada de la función que se esté utilizando. Posteriormente, se evalúa la función original y la derivada usando el primer valor del intervalo que se nos dio para sustituir los valores en la fórmula. Finalmente, se evalúa la fórmula para obtener el siguiente número con el que ocupar la fórmula. Este proceso se repite hasta que la respuesta es lo suficientemente acertada.

Para calcular la exactitud se hace la siguiente operación:

$$
\epsilon_0 = |x_{n+1} - x_n|
$$

Se dice que la respuesta $$ x_{n+1} $$ es lo suficientemente acertada cuando $$ \epsilon_0 < \epsilon $$

Por lo que, si se hace una función que repita la fórmula, la condición delimitadora para un ciclo `While` debería de ser:

$$ \epsilon_0 > \epsilon $$

**Nota:** Recordemos que $ \epsilon $ debe de ir dada en el planteamiento del problema. De no ser así, se puede asumir con un valor de $$ \epsilon = 0.001 $$

En C#, el código debería de verse así:
```csharp
Math.abs(x1 - x) > epsilon
```
Donde:
* La parte anterior al símbolo `>` equivale a epsilon calculada
* La parte posterior al símbolo `>` equivale a epsilon dada
