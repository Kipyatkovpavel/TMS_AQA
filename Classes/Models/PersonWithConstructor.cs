using System.Security.Cryptography.X509Certificates;

namespace Classes.Models;

public class PersonWithConstructor
{
    // Блок полей (переменных)
    public string name = "Undefined";   // имя
    public int age;                     // возраст
    public int surname;

    public PersonWithConstructor()
    {
            name = "Undefined";   // имя
            age = 1;             // возраст
    }
  
    // Блок методов и свойств
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}