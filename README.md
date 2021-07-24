# vaccination-system
This project is the task 7-8 of our professor Amadís of programming III

Instrucciones para restaurar la base de datos del proyecto

Bien, vamos a ingresar la base datos en tu ordenador 
para que el proyecto te pueda funcionar.

--SOLUCION CON XAMMP--
Si tienes xammp en tu ordenador, pues es mas facil 
solo debes tomar el archivo covid19.sql e ir al PhpMyAdmim una vez ahi
en el localhost vas a darle a importar una base datos, iras a explorador de 
archivos y seleccionaras la base de datos, le daras a aceptar y se creara 
la base de datos junto a los datos.

ya solamente deberias (teniendo los servicios de apache y mysql encendidos en el xammp)
abrir la aplicacion y disfrutar la app. 

-SOLUCION SIN XAMMP leer antes--
en caso de que no tengas xammp debes dirigirte a tu management de mysql que tengas 
e importar la base de datos desde ahi. 

luego deberias dirigirte a la carpeta del proyecto y borar la carpeta Models, 
luego de haber hecho esto, restaria usar el siguiente comando dentro de la carpeta 
(asegurate de navegar usando "cd" hasta la carpeta base donde estaba la carpeta models 
anteriormente) usando el powershell 

//////// COMANDO DE POMELO PARA MIGRAR //////////
dotnet ef dbcontext scaffold "server=localhost;uid=root;pwd=;database=covid19" Pomelo.EntityFrameworkCore.MySql --output-dir Models --force

deberas sustituir del comando los valores de las variables  
1- server
2- uid 
3- pwd

segun se lo de su servicio de base de datos, 
luego de esto se creara nuevamente la carpeta models para el proyecto 

tambien puede probar, antes de borrar la carpeta Models, ir a la clase 
covid19Context y cambiar los 3 atributos mencionados mas arriba 
con los valores de su maquina, luego de importar la base de datos obviamente, 
asi podria ahorarse (posiblemente) tener que borrar la carpeta de
modelos para restablecer la conexion. 

ya despues de esto restaria abrir la aplicacion y probar. 
para correr la aplicacion si usa visual studio solo deberia darle a iniciar, sino desde la consola usando el comando "dotnet run"
