# ?? Ejercicio 1: Sucesi�n de Fibonacci

## ?? Descripci�n
Aplicaci�n de consola que solicita al usuario ingresar un n�mero y genera la sucesi�n de Fibonacci hasta dicho n�mero utilizando la f�rmula recursiva.

## ????? Autor
**Yeison G**

## ?? Objetivo
Este ejercicio forma parte de la prueba t�cnica para desarrollador de software para PGD, evaluando habilidades en desarrollo backend con C# y .NET Framework.

## ??? Tecnolog�as Utilizadas
- **Lenguaje**: C# 7.3
- **Framework**: .NET Framework 4.7.2
- **IDE**: Visual Studio 2022
- **Paradigma**: Programaci�n orientada a objetos

## ?? F�rmula Implementada
La aplicaci�n utiliza la **f�rmula recursiva** de Fibonacci:
```
F(n) = F(n-1) + F(n-2)
Donde:
- F(0) = 0
- F(1) = 1
```

## ? Funcionalidades
- ? Solicita n�mero al usuario con validaci�n robusta
- ? Genera sucesi�n de Fibonacci hasta el l�mite especificado
- ? Utiliza implementaci�n recursiva como se requiere
- ? Muestra resultados en formato legible
- ? Manejo completo de errores y excepciones
- ? Validaciones de entrada (n�meros negativos, texto inv�lido, valores vac�os)

## ?? Estructura del C�digo
```
ConsoleApp1/
??? Program.cs                    # Clase principal con l�gica completa
??? Properties/
?   ??? AssemblyInfo.cs          # Informaci�n del ensamblado
??? ConsoleApp1.csproj           # Archivo de proyecto
??? README.md                    # Este archivo
```

## ?? C�mo Ejecutar
1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/yeygok/pgd.git
   cd pgd
   ```

2. **Abrir en Visual Studio:**
   - Abrir `ConsoleApp1.sln` o `ConsoleApp1.csproj`

3. **Compilar y ejecutar:**
   ```bash
   # Opci�n 1: Desde Visual Studio
   F5 o Ctrl+F5
   
   # Opci�n 2: Desde l�nea de comandos
   dotnet build
   dotnet run
   ```

## ?? Ejemplo de Uso
```
Ingrese un n�mero para generar Fibonacci: 50

Sucesi�n de Fibonacci hasta 50:
----------------------------------------
N�meros encontrados: 10

0, 1, 1, 2, 3, 5, 8, 13, 21, 34

Proceso completado. Presione cualquier tecla para salir...
```

## ?? Validaciones Implementadas
- **Entrada vac�a**: Maneja cadenas nulas o espacios en blanco
- **Texto inv�lido**: Valida que sea un n�mero entero
- **N�meros negativos**: Solo acepta n�meros >= 0
- **Excepciones**: Try-catch para errores inesperados

## ?? Complejidad
- **Tiempo**: O(2^n) - Implementaci�n recursiva b�sica
- **Espacio**: O(n) - Por la pila de recursi�n
- **Nota**: Para n�meros grandes puede ser lenta debido a la naturaleza recursiva

## ?? Casos de Prueba
| Entrada | Resultado Esperado |
|---------|-------------------|
| `0` | `0` |
| `1` | `0, 1, 1` |
| `10` | `0, 1, 1, 2, 3, 5, 8` |
| `100` | Sucesi�n completa hasta 89 |
| `-5` | Error: El n�mero debe ser >= 0 |
| `abc` | Error: Debe ser un n�mero entero |

## ?? Requisitos Cumplidos
- ? Solicita n�mero al usuario
- ? Genera sucesi�n de Fibonacci hasta el n�mero ingresado
- ? Muestra la sucesi�n resultante
- ? Utiliza f�rmula recursiva como se especifica
- ? C�digo limpio y bien documentado
- ? Manejo robusto de errores

## ??? Arquitectura
- **Patr�n**: Programaci�n estructurada con m�todos est�ticos
- **Separaci�n de responsabilidades**: Cada m�todo tiene una funci�n espec�fica
- **Documentaci�n**: Comentarios XML completos
- **Buenas pr�cticas**: Validaciones, manejo de errores, c�digo legible

## ?? Versi�n
**v1.0.0** - Implementaci�n inicial completa

---

**Desarrollado como parte de la Prueba T�cnica PGD - Backend Developer**