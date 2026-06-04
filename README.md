# -_figura_geometrica_rombo_asteriscos_- :.
# Figura Geométrica #2 - Rombo con Asteriscos:

<img width="1024" height="1024" alt="image" src="https://github.com/user-attachments/assets/2fd9e650-3992-4cbb-89dd-daa0bc4559d4" />  

```
Aplicacion de consola desarrollada en **C#** utilizando **Visual Studio 2022** que imprime una figura geométrica en forma de **rombo**, empleando únicamente caracteres de asterisco (`*`) .

---

## Tecnologías Utilizadas

- C#
- .NET
- Visual Studio 2022
- Aplicación de Consola

---

## Descripción

El programa genera un rombo compuesto por asteriscos.

La figura se construye en dos partes:

1. Parte superior del rombo.
2. Parte inferior del rombo.

Se utilizan estructuras repetitivas (`for`) para controlar:

- Los espacios en blanco.
- La cantidad de asteriscos por línea.
- La simetría de la figura.

---

## Código Completo

### Program.cs

```csharp
using System;

namespace FiguraGeometrica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            Console.WriteLine("FIGURA GEOMÉTRICA #2 - ROMBO");
            Console.WriteLine();

            // Parte superior
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Parte inferior
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
```

---

## Salida Esperada

```text
FIGURA GEOMÉTRICA #2 - ROMBO

    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *

Presione una tecla para finalizar...
```

---

## Explicación del Código

### Variable de Control

```csharp
int n = 5;
```

Define el tamaño del rombo.

---

### Parte Superior

```csharp
for (int i = 1; i <= n; i++)
```

Genera la mitad superior del rombo.

---

### Espacios en Blanco

```csharp
for (int j = 1; j <= n - i; j++)
```

Controla la alineación de la figura.

---

### Impresión de Asteriscos

```csharp
for (int k = 1; k <= (2 * i - 1); k++)
```

Calcula la cantidad de asteriscos por fila.

Patrón:

```text
1
3
5
7
9
```

---

### Parte Inferior

```csharp
for (int i = n - 1; i >= 1; i--)
```

Genera la mitad inferior del rombo manteniendo la simetría.

---

## Algoritmo

```text
Inicio

Definir n = 5

Mostrar título

Para i = 1 hasta n
    Imprimir espacios
    Imprimir asteriscos
Fin Para

Para i = n - 1 hasta 1
    Imprimir espacios
    Imprimir asteriscos
Fin Para

Mostrar mensaje final

Fin
```

---

## Pasos para Ejecutar en Visual Studio 2022

### 1. Crear Proyecto

- Abrir Visual Studio 2022.
- Seleccionar **Crear nuevo proyecto**.
- Elegir **Aplicación de consola (.NET)**.
- Clic en **Siguiente**.

### 2. Configurar Proyecto

Nombre del proyecto:

```text
FiguraGeometrica2
```

### 3. Agregar el Código

Abrir:

```text
Program.cs
```

Reemplazar todo el contenido por el código proporcionado.

### 4. Ejecutar

Presionar:

```text
Ctrl + F5
```

o seleccionar:

```text
Depurar → Iniciar sin depuración
```

---

## Estructura del Proyecto

```text
FiguraGeometrica2/
│
├── Program.cs
│
├── FiguraGeometrica2.csproj
│
└── README.md
```

---

## Resultado

El programa imprimirá en consola un rombo perfectamente simétrico utilizando únicamente caracteres de asterisco (`*`), demostrando el uso de:

- Bucles `for`
- Estructuras repetitivas anidadas
- Manejo de espacios
- Figuras geométricas en consola
- Programación básica en C# .
- :. . / .
