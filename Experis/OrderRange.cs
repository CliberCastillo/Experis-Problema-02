Console.WriteLine("Entrada:");
string? texto;
texto = Console.ReadLine();

Build(texto);
Console.ReadKey();

void Build(string? cadena)
{
    var eliminarCorchetes = cadena.Trim(new Char[] { ' ', '[', ']' });
    var lstNumeros = eliminarCorchetes.Split(',').ToList().Select(int.Parse).ToList();

    var numerosPares = new List<int>();
    var numerosImpares = new List<int>();

    foreach (var numero in lstNumeros)
    {
        if (numero % 2 == 0)
            numerosPares.Add(numero);
        else
            numerosImpares.Add(numero);
    }

    var ordenadoNumerosPares = numerosPares.OrderBy(x => x).ToList();
    var ordenadoNumerosImpares = numerosImpares.OrderBy(x => x).ToList();

    if (ordenadoNumerosPares.First() > ordenadoNumerosImpares.First())
        Console.WriteLine("Salida: [{0}] [{1}]", string.Join(",", ordenadoNumerosImpares), string.Join(",", ordenadoNumerosPares));
    else
        Console.WriteLine("Salida: [{0}] [{1}]", string.Join(",", ordenadoNumerosPares), string.Join(",", ordenadoNumerosImpares));

}