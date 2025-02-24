using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class CuentaBancaria 
{

public string NumeroCuenta {get; set;}
public string Titular {get; set;}//Propiedades de la clase
public decimal Saldo {get; set;}

public CuentaBancaria(string numeroCuenta, string titular, decimal saldo)
{
    NumeroCuenta = numeroCuenta;
    Titular = titular;
    Saldo = saldo; 
}

    public override string ToString()
    {
        return $"Cuenta: {NumeroCuenta}, Titular: {Titular}, Saldo: {Saldo:c}";
    }

}

public class Banco
{
    private List<CuentaBancaria> cuentas;
    public Banco(){
        cuentas = new List<CuentaBancaria>();


    }

    public void AgregarCuenta(CuentaBancaria cuenta){
        cuentas.Add(cuenta);       
    }

    public void EliminarCuenta(string numeroCuenta){
        cuentas.RemoveAll(c => c.NumeroCuenta == numeroCuenta);
    }
    
    public void MostrarCuentas()
    {
        foreach (var cuenta in cuentas)
        {
            Console.WriteLine(cuenta);
        }
    }

    // Método para calcular el saldo total de todas las cuentas de manera recursiva
    public decimal CalcularSaldoTotal()
    {
        return CalcularSaldoTotalRecursivo(cuentas, 0);
    }

    private decimal CalcularSaldoTotalRecursivo(List<CuentaBancaria> cuentas, int indice)
    {
        if (indice >= cuentas.Count)
        {
            return 0;
        }
        return cuentas[indice].Saldo + CalcularSaldoTotalRecursivo(cuentas, indice + 1);
    }
}
public class Program
{
    public static void Main()
    {
        Banco banco = new Banco();
        banco.AgregarCuenta(new CuentaBancaria("123", "Juan Pérez", 1500.75m));
        banco.AgregarCuenta(new CuentaBancaria("456", "María López", 2300.50m));
        banco.AgregarCuenta(new CuentaBancaria("789", "Carlos Gómez", 450.25m));

        Console.WriteLine("Información de todas las cuentas:");
        banco.MostrarCuentas();

        Console.WriteLine($"\nSaldo total de todas las cuentas: {banco.CalcularSaldoTotal():C}");
    }
}