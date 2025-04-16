using System;

class supermercado
{
    public string nombre;
    public string ubicacion;

    public supermercado(string Nombre, string Ubicacion)
    {
        nombre = Nombre;
        ubicacion = Ubicacion;
    }
}

class productos
{
    public string nombre;
    public float precio;
    public int stock;

    public productos(string Nombre, float Precio, int Stock)
    {
        nombre = Nombre;
        precio = Precio;
        stock = Stock;
    }

    public void mostrarStock()
    {
        Console.WriteLine($"Quedan {stock} de {nombre}");
    }
}

class bebida : productos
{
    public bebida(string nombre, float precio, int stock) : base(nombre, precio, stock) { }

    public void venta()
    {
        Console.WriteLine($"Ingrese el producto a vender: {nombre}\n El precio es: {precio}");
    }
    public void descontarStock(int cantidad)
    {
        stock -= cantidad;
    }
}

class alimento : productos
{
    public alimento(string nombre, float precio, int stock) : base(nombre, precio, stock) { }

    public void venta()
    {
        Console.WriteLine($"Ingrese el producto a vender: {nombre}\n El precio es: {precio}");
    }
    public void descontarStock(int cantidad)
    {
        stock -= cantidad;
    }
}

class figura
{
    public float area;

    public void mostrarArea()
    {
        Console.WriteLine($"El area es: {area}");
    }
}

class triangulo : figura
{
    public void mostrarArea(float baseTriangulo, float altura)
    {
        area = (baseTriangulo * altura) / 2;
        Console.WriteLine($"El area es {area}");
    }
}

class cuadrado : figura
{
    public void mostrarArea(float lado)
    {
        area = lado * lado;
        Console.WriteLine($"El area es {area}");
    }
}

class circulo : figura
{
    public void mostrarArea(float radio)
    {
        area = (float)(Math.PI * radio * radio);
        Console.WriteLine($"El area es {area}");
    }
}

class cuenta
{
    public string numeroCuenta;
    public string nombre;
    public float saldo;
    public string estadoCuenta;

    public cuenta(string NumeroCuenta, string Nombre, float Saldo, string estado)
    {
        numeroCuenta = NumeroCuenta;
        nombre = Nombre;
        saldo = Saldo;
        estadoCuenta = estado;
    }
    public void ingresarMonto(int montoASumar)
    {
        saldo += (float)montoASumar;
    }
    public void retirarMonto(int montoARestar)
    {
        saldo -= montoARestar;
    }
    public void mostrarInfo()
    {
        Console.WriteLine($"Nro de cuenta: {numeroCuenta}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Estado de cuenta: {estadoCuenta}");
    }
}

class cuentaMayor : cuenta
{
    public cuentaMayor(string NumeroCuenta, string Nombre, float Saldo, string estado) : base(NumeroCuenta, Nombre, Saldo, estado) { }
    public void esMayor(int edad)
    {
        if (edad >= 18)
        {
            Console.WriteLine("Es mayor");
        }
        else
        {
            Console.WriteLine("Es menor");
        }
    }
}

class cuentaMenor : cuenta
{
    public cuentaMenor(string NumeroCuenta, string Nombre, float Saldo, string estado) : base(NumeroCuenta, Nombre, Saldo, estado) { }
}

class cuentaEstudiante : cuenta
{
    public cuentaEstudiante(string NumeroCuenta, string Nombre, float Saldo, string estado) : base(NumeroCuenta, Nombre, Saldo, estado) { }
}

class empleado
{
    public string nombre;
    public string apellido;
    public string telefono;
    public string email;
    public int dni;
    public float sueldo;

    public empleado(string Nombre, string Apellido, string tel, string Email, int DNI, float Sueldo)
    {
        nombre = Nombre;
        apellido = Apellido;
        telefono = tel;
        email = Email;
        dni = DNI;
        sueldo = Sueldo;
    }
}

class dptoSistemas : empleado
{
    public string area;
    public bool titulo;
    public bool compu;
    public int genteACargo;

    public dptoSistemas(string Nombre, string Apellido, string tel, string Email, int DNI, float Sueldo, string Area, bool Titulo, bool computadora, int gente) : base(Nombre, Apellido, tel, Email, DNI, Sueldo)
    {
        area = Area;
        titulo = Titulo;
        compu = computadora;
        genteACargo = gente;
    }
}

class programador : empleado
{
    public string lenguaje;
    public string nivel;
    public int vecesTumboProduccion;
    public dptoSistemas departamento;

