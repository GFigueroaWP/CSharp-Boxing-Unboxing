//Crea una aplicación de consola y sigue las siguientes instrucciones para descomprimir de forma segura una matriz de Objetos. ​
//Create an empty List of type object
List<object> box = new List<object>();
//Add the following values to the list: 7, 28, -1, true, "chair"
box.Add(7);
box.Add(28);
box.Add(-1);
box.Add(true);
box.Add("chair");
//Loop through the list and print all values
foreach (var item in box)
{
    Console.WriteLine(item);
}
//Add all values that are Int type together and output the sum
int sum = 0;
foreach (var item in box)
{
    if (item is int)
    {
        sum += (int)item;
    }
}
Console.WriteLine($"La suma de los enteros es: {sum}");