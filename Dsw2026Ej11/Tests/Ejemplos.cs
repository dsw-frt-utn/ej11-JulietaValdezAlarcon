namespace Dsw2026Ej11.Tests;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList lista = new CasoList();
        lista.Agregar(new Alumno(58383, "Julieta Valdez", 6.3));
        lista.Agregar(new Alumno(58384, "Marilina Valdez", 7.8));
        lista.Agregar(new Alumno(58385, "Mirta Alarcon", 5.9));
        Console.WriteLine("=== Lista de alumnos ===");
        foreach (var a in lista.GetAlumnos())
            Console.WriteLine(a);
        Console.WriteLine("\n=== Buscar 'Marilina Valdez' ===");
        var encontrado = lista.BuscarPorNombre("Marilina Valdez");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");
        Console.WriteLine("\n=== Buscar 'Carlos Valdez' ===");
        var noEncontrado = lista.BuscarPorNombre("Carlos Valdez");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");
        Console.WriteLine("\n=== Eliminar 'Marilina Valdez' ===");
        lista.Eliminar(encontrado!);
        foreach (var a in lista.GetAlumnos())
            Console.WriteLine(a);
        Console.WriteLine("\n=== Eliminar primer elemento ===");
        lista.EliminarEnPosicion(0);
        foreach (var a in lista.GetAlumnos())
            Console.WriteLine(a);
    }
    public static void EjemploDictionary()
    {
        CasoDictionary dic = new CasoDictionary();
        dic.Agregar(new Alumno(58383, "Julieta Valdez", 6.3));
        dic.Agregar(new Alumno(58384, "Marilina Valdez", 7.8));
        dic.Agregar(new Alumno(58385, "Mirta Alarcon", 5.9));
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in dic.GetAlumnos())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");
        Console.WriteLine("\n=== Buscar legajo 58384 ===");
        var encontrado = dic.BuscarPorLegajo(58384);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");
        Console.WriteLine("\n=== Buscar legajo 99999 ===");
        var noEncontrado = dic.BuscarPorLegajo(99999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");
        Console.WriteLine("\n=== Eliminar legajo 58383 ===");
        dic.Eliminar(58383);
        foreach (var par in dic.GetAlumnos())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");
    }
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();
        Console.WriteLine($"Primero: {linq.GetPrimero().Titulo}");
        Console.WriteLine($"Último: {linq.GetUltimo().Titulo}");
        Console.WriteLine($"Total precios: {linq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio precios: {linq.GetPromedioPrecios():C}");
        Console.WriteLine("\n=== Libros con Id > 15 ===");
        linq.GetListById().ForEach(l => Console.WriteLine(l.Titulo));
        Console.WriteLine("\n=== Título y precio ===");
        linq.GetLibros().ForEach(Console.WriteLine);
        Console.WriteLine($"\nMayor precio: {linq.GetMayorPrecio().Titulo}");
        Console.WriteLine($"Menor precio: {linq.GetMenorPrecio().Titulo}");
        Console.WriteLine("\n=== Libros sobre el promedio ===");
        linq.GetMayorPromedio().ForEach(l => Console.WriteLine(l.Titulo));
        Console.WriteLine("\n=== Ordenados por título descendente ===");
        linq.GetOrdenadosPorTituloDesc().ForEach(l => Console.WriteLine(l.Titulo));
    }
}
