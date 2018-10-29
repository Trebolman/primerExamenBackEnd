using System;

namespace PrimerExamenBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.WriteLine("PRIMER EXAMEN DE ESTRUCTURALES SECUENCIALES");
            for (int i = 1; i <= 20; i++) { Console.WriteLine($"{i}) Ejercicio {i}."); }
            int salir = 1;
            Console.WriteLine("Ingrese numero de ejercicio a revisar");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Ingrese capital: ");
                    int capital = Convert.ToInt32(Console.ReadLine());
                    if(capital < 0) { goto case 1; }
                    Console.WriteLine($"El monto total con un interés de 2%: {capital + 0.02 * capital}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 1; }
                    break;
                case 2:
                    Console.WriteLine($"Ingrese monto de venta 1: ");
                    double venta1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Ingrese monto de venta 2: ");
                    double venta2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Ingrese monto de venta 3: ");
                    double venta3 = Convert.ToDouble(Console.ReadLine());
                    if(venta1 < 0 && venta2 < 0 && venta3 < 0) { goto case 2; }
                    Console.WriteLine("\n");
                    Console.WriteLine("Sueldo: {0:C}", 930);
                    Console.WriteLine("Comisiones por venta: 10%");
                    Console.WriteLine("El sueldo total que le corresponde es: {0:C}", 930 + (venta1 + venta2 + venta3) * 0.10);

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 2; }
                    break;
                case 3:
                    Console.WriteLine("Ingrese monto de compra: ");
                    double compra = Convert.ToDouble(Console.ReadLine());
                    if (compra < 0) { goto case 3; }
                    Console.WriteLine($"El monto total que pagará con un descuento de 15%: {compra - 0.15 * compra}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 3; }
                    break;
                case 4:
                    Console.WriteLine("Ingrese nota ex. parcial 1: ");
                    double parcial1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota ex. parcial 2: ");
                    double parcial2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota ex. parcial 3: ");
                    double parcial3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota examen final: ");
                    double exFinal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese trabajo final: ");
                    double trabajoFinal = Convert.ToDouble(Console.ReadLine());
                    if(parcial1 < 0 && parcial2 < 0 && parcial3 < 0 && exFinal < 0 && trabajoFinal < 0) { goto case 4; }
                    Console.WriteLine($"La nota final es: {0.55 * (parcial1 + parcial2 + parcial3)/3 + 0.3 * exFinal + 0.15 * trabajoFinal}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 4; }
                    break;
                case 5:
                    Console.WriteLine("Ingrese numero de mujeres: ");
                    double mujeres = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese numero de hombres: ");
                    double hombres = Convert.ToDouble(Console.ReadLine());
                    if(mujeres < 0 && hombres < 0) { goto case 5; }
                    Console.WriteLine($"El porcentaje de mujeres: {mujeres * 100 / (mujeres + hombres)}% \nEl porcentaje de hombres: {hombres * 100 / (mujeres + hombres)}%");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 5; }
                    break;
                case 6:
                    Console.WriteLine("Ingrese año de nacimiento: ");
                    int AñoNacimiento = Convert.ToInt32(Console.ReadLine());
                    if(AñoNacimiento < 0) { goto case 6; }
                    Console.WriteLine($"La edad es: {2018 - AñoNacimiento}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 6; }
                    break;
                case 7:
                    Console.WriteLine("Ingrese cantidad en soles: ");
                    double montoSoles = Convert.ToDouble(Console.ReadLine());
                    if(montoSoles < 0) { goto case 7; }
                    Console.WriteLine($"El monto en dolares es: {montoSoles * 0.3}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 7; }
                    break;
                case 8:
                    Console.WriteLine("Ingrese numero: ");
                    double numero = Convert.ToDouble(Console.ReadLine());
                    if(numero < 0) { numero = numero * (-1); }
                    Console.WriteLine($"Valor absoluto es: {numero}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 8; }
                    break;
                case 9:
                    Console.WriteLine("Ingrese volumen: ");
                    double volumen = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese presion: ");
                    double presion = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese temperatura: ");
                    double temperatura = Convert.ToDouble(Console.ReadLine());
                    if(volumen < 0 || presion < 0) { goto case 9; }
                    Console.WriteLine($"La masa (Kg) total es: {presion * volumen / (0.37 * (temperatura + 460))}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 9; }
                    break;
                case 10:
                    Console.WriteLine("Ingrese edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    if(edad < 0) { goto case 10; }
                    Console.WriteLine($"El numero de pulsaciones es: {(220 - edad)/10}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 10; }
                    break;
                case 11:
                    Console.WriteLine("Ingrese salario anterior: ");
                    double salarioAnterior = Convert.ToDouble(Console.ReadLine());
                    if(salarioAnterior < 0) { goto case 11; }
                    Console.WriteLine($"El nuevo salario (con un aumento del 25%) es: {salarioAnterior + salarioAnterior * 0.25}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 11; }
                    break;
                case 12:
                    Console.WriteLine("Ingrese presupuesto del hospital: ");
                    double presupuestoHospital = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"El presupuesto es {presupuestoHospital} que se dividirá como sigue:");
                    Console.WriteLine($"Ginecología:    {presupuestoHospital * 0.4}");
                    Console.WriteLine($"Traumatología:  {presupuestoHospital * 0.3}");
                    Console.WriteLine($"Pediatría:  {presupuestoHospital * 0.3}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 12; }
                    break;
                case 13:
                    Console.WriteLine("Este item es el mismo que el anterior");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto inicio; }
                    break;
                case 14:
                    Console.WriteLine("Ingrese precio de compra del artículo: ");
                    double precioCompra = Convert.ToDouble(Console.ReadLine());
                    if(precioCompra < 0) { goto case 14; }
                    Console.WriteLine($"El precio al que se ofertará esperando una ganancia del 30% será: {precioCompra + precioCompra * 0.3}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 14; }
                    break;
                case 15:
                    Console.WriteLine("Ingrese tiempo (en horas) del lunes: ");
                    double tiempoLunes = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese tiempo (en horas) del miercoles: ");
                    double tiempoMiercoles = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese tiempo (en horas) del viernes: ");
                    double tiempoViernes = Convert.ToDouble(Console.ReadLine());
                    if(tiempoLunes < 0 || tiempoMiercoles < 0 || tiempoViernes < 0) { goto case 15; }
                    Console.WriteLine($"El el tiempo promedio (en horas) de la semana es: {(tiempoLunes + tiempoMiercoles + tiempoViernes) / 3}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 15; }
                    break;
                case 16:
                    Console.WriteLine("Ingrese inversión de la persona 1: ");
                    double inversion1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese inversión de la persona 2: ");
                    double inversion2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese inversión de la persona 3: ");
                    double inversion3 = Convert.ToDouble(Console.ReadLine());
                    if(inversion1 < 0 || inversion2 < 0 || inversion3 < 0) { goto case 16; }

                    Console.WriteLine("Las ganancias se repartirán según: ");
                    Console.WriteLine($"Porcentaje de la ganancia correspondiente al inversionista 1: {inversion1 * 100 / (inversion1 + inversion2 + inversion3)}");
                    Console.WriteLine($"Porcentaje de la ganancia correspondiente al inversionista 2: {inversion2 * 100 / (inversion1 + inversion2 + inversion3)}");
                    Console.WriteLine($"Porcentaje de la ganancia correspondiente al inversionista 3: {inversion3 * 100 / (inversion1 + inversion2 + inversion3)}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 16; }
                    break;
                case 17:
                    Console.WriteLine("MATEMATICA");
                    Console.WriteLine("Ingrese nota examen: ");
                    double exMat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota tarea 1: ");
                    double tarMat1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota tarea 2: ");
                    double tarMat2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota tarea 3: ");
                    double tarMat3 = Convert.ToDouble(Console.ReadLine());
                    if (exMat < 0 || tarMat1 < 0 || tarMat2 < 0 || tarMat3 < 0) { goto case 17; }

                    fisica:
                    Console.WriteLine("FISICA");
                    Console.WriteLine("Ingrese nota examen: ");
                    double exFis = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota tarea 1: ");
                    double tarFis1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota tarea 2: ");
                    double tarFis2 = Convert.ToDouble(Console.ReadLine());
                    if(exFis < 0 || tarFis1 < 0 || tarFis2 < 0) { goto fisica; }

                    quimica:
                    Console.WriteLine("QUIMICA");
                    Console.WriteLine("Ingrese nota examen: ");
                    double exQuim = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota tarea 1: ");
                    double tarQuim1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota tarea 2: ");
                    double tarQuim2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese nota tarea 3: ");
                    double tarQuim3 = Convert.ToDouble(Console.ReadLine());
                    if(exQuim < 0 || tarQuim1 < 0 || tarQuim2 < 0 || tarQuim3 < 0) { goto quimica; }

                    // Procesos
                    double promMat = 0.9 * exMat + 0.1 * (tarMat1 + tarMat2 + tarMat3)/3;
                    double promFis = 0.8 * exFis + 0.2 * (tarFis1 + tarFis2)/2;
                    double promQuim = 0.85 * exQuim + 0.15 * (tarQuim1 + tarQuim2 + tarQuim3)/3;
                    double promFinal = (promMat + promFis + promQuim) / 3;
                    Console.WriteLine($"El promedio de curso de matematica: {promMat}");
                    Console.WriteLine($"El promedio de curso de fisica: {promFis}");
                    Console.WriteLine($"El promedio de curso de quimica: {promQuim}");
                    Console.WriteLine($"El promedio final es: {promFinal}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 17; }
                    break;
                case 18:
                    Console.WriteLine("Ingrese edad (años): ");
                    int edadAños = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese edad (meses): ");
                    int edadMeses = Convert.ToInt32(Console.ReadLine());
                    if (edadAños < 0 || edadMeses < 0) { goto case 18; }
                    Console.WriteLine($"Edad: {edadAños} años y {edadMeses} meses");
                    Console.WriteLine($"La edad en meses solamente es: {edadAños * 12 + edadMeses}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 18; }
                    break;
                case 19:
                    Console.WriteLine("Ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine($"Profesor {apellido}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 1; }
                    break;
                case 20:
                    Console.WriteLine("Ingrese medida en pies: ");
                    double medidaPies = Convert.ToDouble(Console.ReadLine());
                    if(medidaPies < 0) { goto case 20; }
                    Console.WriteLine($"El monto ingresado en metros es: {medidaPies * 0.3048}");

                    Console.WriteLine("¿Ver de nuevo? Si=1/No=2");
                    salir = Int32.Parse(Console.ReadLine());
                    if (salir == 1) { goto case 1; }
                    break;

            }
            goto inicio;
        }
    }
}
