
using Polimorfismo.Class;
Empleado empleado = new Empleado();



Console.WriteLine("Seleccione:");
string option = Console.ReadLine();


if (option is "Asalariado") { 
Asalariado asalariado = new Asalariado();

Console.WriteLine("Inserte el primer nombre:");
 asalariado.primerNombre =  Console.ReadLine();

 Console.WriteLine("Inserte el apellido materno");
asalariado.apellidoPaterno = Console.ReadLine();

 Console.WriteLine("Inserte el Numero de Seguridad Social");
asalariado.numeroSeguridadSocial = Convert.ToInt32(Console.ReadLine()); 

  Console.WriteLine("Ingresa el Salario Semanal");
 asalariado.salarioSemanal = Convert.ToInt32(Console.ReadLine());
}




if (option is "EmpleadoPorHoras") { 
EmpleadoPorHoras empleadosPorhora = new EmpleadoPorHoras();


Console.WriteLine("Inserte el primer nombre");
empleadosPorhora.primerNombre = Console.ReadLine();


    Console.WriteLine("Inserte el apellido materno:");
    empleadosPorhora.apellidoPaterno = Console.ReadLine();


    Console.WriteLine("Inserte el Numero de Seguridad Social:");
    empleadosPorhora.numeroSeguridadSocial = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el sueldo por Horas:");
    empleadosPorhora.SueldoPorHoras = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese las horas trabajadas:");
    empleadosPorhora.horasTrabajadas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"El resultado es {empleadosPorhora.resultado}");
}





Comision comision = new Comision();

Console.WriteLine("Inserte el primer nombre:");
comision.primerNombre = Console.ReadLine();

Console.WriteLine("Inserte el Apellido Paterno");
comision.apellidoPaterno = Console.ReadLine();

Console.WriteLine("Inserte el Numero de Seguridad Social");
comision.numeroSeguridadSocial= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserte el Numero de ventas brutas");
comision.ventasBrutas = Convert.ToInt32(Console.ReadLine()); ;

Console.WriteLine("Inserte el tarifario de comisiones");
comision.tarifarioComision = Convert.ToInt32(Console.ReadLine()); ;





EmpleadoMasComision empleadoComision= new EmpleadoMasComision();

Console.WriteLine("Inserte el Primer Nombre");
empleadoComision.primerNombre = Console.ReadLine(); 

Console.WriteLine("Inserte el Apellido Paterno");
empleadoComision.apellidoPaterno = Console.ReadLine();

Console.WriteLine("Inserte el Numero de Seguridad Social");
empleadoComision.numeroSeguridadSocial = Convert.ToInt32(Console.ReadLine()); ;

Console.WriteLine("Inserte el Numero de ventas brutas");
empleadoComision.ventasBrutas= Convert.ToInt32(Console.ReadLine()); ;

Console.WriteLine("Inserte el tarifacrio de comisiones");
empleadoComision.tarifarioComision= Convert.ToInt32(Console.ReadLine()); ;

Console.WriteLine("Inserte el salario Base");
empleadoComision.salarioBase = Convert.ToInt32(Console.ReadLine()); ;


