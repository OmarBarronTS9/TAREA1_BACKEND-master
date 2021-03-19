using System;
using TAREA1_BACKEND.Northwind;

public class DBSC
{
	public DBSC()
	{
		//Creamos una clase específicamente para conectar el dbcontext de una manera mas segura
		//cumpliendo asi el principio de solid de Responsabilidad Unica y de Abierto/Cerrado al momento de negar el acceso a nuestro context
		protected NorthwindContext context = new NorthwindContext();
	}
}
