int dato1 = 16;
string dato2 = "25g";
int resultado;

try
{
    resultado = dato1 + Convert.ToInt32(dato2);
    Console.WriteLine("El resultado es: " + resultado);
}
catch (Exception ex)
{
    Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
}


// ALUMNO: JOSE SAUL SIBRIAN SERRANO