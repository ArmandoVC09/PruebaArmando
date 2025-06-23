PROGRAMAS NECESARIOS
1. SQL EXPRESS 2019: https://download.microsoft.com/download/7/f/8/7f8a9c43-8c8a-4f7c-9f92-83c18d96b681/SQL2019-SSEI-Expr.exe
2. SSMS 21: https://download.visualstudio.microsoft.com/download/pr/4652b1eb-63f7-432d-84ab-06108c5d7cd7/f3e8b639888cf4e1f5d376ed5ef1b09f8162ed08647f29a74ef0b792fec1c3db/vs_SSMS.exe
3. Visual Studio 2022: https://visualstudio.microsoft.com/es/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030

BASE DE DATOS
1. Descargar el scritp contenido en el correo de la prueba
2. Abrir SSMS 21 con permisos de administrador
3. En la pantalla superior del lado izquierdo, seleccionar la opción "Archivo"
4. En el menú desplegado seleccionar "Abrir"
5. Dentro del menu desplegado seleccionar "Archivo..."
6. Buscar y seleccionar el script
7. Ejecutar el script
8. Ejecutar los siguientes comandos:

  use pruebaArmando
INSERT USUARIOS(nombre,contraseña) VALUES ('admin', 'admin')
INSERT TIPOS_MADERA(nombre) VALUES ('Pino')
INSERT TIPOS_MADERA(nombre) VALUES ('Cedro')
INSERT TIPOS_MADERA(nombre) VALUES ('Encino')

