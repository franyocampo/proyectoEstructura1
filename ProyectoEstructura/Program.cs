// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;

class Program
{
    //declaracion de los arreglos
    static int[] numeroPago = new int[10];
    static DateTime[] fecha = new DateTime[10];
    static string[] cedula = new string[10];
    static string[] nombre = new string[10];
    static string[] apellido1 = new string[10];
    static string[] apellido2 = new string[10];
    static int[] numeroCaja = new int[10];
    static int[] tipoServicio = new int[10];
    static int[] numeroFactura = new int[10];
    static double[] montoPagar = new double[10];
    static double[] montoComision = new double[10];
    static double[] montoDeducido = new double[10];
    static double[] montoPagaCliente = new double[10];

    //la variable cantidadPagos es la encargada de contabilizar y controlar que los vectores registren 10 datos cada uno
    static int cantidadPagos = 0; //se inicializó en  0

    static void Main(string[] args)

    {
        int opcion; //Inicializamos la variable

        do
        {

            Console.WriteLine("----------TIENDA LA FAVORITA----------");
            Console.WriteLine("----------MENÚ PRINCIPAL----------" +
                "");
            Console.WriteLine("1- Inicializar Vectores");
            Console.WriteLine("2- Realizar Pagos");
            Console.WriteLine("3- Consultar Pagos");
            Console.WriteLine("4- Modificar Pagos");
            Console.WriteLine("5- Eliminar Pagos");
            Console.WriteLine("6- Submenú Reportes");
            Console.WriteLine("7- Salir");
            Console.Write("Digite el número de la opción que deseas realizar: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion) //este switch es el que se encarga de reconocer si el numero digitado corresponde a una opcion válida del menú
            {
                case 1:
                    InicializarVectores();
                    break;
                case 2:
                    RealizarPagos();
                    break;
                case 3:
                    ConsultarPagos();
                    break;
                case 4:
                    ModificarPagos();
                    break;
                case 5:
                    EliminarPagos();
                    break;
                case 6:
                    SubmenuReportes();
                    break;
                case 7:
                    Console.WriteLine("SALIR");
                    break;
                default:
                    Console.WriteLine("Error. Por favor digite una opción válida");
                    break;
            }

        } while (opcion != 7);


        static void InicializarVectores()
        {
            Console.Clear();

            Array.Clear(numeroPago, 0, numeroPago.Length);
            Array.Clear(fecha, 0, fecha.Length);
            Array.Clear(cedula, 0, cedula.Length);
            Array.Clear(nombre, 0, nombre.Length);
            Array.Clear(apellido1, 0, apellido1.Length);
            Array.Clear(apellido2, 0, apellido2.Length);
            Array.Clear(numeroCaja, 0, numeroCaja.Length);
            Array.Clear(tipoServicio, 0, tipoServicio.Length);
            Array.Clear(numeroFactura, 0, numeroFactura.Length);
            Array.Clear(montoPagar, 0, montoPagar.Length);
            Array.Clear(montoComision, 0, montoComision.Length);
            Array.Clear(montoDeducido, 0, montoDeducido.Length);
            Array.Clear(montoPagaCliente, 0, montoPagaCliente.Length);
            cantidadPagos = 0;
            Console.WriteLine("**********Vectores Inicializados**********");
            Console.WriteLine("Digite cualquier tecla para volver al menú principal");
            Console.ReadKey();
            Console.Clear();


        }

        static void RealizarPagos()
        {

            do
            {
                Console.Clear();
                if (cantidadPagos >= 10)
                {
                    Console.WriteLine("*********Vectores Llenos***********");
                    Console.WriteLine("Pulsa cualquier tecla para volver al menú principal");
                    Console.ReadKey();
                    Console.Clear();
                    Main(new string[0]);
                    return;
                }

                Console.WriteLine("Por favor, ingrese los datos que se le solicitan:");

                Console.Write("Digite el número de Tipo de Servicio (1- Recibo de Luz, 2- Recibo Teléfono, 3- Recibo de Agua): ");
                int tipoIngresado;//se declara esta variable que guarda el numero del tipo de servicio

                do//se realiza este do para comprobar primero que el numero ingresado sea del 1 al 3 de lo contrario no realizará el registro
                {
                    if (!int.TryParse(Console.ReadLine(), out tipoIngresado))//acá se verifica que se ingresó pueda convertirse a un entero
                    {
                        Console.WriteLine("***Por favor, ingrese un número válido***");
                        continue;
                    }

                    if (tipoIngresado < 1 || tipoIngresado > 3)//este if es para comprobar si el num ingresado no es un numero del 1 al 3
                    {
                        Console.WriteLine("***Por favor, digite un número del 1 al 3***");
                    }
                } while (tipoIngresado < 1 || tipoIngresado > 3);

                tipoServicio[cantidadPagos] = tipoIngresado;



                string cedulaIngresada;
                do
                {
                    Console.Write("digite Número de Cédula: ");
                    cedulaIngresada = Console.ReadLine();

                    if (!int.TryParse(cedulaIngresada, out _))
                    {
                        Console.WriteLine("***Por favor, ingrese solo números para la cédula.***");
                    }
                } while (!int.TryParse(cedulaIngresada, out _));
                cedula[cantidadPagos] = cedulaIngresada;


                Console.Write("Digite su nombre: ");
                string nombreIngresado;
                do
                {
                    nombreIngresado = Console.ReadLine();
                    bool contieneSoloLetras = nombreIngresado.All(char.IsLetter);
                    if (!contieneSoloLetras)
                    {
                        Console.WriteLine("***Sólo se permiten letras, ingrese nuevamente su nombre.***");
                    }
                } while (!nombreIngresado.All(char.IsLetter));
                nombre[cantidadPagos] = nombreIngresado;



                Console.Write("Digite su Primer Apellido: ");
                string Apellido1Ingresado;
                do
                {
                    Apellido1Ingresado = Console.ReadLine();
                    bool contieneSoloLetras = Apellido1Ingresado.All(char.IsLetter);
                    if (!contieneSoloLetras)
                    {
                        Console.WriteLine("***Sólo se permiten letras, ingrese nuevamente su primer apellido.***");
                    }
                } while (!Apellido1Ingresado.All(char.IsLetter));
                apellido1[cantidadPagos] = Apellido1Ingresado;




                Console.Write("Digite su Segundo Apellido: ");
                string Apellido2Ingresado;
                do
                {
                    Apellido2Ingresado = Console.ReadLine();

                    bool contieneSoloLetras = Apellido2Ingresado.All(char.IsLetter);

                    if (!contieneSoloLetras)
                    {
                        Console.WriteLine("***Sólo se permiten letras, ingrese nuevamente su segundo apellido***");
                    }
                } while (!Apellido2Ingresado.All(char.IsLetter));
                apellido2[cantidadPagos] = Apellido2Ingresado;



                do
                {
                    Console.Write("Ingrese el Número de Factura: ");
                    if (!int.TryParse(Console.ReadLine(), out int numFactura))
                    {
                        Console.WriteLine("***Por favor, ingrese un numero de factura válido***");
                    }
                    else
                    {
                        // este array verifica si el número de factura ya existe en el arreglo
                        if (Array.Exists(numeroFactura, factura => factura == numFactura))
                        {
                            Console.WriteLine("***Ingresó un número de factura existente, digite otro número de factura***");
                        }
                        else
                        {
                            // Asignarle el número de factura al arreglo y salir del bucle
                            numeroFactura[cantidadPagos] = numFactura;
                            break;
                        }
                    }
                } while (true);



                double montoFactura;
                do
                {
                    Console.Write("Digite el monto de la factura: ");
                    if (!double.TryParse(Console.ReadLine(), out montoFactura) || montoFactura <= 0)
                    {
                        Console.WriteLine("***Por favor, ingrese un monto de factura válido***");
                        continue;
                    }
                } while (montoFactura <= 0);



                double montoaPagar;
                Console.Write("Digite con cuánto paga: ");
                do
                {
                    if (!double.TryParse(Console.ReadLine(), out montoaPagar) || montoaPagar <= 0)
                    {
                        Console.WriteLine("  ***Por favor, ingrese un monto de pago válido***  ");
                        continue;
                    }

                    if (montoaPagar < montoFactura)
                    {
                        Console.WriteLine("  ***Su pago no puede procesarse, el monto a pagar debe ser mayor o igual al monto de la factura***  ");
                        Console.WriteLine("  ***Ingrese nuevamente con cuánto desea realizar el pago.***  ");
                    }
                } while (montoaPagar < montoFactura);

                montoPagar[cantidadPagos] = montoFactura;
                montoPagaCliente[cantidadPagos] = montoaPagar;

                double vuelto = Montovueltos(cantidadPagos);

                montoComision[cantidadPagos] = CalcularComision(tipoServicio[cantidadPagos], montoPagar[cantidadPagos]);
                montoDeducido[cantidadPagos] = montoPagar[cantidadPagos] - montoComision[cantidadPagos];

                Console.WriteLine($"Su Factura es de: {montoFactura} Paga con: {montoPagaCliente[cantidadPagos]}, su vuelto: {vuelto}");
                numeroPago[cantidadPagos] = cantidadPagos + 1;
                fecha[cantidadPagos] = DateTime.Now;
                numeroCaja[cantidadPagos] = new Random().Next(1, 4);
                cantidadPagos++; // Incrementar la cantidad de pagos realizados
                Console.WriteLine("         Pago realizado con éxito, gracias por su preferencia.      ");
                Console.WriteLine("---------------------------------------------------------------------");

                // Preguntar al usuario si desea registrar otro pago
                Console.WriteLine("                                     ");
                Console.Write("Digite 1 si desea realizar otro pago, o presione cualquier otra tecla para volver al Menú principal ");
                string respuesta = Console.ReadLine().ToUpper(); //aqui convierte la respuesta a numeros para compararla
                Console.Clear();
                if (respuesta != "1")
                {
                    break; //Salir del bucle si la respuesta no es 1

                }

            } while (true); //aqui El bucle continuara ejecutandose indefinidamente hasta que se termine la ejecucion manualmente
        }

        static double CalcularComision(int tipoServicio, double montoPagar)
        {
            switch (tipoServicio)
            {
                case 1:
                    return montoPagar * 0.04;
                case 2:
                    return montoPagar * 0.055;
                case 3:
                    return montoPagar * 0.065;
                default:
                    return 0.0;
            }
        }

        static double Montovueltos(int cantidadPagos)
        {
            double vuelto = montoPagaCliente[cantidadPagos] - montoPagar[cantidadPagos];
            if (vuelto < 0)
            {
                Console.WriteLine("***El monto pagado es insuficiente.***");
                return 0;
            }
            else
            {
                Console.WriteLine($"El vuelto es: {vuelto}");
                return vuelto;
            }
        }

        static void ConsultarPagos()
        {


            if (cantidadPagos == 0)
            {
                Console.WriteLine("***No existen pagos realizados.***");
                Console.WriteLine("Presiene cualquier tecla para volver al menú principal");
                Console.ReadKey();
                Console.Clear();
                

                return;
            }
            Console.Clear();
            Console.WriteLine("-------CONSULTAR PAGOS--------");
            Console.Write("Ingrese el número de pago que desea consultar: ");
            int numeroPagoConsulta;
            if (!int.TryParse(Console.ReadLine(), out numeroPagoConsulta))
            {
                Console.Clear();
                Console.WriteLine("Error: Por favor, ingrese un número válido.");
                return;
            }


            int indice = Array.IndexOf(numeroPago, numeroPagoConsulta);

            if (indice != -1)
            {
                Console.Clear();
                //si se encuentra el número de pago se va mostrar la información
                Console.WriteLine("===================================================================================");
                Console.WriteLine("          Sistema de Pago de Servicios Publicos");
                Console.WriteLine("          Tienda La Favorita - Consulta de Pagos");
                Console.WriteLine("_____________________________________________________________________________________");
                Console.WriteLine($"Número de Pago: {numeroPago[indice]}");
                Console.WriteLine($"Fecha: {fecha[indice]}");
                Console.WriteLine("                                         ");
                Console.WriteLine("                                         ");
                Console.WriteLine($"Cédula: {cedula[indice]}                            Nombre: {nombre[indice]} ");
                Console.WriteLine($"Primer Apellido: {apellido1[indice]}               Segundo Apellido: {apellido2[indice]}");
                Console.WriteLine("                                                                                          ");
                Console.WriteLine($"Tipo de Servicio: {tipoServicio[indice]}              [1-Electricidad 2-Telefono 3-Agua]");
                Console.WriteLine("                                                                                     ");
                Console.WriteLine($"Número de Factura: {numeroFactura[indice]}         Monto a Pagar: {montoPagar[indice]}");
                Console.WriteLine($"Comisión Autorizada: {montoComision[indice]}       Pagó con: {montoPagaCliente[indice]}");
                Console.WriteLine($"Monto Deducido: {montoDeducido[indice]}            Vuelto: {montoPagaCliente[indice] - montoPagar[indice]}");
                Console.WriteLine("===================================================================================");
                Console.WriteLine("Presione cualquier tecla para volver al menú principal");
                Console.ReadKey(); Console.Clear();


            }
            else
            {
                Console.WriteLine($"***El número de pago {numeroPagoConsulta} no existe.***");
                Console.WriteLine("Presione cualquier tecla para volver al menú principal");
                Console.ReadKey(); Console.Clear();


            }
        }


        static void ModificarPagos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número de Pago que desea modificar:");
            int numPagoModificar;

            if (!int.TryParse(Console.ReadLine(), out numPagoModificar))
            {
                Console.WriteLine("ERROR: Por favor, ingrese un número válido.");
                Console.WriteLine("Presione cualquier tecla para volver al menú principal");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            int indice = Array.IndexOf(numeroPago, numPagoModificar);

            if (indice != -1)
            {
                Console.WriteLine($"Dato Encontrado en la Posición Vector: {indice}");
                Console.WriteLine("Presiona una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

                bool salir = false;

                while (!salir)
                {
                    ImprimirInformacionPago(indice);


                    Console.WriteLine("Seleccione la opción a modificar o presione ´S´ para volver al Menú Principal: ");
                    string opcion = Console.ReadLine();

                    switch (opcion.ToLower())
                    {
                        case "a":
                            fecha[indice] = DateTime.Now;
                            break;
                        case "c":
                            ModificarDatoPago("Cédula", indice, cedula);
                            break;
                        case "d":
                            ModificarDatoPago("Nombre", indice, nombre);
                            break;
                        case "e":
                            Console.Write("Primer Apellido - Nuevo Dato: ");
                            apellido1[indice] = Console.ReadLine();
                            Console.WriteLine("Primer Apellido Actualizado /Enter ");
                            Console.ReadKey();
                            break;
                        case "f":
                            Console.Write("Segundo Apellido - Nuevo Dato: ");
                            apellido2[indice] = Console.ReadLine();
                            Console.WriteLine("Segundo Apellido Actualizado /Enter ");
                            Console.ReadKey();
                            break;
                        case "g":

                            Console.Write("Tipo de Servicio - Nuevo Dato: ");
                            int tipoIngresado;//se declara esta variable que guarda el numero del tipo de servicio

                            do//se realiza este do para comprobar primero que el numero ingresado sea del 1 al 3 de lo contrario no realizará el registro
                            {
                                //cuando se ingresa datos en blanco
                                if (!int.TryParse(Console.ReadLine(), out tipoIngresado))//acá se verifica que se ingresó pueda convertirse a un entero
                                {
                                    Console.WriteLine("***Por favor, ingrese un número válido***");
                                    continue;
                                }
                                //cuando ingreso numero pero no esta dentro el rango. 
                                if (tipoIngresado < 1 || tipoIngresado > 3)//este if es para comprobar si el num ingresado no es un numero del 1 al 3
                                {
                                    Console.WriteLine("***Por favor, ingrese un número del 1 al 3***");
                                }
                            } while (tipoIngresado < 1 || tipoIngresado > 3);

                            tipoServicio[indice] = tipoIngresado;
                            Console.WriteLine("Tipo de Servicio Actualizado / Presione Enter ");
                            Console.ReadKey();
                            break;
                        case "h":
                            Console.Write("Ingrese el nuevo número de factura:");
                            if (int.TryParse(Console.ReadLine(), out int nuevoNumeroFactura))
                            {
                                numeroFactura[indice] = nuevoNumeroFactura;
                                Console.WriteLine("Número de factura actualizado. Presione Enter");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("***Error: Ingrese un número válido para el número de factura. Presione Enter para continuar***");
                                Console.ReadKey();
                            }
                            break;

                        case "i":

                            double pagocliente;

                            do
                            {

                                Console.WriteLine("Paga con - Nuevo Dato: ");
                                pagocliente = Convert.ToDouble(Console.ReadLine());

                                if (pagocliente < montoPagar[indice])
                                {
                                    Console.WriteLine("***Su pago no puede procesarse, debido a que el monto a pagar es mayor.***");
                                }

                            } while (pagocliente < montoPagar[indice]);

                            montoPagaCliente[indice] = pagocliente;
                            Console.Write("Pago cliente actualizado / Presione Enter ");
                            Console.ReadKey();
                            break;
                        case "s":
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("***Opción no válida. Inténtalo de nuevo***");
                            break;
                    }
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("***Número de pago no encontrado***");
            }
        }

        static void ImprimirInformacionPago(int indice)
        {
            Console.WriteLine("===================================================================================");
            Console.WriteLine("          Sistema de Pago de Servicios Publicos");
            Console.WriteLine("          Tienda La Favorita - Modificar Pagos");
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine($"Número de Pago:   {numeroPago[indice]}");
            Console.WriteLine($"A-Fecha:    {fecha[indice]}");
            Console.WriteLine("                                         ");
            Console.WriteLine("                                         ");
            Console.WriteLine($"C-Cédula: {cedula[indice]}                      D-Nombre: {nombre[indice]} ");
            Console.WriteLine($"E-Primer Apellido: {apellido1[indice]}          F-Segundo Apellido: {apellido2[indice]}");
            Console.WriteLine("                                         ");
            Console.WriteLine($"G-Tipo de Servicio: {tipoServicio[indice]}                  [1-Electricidad 2-Telefono 3-Agua");
            Console.WriteLine("                                         ");
            Console.WriteLine($"H-Número de Factura: {numeroFactura[indice]}       Monto a Pagar: {montoPagar[indice]}");
            Console.WriteLine($"Comisión Autorizada: {montoComision[indice]}          I-Paga con: {montoPagaCliente[indice]}");
            Console.WriteLine($"Monto Deducido: {montoDeducido[indice]}               Vuelto: {montoPagaCliente[indice] - montoPagar[indice]}");
            Console.WriteLine("===================================================================================");
        }

        static void ModificarDatoPago(string dato, int indice, string[] arreglo)
        {
            Console.Write($"{dato} - Nuevo Dato: ");
            arreglo[indice] = Console.ReadLine();
            Console.WriteLine($"{dato} Actualizado /Presione Enter");
            Console.ReadKey();
        }

        static void EliminarPagos()
        {

            Console.Write("Ingrese el número de pago a eliminar: ");
            int numeroPagoEliminar = Convert.ToInt32(Console.ReadLine());

            int indiceEliminar = Array.IndexOf(numeroPago, numeroPagoEliminar);

            if (indiceEliminar != -1)
            {
                Console.WriteLine($"Dato Encontrado en la posición Vector : {indiceEliminar}");
                Console.WriteLine(); // Espacios en blanco
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("===================================================================================");
                Console.WriteLine("          Sistema de Pago de Servicios Publicos");
                Console.WriteLine("          Tienda La Favorita - Eliminar Pagos");
                Console.WriteLine("___________________________________________________________________________________");
                Console.WriteLine($"Número de Pago:   {numeroPago[indiceEliminar]}");
                Console.WriteLine($"Fecha:    {fecha[indiceEliminar]}");
                Console.WriteLine("                                         ");
                Console.WriteLine("                                         ");
                Console.WriteLine($"Cédula:    {cedula[indiceEliminar]}          Nombre:    {nombre[indiceEliminar]} ");
                Console.WriteLine($"Primer Apellido: {apellido1[indiceEliminar]}         Segundo Apellido: {apellido2[indiceEliminar]}");
                Console.WriteLine("                                         ");
                Console.WriteLine($"Tipo de Servicio: {tipoServicio[indiceEliminar]} ");
                Console.WriteLine("                                         ");
                Console.WriteLine($"Número de Factura: {numeroFactura[indiceEliminar]}          Monto a Pagar: {montoPagar[indiceEliminar]}");
                Console.WriteLine($"Comisión Autorizada: {montoComision[indiceEliminar]}          Paga con: {montoPagaCliente[indiceEliminar]}");
                Console.WriteLine($"Monto Deducido:  {montoDeducido[indiceEliminar]}             Vuelto: {montoPagaCliente[indiceEliminar] - montoPagar[indiceEliminar]}");
                Console.WriteLine("===================================================================================");
                Console.Write("Desea Elimimar el Registro S/N: ");
                string opcion = Console.ReadLine();

                if (opcion.ToLower() == "s")
                {


                    for (int i = indiceEliminar; i < numeroPago.Length - 1; i++)
                    {


                        numeroPago[i] = numeroPago[i + 1];
                        fecha[i] = fecha[i + 1];
                        cedula[i] = cedula[i + 1];
                        nombre[i] = nombre[i + 1];
                        apellido1[i] = apellido1[i + 1];
                        apellido2[i] = apellido2[i + 1];
                        numeroCaja[i] = numeroCaja[i + 1];
                        tipoServicio[i] = tipoServicio[i + 1];
                        numeroFactura[i] = numeroFactura[i + 1];
                        montoPagar[i] = montoPagar[i + 1];
                        montoComision[i] = montoComision[i + 1];
                        montoDeducido[i] = montoDeducido[i + 1];
                        montoPagaCliente[i] = montoPagaCliente[i + 1];

                    }


                    Array.Resize(ref numeroPago, numeroPago.Length - 1);
                    Array.Resize(ref fecha, fecha.Length - 1);
                    Array.Resize(ref cedula, cedula.Length - 1);
                    Array.Resize(ref nombre, nombre.Length - 1);
                    Array.Resize(ref apellido1, apellido1.Length - 1);
                    Array.Resize(ref apellido2, apellido2.Length - 1);
                    Array.Resize(ref numeroCaja, numeroCaja.Length - 1);
                    Array.Resize(ref tipoServicio, tipoServicio.Length - 1);
                    Array.Resize(ref numeroFactura, numeroFactura.Length - 1);
                    Array.Resize(ref montoPagar, montoPagar.Length - 1);
                    Array.Resize(ref montoComision, montoComision.Length - 1);
                    Array.Resize(ref montoDeducido, montoDeducido.Length - 1);
                    Array.Resize(ref montoPagaCliente, montoPagaCliente.Length - 1);

                    Console.Clear();
                    Console.WriteLine("Pago eliminado exitosamente/ Presione Enter");
                    Console.ReadKey();
                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("***No se realizó la operacion/ Presione Enter***");
                    Console.ReadKey();

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("***Número de pago no encontrado / Presione Enter*** ");
                Console.ReadKey();
            }
        }

        static void SubmenuReportes()
        {
            Console.Clear();
            int opcion; //esta variable es la encargada de obtener el numero de la operacion que desea realizar

            do
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("----------SUB MENÚ----------");
                Console.WriteLine("1- Ver todos los pagos realizados");
                Console.WriteLine("2- Ver pagos por número de factura");
                Console.WriteLine("3- Ver pagos por numero de caja");
                Console.WriteLine("4- Ver monto total de comisiones");
                Console.WriteLine("5- Regresar al menú principal");
                Console.WriteLine("=================================");
                Console.Write("Digite el número de la opción que deseas realizar: ");
                opcion = Convert.ToInt32(Console.ReadLine()); //este metodo convierte un string a numero entero

                switch (opcion) //este switch comprueba que la opcion  sea válida con las opciones del menu y asi se realicen sus metodos
                {
                    case 1:
                        VerPagos();
                        break;
                    case 2:
                        VerPagosPorFacutura();
                        break;
                    case 3:
                        VerPagosPorCaja();
                        break;
                    case 4:
                        VerMontoComision();
                        break;
                    case 5:
                        Main(new string[0]);
                        break;
                    default:
                        Console.WriteLine("Error, por favor, Digite una opción válida");
                        break;
                }

            } while (opcion != 5); //este while es para saber si digita un numero que no está en el menú
            Console.Clear();
        }

        static void VerPagos()
        {

            Console.Clear();
            Console.WriteLine("__________________________________________________________________________________");
            Console.WriteLine("      Sistema de Pago de Servicios Publicos   ");
            Console.WriteLine("       Tienda La Favorita - Todos los Pagos");


            for (int i = 0; i < cantidadPagos; i++)
            {
                if (numeroPago[i] == 0)
                {
                    continue;
                }

                Console.WriteLine("_____________________________________________________________________________________");
                Console.WriteLine($"Número de Pago: {numeroPago[i]}");
                Console.WriteLine($"Fecha: {fecha[i]}");
                Console.WriteLine($"Cédula: {cedula[i]}                            Nombre: {nombre[i]} ");
                Console.WriteLine($"Primer Apellido: {apellido1[i]}               Segundo Apellido: {apellido2[i]}");
                Console.WriteLine($"Tipo de Servicio: {tipoServicio[i]}              [1-Electricidad 2-Teléfono 3-Agua]");
                Console.WriteLine($"Número de Factura: {numeroFactura[i]}      Monto de la Factura: {montoPagar[i]}");
                Console.WriteLine($"Comisión Autorizada: {montoComision[i]}       Pagó con: {montoPagaCliente[i]}");
                Console.WriteLine($"Monto Deducido: {montoDeducido[i]}            Vuelto: {montoPagaCliente[i] - montoPagar[i]}");
                Console.WriteLine("===================================================================================");
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
            Console.Clear();
        }

    }
    static void VerPagosPorFacutura()
    {
        Console.Clear();
        Console.Write("Ingrese el número de factura que desea buscar: ");
        int numeroFacturaBuscar = Convert.ToInt32(Console.ReadLine());

        bool encontrado = false;


        for (int i = 0; i < cantidadPagos; i++)
        {
            if (numeroFactura[i] == numeroFacturaBuscar)
            {
                Console.WriteLine("===================================================================================");
                Console.WriteLine("          Sistema de Pago de Servicios Publicos");
                Console.WriteLine("          Tienda La Favorita - Pagos por Número de Factura");
                Console.WriteLine("________________________________________________________________________________-");
                Console.WriteLine($"Número de Pago: {numeroPago[i]}");
                Console.WriteLine($"Fecha: {fecha[i]}");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                                           ");
                Console.WriteLine($"Cédula: {cedula[i]}                            Nombre: {nombre[i]} ");
                Console.WriteLine($"Primer Apellido: {apellido1[i]}               Segundo Apellido: {apellido2[i]}");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine($"Tipo de Servicio: {tipoServicio[i]}              [1-Electricidad 2-Teléfono 3-Agua]");
                Console.WriteLine("                                                                                     ");
                Console.WriteLine($"Número de Factura: {numeroFactura[i]}      Monto de la Factura: {montoPagar[i]}");
                Console.WriteLine($"Comisión Autorizada: {montoComision[i]}       Pagó con: {montoPagaCliente[i]}");
                Console.WriteLine($"Monto Deducido: {montoDeducido[i]}            Vuelto: {montoPagaCliente[i] - montoPagar[i]}");
                Console.WriteLine("===================================================================================");
                Console.WriteLine("Presione una tecla para volver al menú principal...");
                Console.ReadKey();
                Console.Clear();




                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"***No se encontraron pagos para la factura número {numeroFacturaBuscar}***");
            Console.WriteLine("Presiona una tecla para volver al menú principal");
            Console.ReadKey();
            Console.Clear();


        }
    }

    static void VerPagosPorCaja()
    {
        Console.Clear();
        Console.WriteLine("==================================================================");
        Console.WriteLine("             Sistema de Pago de Servicios Publicos");
        Console.WriteLine("   Tienda La Favorita - Reporte todos los pagos por código de Cajero");
        Console.WriteLine("___________________________________________________________________");

        int numeroCajaBuscar;
        do
        {
            Console.WriteLine("Digite el Código del Cajero:      [1]Caja#1        [2]Caja#2         [3]Caja#3  ");
            Console.WriteLine("====================================================================");
          

            bool conversionExitosa = int.TryParse(Console.ReadLine(), out numeroCajaBuscar);
            if (!conversionExitosa || numeroCajaBuscar < 1 || numeroCajaBuscar > 3)
            {
                Console.Clear();
                Console.WriteLine("***El número de caja no es válido. Los códigos de cajeros son 1, 2 o 3.***");
            }
        } while (numeroCajaBuscar < 1 || numeroCajaBuscar > 3);

        
        bool encontrado = false;

    
        Console.WriteLine("===================================================================================");

        
        for (int caja = 1; caja <= 3; caja++)
        {
            
            bool encontradoParaCaja = false;

           
            for (int i = 0; i < cantidadPagos; i++)
            {
                if (numeroCaja[i] == numeroCajaBuscar && numeroCaja[i] == caja)
                {
                    if (!encontrado)
                    {
                        Console.WriteLine("          Tienda La Favorita - Pagos por Número de Caja");
                        Console.WriteLine("_________________________________________________________________________________");
                    }
                    Console.WriteLine($"Número de Pago: {numeroPago[i]}");
                    Console.WriteLine($"Fecha: {fecha[i]}");
                    Console.WriteLine($"Cédula: {cedula[i]}                            Nombre: {nombre[i]} ");
                    Console.WriteLine($"Primer Apellido: {apellido1[i]}               Segundo Apellido: {apellido2[i]}");
                    Console.WriteLine($"Tipo de Servicio: {tipoServicio[i]}              [1-Electricidad 2-Teléfono 3-Agua]");
                    Console.WriteLine($"Número de Factura: {numeroFactura[i]}      Monto de la Factura: {montoPagar[i]}");
                    Console.WriteLine($"Comisión Autorizada: {montoComision[i]}       Pagó con: {montoPagaCliente[i]}");
                    Console.WriteLine($"Monto Deducido: {montoDeducido[i]}            Vuelto: {montoPagaCliente[i] - montoPagar[i]}");
                    Console.WriteLine("======================================================================================");
                    encontrado = true;
                    encontradoParaCaja = true;
                }
            }

            // Si se encontraron pagos para la caja actual, imprimir un mensaje
            if (encontradoParaCaja)
            {
                Console.WriteLine($"Pagos encontrados para la Caja #{caja}");
            }
        }

        // Si no se encontraron pagos para el número de caja especificado
        if (!encontrado)
        {
            Console.WriteLine($"***No se encontraron pagos para el número de caja: {numeroCajaBuscar}***");
        }

        Console.WriteLine("Presiona cualquier tecla para volver al menú principal");
        Console.ReadKey();
        Console.Clear();
    }
    static string ConvertirTipoServicio(int tipoServicio)
    {
        string servicio = "";
        switch (tipoServicio)
        {
            case 1:
                servicio = "Electricidad";
                break;
            case 2:
                servicio = "    Teléfono";
                break;
            case 3:
                servicio = "        Agua";
                break;
            default:
                break;
        }
        return servicio;
    }
    static void VerMontoComision()
    {
        Console.Clear();
        Dictionary<int, (double sumaComisiones, int cantidadTransacciones)> resumenComisiones = new Dictionary<int, (double, int)>();
        double totalComisiones = 0;
        int totalTransacciones = 0;

        for (int i = 0; i < cantidadPagos; i++)
        {
            // Verificar si el pago ha sido eliminado
            if (numeroPago[i] == 0)
            {
                continue; // Saltar esta iteración si el pago ha sido eliminado
            }

            int tipoServicioActual = tipoServicio[i];
            double comisionActual = montoComision[i];

            if (!resumenComisiones.ContainsKey(tipoServicioActual))
            {
                resumenComisiones[tipoServicioActual] = (comisionActual, 1);
            }
            else
            {
                var infoServicio = resumenComisiones[tipoServicioActual];
                double nuevaSumaComisiones = infoServicio.sumaComisiones + comisionActual;
                int nuevaCantidadTransacciones = infoServicio.cantidadTransacciones + 1;
                resumenComisiones[tipoServicioActual] = (nuevaSumaComisiones, nuevaCantidadTransacciones);
            }

            // Actualizar el total de comisiones y transacciones
            totalComisiones += comisionActual;
            totalTransacciones++;
        }

        Console.WriteLine("            Resumen del Dinero Comisionado por Servicio:         ");
        Console.WriteLine("_______________________________________________________________________________");
        Console.WriteLine("ITEM                CANT. TRANSACCIONES           TOTAL COMISIONADO");
        Console.WriteLine("===============================================================================");

        foreach (var kvp in resumenComisiones)
        {
            int tipoServicio = kvp.Key;
            double sumaComisiones = kvp.Value.sumaComisiones;
            int cantidadTransacciones = kvp.Value.cantidadTransacciones;
            string nombreServicio = ConvertirTipoServicio(tipoServicio);

            Console.WriteLine($"{nombreServicio}                   {cantidadTransacciones}                     ${sumaComisiones}");
        }

        Console.WriteLine("===============================================================================");
        Console.WriteLine($"TOTAL                          {totalTransacciones}                     ${totalComisiones}");
        Console.WriteLine("                                                                               ");
        Console.WriteLine("===============================================================================");
        Console.WriteLine("Presione cualquier tecla para volver al menú principal");
        Console.ReadKey();
        Console.Clear();
    }

}


