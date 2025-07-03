# ?? Ejercicio 1: Sucesión de Fibonacci

## ?? Descripción
Aplicación de consola que solicita al usuario ingresar un número y genera la sucesión de Fibonacci hasta dicho número utilizando la fórmula recursiva.

## ????? Autor
**Yeison G**

## ?? Objetivo
Este ejercicio forma parte de la prueba técnica para desarrollador de software para PGD, evaluando habilidades en desarrollo backend con C# y .NET Framework.

## ??? Tecnologías Utilizadas
- **Lenguaje**: C# 7.3
- **Framework**: .NET Framework 4.7.2
- **IDE**: Visual Studio 2022
- **Paradigma**: Programación orientada a objetos

## ?? Fórmula Implementada
La aplicación utiliza la **fórmula recursiva** de Fibonacci:
```
F(n) = F(n-1) + F(n-2)
Donde:
- F(0) = 0
- F(1) = 1
```

## ? Funcionalidades
- ? Solicita número al usuario con validación robusta
- ? Genera sucesión de Fibonacci hasta el límite especificado
- ? Utiliza implementación recursiva como se requiere
- ? Muestra resultados en formato legible
- ? Manejo completo de errores y excepciones
- ? Validaciones de entrada (números negativos, texto inválido, valores vacíos)

## ?? Estructura del Código
```
ConsoleApp1/
??? Program.cs                    # Clase principal con lógica completa
??? Properties/
?   ??? AssemblyInfo.cs          # Información del ensamblado
??? ConsoleApp1.csproj           # Archivo de proyecto
??? README.md                    # Este archivo
```

## ?? Cómo Ejecutar
1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/yeygok/pgd.git
   cd pgd
   ```

2. **Abrir en Visual Studio:**
   - Abrir `ConsoleApp1.sln` o `ConsoleApp1.csproj`

3. **Compilar y ejecutar:**
   ```bash
   # Opción 1: Desde Visual Studio
   F5 o Ctrl+F5
   
   # Opción 2: Desde línea de comandos
   dotnet build
   dotnet run
   ```

## ?? Ejemplo de Uso
```
Ingrese un número para generar Fibonacci: 50

Sucesión de Fibonacci hasta 50:
----------------------------------------
Números encontrados: 10

0, 1, 1, 2, 3, 5, 8, 13, 21, 34

Proceso completado. Presione cualquier tecla para salir...
```

## ?? Validaciones Implementadas
- **Entrada vacía**: Maneja cadenas nulas o espacios en blanco
- **Texto inválido**: Valida que sea un número entero
- **Números negativos**: Solo acepta números >= 0
- **Excepciones**: Try-catch para errores inesperados

## ?? Complejidad
- **Tiempo**: O(2^n) - Implementación recursiva básica
- **Espacio**: O(n) - Por la pila de recursión
- **Nota**: Para números grandes puede ser lenta debido a la naturaleza recursiva

## ?? Casos de Prueba
| Entrada | Resultado Esperado |
|---------|-------------------|
| `0` | `0` |
| `1` | `0, 1, 1` |
| `10` | `0, 1, 1, 2, 3, 5, 8` |
| `100` | Sucesión completa hasta 89 |
| `-5` | Error: El número debe ser >= 0 |
| `abc` | Error: Debe ser un número entero |

## ?? Requisitos Cumplidos
- ? Solicita número al usuario
- ? Genera sucesión de Fibonacci hasta el número ingresado
- ? Muestra la sucesión resultante
- ? Utiliza fórmula recursiva como se especifica
- ? Código limpio y bien documentado
- ? Manejo robusto de errores

## ??? Arquitectura
- **Patrón**: Programación estructurada con métodos estáticos
- **Separación de responsabilidades**: Cada método tiene una función específica
- **Documentación**: Comentarios XML completos
- **Buenas prácticas**: Validaciones, manejo de errores, código legible

## ?? Versión
**v1.0.0** - Implementación inicial completa

---

**Desarrollado como parte de la Prueba Técnica PGD - Backend Developer**