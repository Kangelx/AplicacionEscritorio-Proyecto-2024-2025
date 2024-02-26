# # AlpacApp Incidents
## PROYECTO INTERMODULAR EQUIPO 3: Diseño de Interfaces - Aplicación de Escritorio
## [Página Principal](https://github.com/Kangelx/Proyecto2024-2025/blob/main/README.md)
</head>
  <body>
    <header class="page-header" role="banner">
      <h1 class="project-name">MARKDOWN DI: CREACIÓN INTERFAZ GRÁFICA</h1>
    </header>
   

<h3 id="indice">INDICE</h3>
    <ul>
      <li><a href="#objetivos">Introducción</a></li>
      <li><a href="#estructura">Estructura del programa</a></li>
      <li><a href="#front">FRONT</a></li>
      <li><a href="#back">BACK</a></li>
      <li><a href="#autores">Autores del proyecto</a></li>
      </ul>
    
    

<div id='objetivos'/>

## Objetivos del proyecto

- Realizar una aplicación de escritorio en C# con buena usabilidad para que los administradores realicen gestión de las incidencias abiertas y los usuarios puedan intervenir sobre las incidencias que han abierto.


<div id='estructura'/>

## Estructura de las interfaces 

 ### Actividades de Profesor

#### Acciones sobre una incidencia:
- **Modificar o eliminar:** Solo antes de que esté en proceso.
- **Comentar:** Sin que esté finalizada.
- **Recibir notificaciones:** Incidencias abiertas por su usuario.
- **Cerrar:** Una vez revisada y considerada como solucionada.

#### Registro de una nueva incidencia:
- **Datos requeridos:**
  - Usuario que pone la incidencia.
  - Tipo de incidencia (Equipos, Cuentas, Wifi, Internet, Software).
  - Subtipo de incidencia.
  - Número de etiqueta (solo para tipo de incidencia "Equipos").
  - Aula y puesto donde se produce la incidencia (solo para tipo de incidencia "Equipos").
  - Descripción de la incidencia.
  - Fichero adjunto (capturas de pantalla, listas de usuarios, etc.).
  - Fecha y hora de registro.
- **Notificación:** El usuario recibe el ID asignado a la incidencia después de abrir/crerla.

#### Visualización de incidencias:
- **Filtrado:** Por diferentes campos.

#### Información de incidencias:
- **Incidencias creadas:** Visualización de las incidencias que ha creado.

### Actividades de Administrador

#### Acciones sobre una incidencia:
- **Ver, hacerse responsable, asignar a otro, comentar, cambiar estado, cambiar prioridad, resolver, eliminar, modificar, cerrar, abrir:** Sobre una incidencia.
- **Enviar mensaje:** Al usuario que la ha creado y a la cuenta de TIC cuando se modifique su estado.

#### Visualización de incidencias:
- **Filtrado:** Según varios criterios.

#### Generación de informes:
- **Formatos:** Excel y PDF.
- **Información sobre:**
  - Incidencias resueltas por cada administrador.
  - Incidencias abiertas por cada usuario.
  - Estadísticas sobre tipos de incidencias.
  - Tiempo dedicado a cada incidencia.
  - Tiempos de resolución por tipo de incidencia.
  - Tiempo dedicado por cada administrador.
  - Lista de incidencias asignadas a cada administrador.

#### Exportación de contenido:
- **Formatos:** Excel y PDF.
- **Contenido:** De una incidencia.



    ```


<div id='front'/>

## Diseño de las interfaces gráficas





<div id='back'/>

## Conexión a la API y métodos CRUD


---
<div id='autores'/>
  
## Autores del proyecto
### Aplicación móvil
📱: Diego Corominas Gómez
🦙: Oana Irina Cutitaru Ciobanu

### Aplicación de escritorio
🎧: Paula Díaz Santos
🖥️: Ángel García García

### Python
🐍: Rubén Cortés Muñoz

### Base de datos
📁: Pablo Sainz Luque
</body>
</html>

  
