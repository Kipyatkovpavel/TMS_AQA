// See https://aka.ms/new-console-template for more information
using Interfaces;
using Interfaces.Example;
//- =======================Static
/*
StaticExample obj1 = new StaticExample();
Console.WriteLine($"obj1: StaticVariable =  {StaticExample.StaticVaruable}, InstanceVariable = {obj1.InstanceVar}");
StaticExample obj2 = new StaticExample();
Console.WriteLine($"obj2: StaticVariable =  {StaticExample.StaticVaruable}, InstanceVariable = {obj2.InstanceVar}");
StaticExample obj3 = new StaticExample();
Console.WriteLine($"obj3: StaticVariable =  {StaticExample.StaticVaruable}, InstanceVariable = {obj3.InstanceVar}");


Console.WriteLine($"obj1: StaticVariable =  {StaticExample.StaticVaruable}, InstanceVariable = {obj1.InstanceVar}");
Console.WriteLine($"obj2: StaticVariable =  {StaticExample.StaticVaruable}, InstanceVariable = {obj2.InstanceVar}");
Console.WriteLine($"obj3: StaticVariable =  {StaticExample.StaticVaruable}, InstanceVariable = {obj3.InstanceVar}");
*/

//-========================Interfaces

Smartphone smartphone = new Smartphone();
Tablet tablet = new Tablet();

/*// -======================== Обычное применение метода ========================-
smartphone.DisplayInformation("Hello from smartphone!");
tablet.DisplayInformation("Hello from tablet!");
*/
// -======================== Продвинутое применение метода ========================-
// Мы можем использовать их, как будто они одинаковые, потому что они реализуют интерфейс

DisplayInformationOnDevice(smartphone, "Hello from smartphone!");
DisplayInformationOnDevice(tablet, "Hello from tablet!");

// Метод, который принимает любой объект, реализующий интерфейс IDisplayable
static void DisplayInformationOnDevice(IDisplayable device, string information)
{
    // Вызываем метод отображения, и не важно, что за устройство - смартфон, планшет или другое
    device.DisplayInformation(information);
}

// -======================== Реализация интерфейсов по умолчанию ========================-
// smartphone.DrawBorders(); Ошибка - метод DrawBorders() не определен в классе
/*tablet.DrawBorders(); */

// -======================== Множественная реализация интерфейсов ========================-
Tablet1 tablet1 = new Tablet1();
tablet1.Charge();
