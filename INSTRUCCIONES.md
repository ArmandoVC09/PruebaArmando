PROGRAMAS NECESARIOS
1. SQL EXPRESS 2019: https://download.microsoft.com/download/7/f/8/7f8a9c43-8c8a-4f7c-9f92-83c18d96b681/SQL2019-SSEI-Expr.exe
2. SSMS 21: https://download.visualstudio.microsoft.com/download/pr/4652b1eb-63f7-432d-84ab-06108c5d7cd7/f3e8b639888cf4e1f5d376ed5ef1b09f8162ed08647f29a74ef0b792fec1c3db/vs_SSMS.exe
3. Visual Studio 2022: https://visualstudio.microsoft.com/es/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030

BASE DE DATOS
1. Descargar el scritp contenido en el correo de la prueba
2. Abrir SSMS 21 con permisos de administrador
3. Iniciar con autenticación windows, poniendo como "Opcional" la opcion "Cifrado"
4. En la pantalla superior del lado izquierdo, seleccionar la opción "Archivo"
5. En el menú desplegado seleccionar "Abrir"
6. Dentro del menu desplegado seleccionar "Archivo..."
7. Buscar y seleccionar el script
8. Ejecutar el script
9. Ejecutar los siguientes comandos:

  use pruebaArmando
  INSERT USUARIOS(nombre,contraseña) VALUES ('admin', 'admin')
  INSERT TIPOS_MADERA(nombre) VALUES ('Pino')
  INSERT TIPOS_MADERA(nombre) VALUES ('Cedro')
  INSERT TIPOS_MADERA(nombre) VALUES ('Encino')

CONEXION DE BASE DE DATOS A VISUAL STUDIO
1. Abrir SSMS 21
2. Iniciar con autenticación windows, poniendo como "Opcional" la opcion "Cifrado"
3. En la ventana de explorador de objetos, dar click derecho en el servidor
4. En el menu desplegado seleccionar la opción "Propiedades"
5. En la información que se muestra, copiar el nombre del servidor
6. Abrir la solución en Visual Studio
7. Entrar a la carpeta "Clases" y abrir la clase "ConexionBD.cs"
8. Modificar de la siguiente manera el valor de la variable "cadenaConexion":
    La cadena tiene la siguiente estructura:
   Data Source=DESKTOP-NFHJLJR\\SQLEXPRESS;Initial Catalog=pruebaArmando;Integrated Security=True;Trust Server Certificate = True;