    public programador(string Lenguaje, string Nivel, int tumbo, string Nombre, string Apellido,
    string tel, string Email, int DNI, float Sueldo, dptoSistemas depto) : base(Nombre, Apellido, tel, Email, DNI, Sueldo)
    {
        lenguaje = Lenguaje;
        nivel = Nivel;
        vecesTumboProduccion = tumbo;
        departamento = depto;
    }
    public void mostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Apellido: {apellido}");
        Console.WriteLine($"Telefono: {telefono}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"DNI: {dni}");
        Console.WriteLine($"Sueldo: {sueldo}");
        Console.WriteLine($"Lenguaje: {lenguaje}");
        Console.WriteLine($"Experiencia: {nivel}");
        Console.WriteLine($"Area: {departamento.area}");
        Console.WriteLine($"Tiene titulos: {departamento.titulo}");
        Console.WriteLine($"Tiene computadora: {departamento.compu}");
        Console.WriteLine($"Cuanta gente tiene a cargo: {departamento.genteACargo}");
    }

}

class ambiente
{
    public string sistemaOperativo;
    public int ram;
    public string baseDatos;
    public string app;

    public ambiente(string sistema, int RAM, string bd, string APP)
    {
        sistemaOperativo = sistema;
        ram = RAM;
        baseDatos = bd;
        app = APP;
    }
    public void verificarDespliegue()
    {
        if (sistemaOperativo == "linux" && ram == 4 && baseDatos == "postgresql" && app == "OpenJDK")
        {
            Console.WriteLine("Despliegue realizado");
        }
        else
        {
            Console.WriteLine("No se puede realizar el despliegue");
        }
    }
}

class persona
{
    public string nombre;
    public int edad;

    public persona(string Nombre, int Edad)
    {
        nombre = Nombre;
        edad = Edad;
    }
    public void compararEdad(persona otraPersona)
    {
        if (edad > otraPersona.edad)
        {
            Console.WriteLine($"{nombre} es mayor que {otraPersona.nombre} ");
        }
        else if (edad < otraPersona.edad)
        {
            Console.WriteLine($"{otraPersona.nombre} es mayor que {nombre} ");
        }
        else
        {
            Console.WriteLine($"{nombre} tiene la misma edad que {otraPersona.nombre}");
        }
    }
}

class tren
{
    public string nombre;
    public int anio;
    public int capacidad;

    public tren(string Nombre, int Anio, int Capacidad)
    {
        nombre = Nombre;
        anio = Anio;
        capacidad = Capacidad;

    }
}

class vagon : tren
{
    public vagon(string nombreTren, int anioTren, int capacidadTren) : base(nombreTren, anioTren, capacidadTren)
    {
    }


    public void vagonLleno()
    {
        Console.WriteLine("Vagon lleno");
    }
    public void acelerar(int velocidad)
    {
        if (velocidad > 0)
        {
            Console.WriteLine("Tren acelerando");
        }
    }
    public void frenar()
    {
        Console.WriteLine("Tren frenando");
    }
}

class program
{
    static void Main(string[] args)
    {
        supermercado super = new supermercado("Jumbo", "Av san martin 1400");

        alimento pan = new alimento("Bimbo", 150, 20);
        pan.mostrarStock();
        pan.venta();
        pan.descontarStock(5);
        pan.mostrarStock();  

        bebida jugo = new bebida("Aquarius", 50, 15);
        jugo.mostrarStock();
        jugo.venta();
        jugo.descontarStock(10);
        jugo.mostrarStock();

        triangulo t = new triangulo();
        t.mostrarArea(10, 2);

        cuadrado c = new cuadrado();
        c.mostrarArea(3);

        circulo ci = new circulo();
        ci.mostrarArea(10);

        cuenta cuenta1 = new cuenta("125", "Juan", 1500, "activo");
        cuenta1.mostrarInfo();
        cuenta1.ingresarMonto(550);
        cuenta1.retirarMonto(200);
        cuenta1.mostrarInfo();

        cuentaMayor cMayor = new cuentaMayor("1248", "Maria", 2000, "activo");
        cMayor.esMayor(20);
        cMayor.mostrarInfo();

        cuentaMenor cMenor = new cuentaMenor("12435", "Jose", 154, "activo");
        cMenor.mostrarInfo();

        cuentaEstudiante ce = new cuentaEstudiante("454", "Pepe", 50, "activo");
        ce.mostrarInfo();

        empleado emp = new empleado("Pedro", "Perez", "1145652", "pedroperez@gmail.com", 12345678, 12500);

        dptoSistemas dpto = new dptoSistemas("Pedro", "Perez", "1145652", "pedroperez@gmail.com", 12345678, 12500, "Sistemas", true, true, 5);


        programador prog = new programador("Java", "Senior", 3, "Juan", "Perez", "1145652", "pedroperez@gmail.com", 12345678, 12500, dpto);
        prog.mostrarInfo();

        ambiente amb = new ambiente("Linux", 4, "PostgreSQL", "OpenJDK");
        amb.verificarDespliegue();

        persona per1 = new persona("Juan", 20);
        persona per2 = new persona("Maria", 18);
        per1.compararEdad(per2);

        tren miTren = new tren("x", 2010, 50); 

        vagon v = new vagon(miTren.nombre, miTren.anio, miTren.capacidad);
        v.vagonLleno();
        v.acelerar(10);
        v.frenar();
    }
}
