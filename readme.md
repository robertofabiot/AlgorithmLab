# AlgorithmLab

**AlgorithmLab** es una aplicación de escritorio desarrollada en C# y Windows Forms, diseñada para la ejecución, visualización y análisis comparativo de algoritmos de ordenamiento y búsqueda.

## Funcionalidades Principales

El sistema permite interactuar con diversas estructuras y algoritmos a través de una interfaz gráfica intuitiva:

* **Módulo de Ordenamiento:** Ejecución y visualización de algoritmos de ordenamiento sobre conjuntos de datos.
* **Módulo de Búsqueda:** Implementación de algoritmos de búsqueda (lineal, binaria, etc.).
* **Generador de Datos:** Herramienta para crear arrays y conjuntos de datos de prueba de forma aleatoria o personalizada.
* **Benchmarks y Métricas:** Registro detallado del rendimiento (`RegistroBenchmark`), permitiendo medir tiempos de ejecución y eficiencia.
* **Configuración:** Panel de ajustes para personalizar parámetros de la aplicación.

## Instalación y Ejecución

Para utilizar la aplicación en un entorno Windows, no es necesario compilar el código fuente. Siga estos pasos:

1.  Descargue o localice el archivo **`AlgorithmLabInstaller.msi`** que se encuentra en la raíz de este directorio.
2.  Ejecute el archivo haciendo doble clic sobre él.
3.  Siga las instrucciones del asistente de instalación de Windows.
4.  Una vez finalizado, abra la aplicación desde el menú de inicio o el acceso directo creado en su escritorio.

## Estructura del Código Fuente

Si desea explorar el código fuente (`AlgorithmLab.sln`), el proyecto sigue una arquitectura organizada por capas:

* **Algoritmos:** Contiene la lógica matemática pura (`LogicaBusqueda.cs`, `LogicaOrdenamiento.cs`).
* **Controlador:** Gestiona la lógica de negocio y la comunicación entre la vista y los datos.
* **Modelo:** Define las estructuras de datos y los objetos de registro (`MuestraDatos`, `RegistroBenchmark`).
* **Vista:** Contiene los formularios y controles de usuario de la interfaz gráfica (`FrmMain`, `UCSearch`, `UCSort`).

## Documentación Adicional

Para más información sobre el análisis teórico, la implementación de los algoritmos y los detalles del desarrollo, consulte el documento **`informe.pdf`** incluido en este repositorio.

---
*AlgorithmLab - Herramienta de Análisis Algorítmico.*
*Paleta de colores: https://coolors.co/f1fffa-ccfccb-96e6b3-568259-464e47*