# SistemaBibliotecaMVC

Qué es un Controller
--------------------
Un Controller es la clase que contiene las acciones (métodos) que responden a las solicitudes HTTP. Coordina la interacción entre el modelo y las vistas, procesa datos de entrada, ejecuta la lógica necesaria y devuelve una View o una redirección.

Qué es una View
----------------
Una View es la plantilla que genera la respuesta HTML enviada al cliente. En este proyecto las vistas usan Razor (.cshtml) y reciben datos desde el Controller para mostrarlos al usuario.

Qué es un ViewModel
--------------------
Un ViewModel es una clase que agrupa los datos que la View necesita. Se usa para trasladar información entre Controller y View sin exponer directamente entidades de dominio ni la base de datos.

Diferencia entre ViewBag, ViewData y TempData
----------------------------------------------
- ViewBag: contenedor dinámico (dinámico en tiempo de ejecución) para pasar datos simples desde Controller a View durante la misma petición.
- ViewData: diccionario (string -> object) con la misma finalidad que ViewBag; útil para datos con claves y cuando se prefiere sintaxis de índice.
- TempData: almacena datos entre peticiones (usa el mecanismo de TempData del framework). Se utiliza, por ejemplo, para mostrar un mensaje de éxito tras un Redirect.

Qué ruta personalizada implementó
---------------------------------
Se configuró el mapeo para exponer las páginas de gestión de libros bajo la ruta base:

  /biblioteca/libros

Detalles:
- En Program.cs se añadió un MapControllerRoute específico con patrón `biblioteca/libros/{action=Index}/{id?}` y se usa MapControllers().
- El controller responsable es `LibrosController` (ubicado en Controllers/LibrosController.cs).
- Acciones accesibles:
  - /biblioteca/libros            -> listado (Index)
  - /biblioteca/libros/crear      -> formulario de creación (Crear GET/POST)
  - /biblioteca/libros/detalle/{id} -> ficha de un libro (Detalle)

Notas
-----
- El proyecto no usa base de datos; los libros se mantienen en una lista en memoria para fines de demostración.
- Las vistas usan Tag Helpers y validación del lado servidor según lo solicitado.

