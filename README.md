# Newshore - Solutions for the Airline Industry

PRUEBA DE INGRESO
-----------------

Solución en .Net 5, con C#, al problema planteado para resolver el desafío técnico newshore.

PROBLEMA 1 Modelado Clases
--------------------------
Descripción:

Como consultor encargado deberá diseñar y crear el componente de búsqueda de Vuelos del producto para la compañía que se venderá a las diferentes aerolíneas que son clientes de Newshore, por lo tanto, deberá codificar la aplicación según el modelo de clases dado y aplicar diseño a la plataforma.
A través de esta nueva plataforma, los futuros pasajeros podrán buscar los diferentes destinos a los que la aerolínea vuela, además de su horario y eventualmente el tiempo de vuelo.
Un usuario buscará la ciudad de partida y de llegada, seleccionando también una fecha para este viaje y según la disponibilidad de horario elegirá la hora en la que desea volar, cada vuelo según su horario tendrá un precio que será fijado por la aerolínea.

PROBLEMA 2 Maquetación web
--------------------------
Descripción:
Se necesita una interfaz web donde se vean representados los siguientes casos de uso:

Formulario de búsqueda de Vuelos Disponibles:
Interfaz con los campos de origen, fecha de vuelo y un botón CTA (Call to action) que realizará la acción de búsqueda de vuelos disponibles (según la respuesta de la Web API)

Resultado de Búsqueda de Vuelos:
Interfaz para visualizar los resultados de la búsqueda con base a la selección del usuario. Se debe tener en cuenta que la interface de búsqueda debe permanecer visible.

PROBLEMA 3 Servicio API
-----------------------
Descripción:
De acuerdo a las clases modeladas en el Problema #1 y referente al paso #1 (Buscar viaje origen/destino, fecha salida). Las aerolíneas tienen rutas y fechas en las que operan sus vuelos, para este propósito se provee de una API que permita realizar la búsqueda de vuelos, que tiene todas las características e información necesaria para mostrar los vuelos en los que opera la aerolínea.
Para resolver el problema, se deberán tener en cuenta los siguientes datos: Origen, destino y fecha de salida. De acuerdo a estos datos que se solicitarán, consumir la API (...) y recibir la información de vuelos en su respuesta.

NOTA:
Formato de fecha debe ser yyyy-MM-dd (año-mes-día). Siempre una fecha de hoy hacia adelante.

Formato de rutas en código IATA, ejemplos:
MDE - Medellín
BOG - Bogotá
CTG – Cartagena
PEI – Pereira

Método para invocación de la API: POST



SOLUCION
--------
Se plantea la solución utilizando las siguientes caracteríticas:

- Arquitectura en capas: 
	- Capa de Acceso a Datos: Patrón Repository, DBcontext, Entity Framewor Core
	- Capa lógica o de negocio: Services, Models, DTOs, Mapper
	- Capa de Servicio Back End: API RESTful
	- Capa Front End: HTML, CSS, JavaScript, JQuery, AJAX, Bootstrap
- Principios SOLID: interfaces genéricas, clases abstractas genéricas.
- Inyección de Dependencias (IoT)
- Reflexión de objetos




