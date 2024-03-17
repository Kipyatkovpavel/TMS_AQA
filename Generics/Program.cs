﻿// See https://aka.ms/new-console-template for more information
using Generics;

SimplePerson simplePerson = new SimplePerson(546, "Tom");
ObjectPerson objectPerson = new ObjectPerson("abs123", "Bob");

int tomId = simplePerson.Id;
string bobId = (string)objectPerson.Id;

Console.WriteLine($"Tom ID: {tomId}");
Console.WriteLine($"Bob ID: {bobId}");

ObjectPerson objectPerson1 = new ObjectPerson(123, "Bob"); // упаковка значения int в тип Object
int intBobID = (int)objectPerson1.Id; //распаковка в тип int
//string strBobID = (string)objectPerson1.Id; // ошибка при выполнении

// -=================== Generics ===================- 
GenericPerson<int> intPerson = new GenericPerson<int>(123, "Alex");
intPerson.Print();

// -=================== Варианты
GenericPerson<string> strPerson = new GenericPerson<string>("- 123 -", "Alex");
GenericPerson<Guid> uniquePerson = new GenericPerson<Guid>(Guid.NewGuid(), "Alex");
strPerson.Print();
uniquePerson.Print();

int intAlexId = intPerson.Id;
string strAlexId = strPerson.Id;
// В обоих случаях не нужна раскаковка и упаковка

Company<GenericPerson<int>> mtsCompany = new Company<GenericPerson<int>>(intPerson);
Company<GenericPerson<string>> mtsCompany1 = new Company<GenericPerson<string>>(strPerson);
Company<GenericPerson<Guid>> mtsCompany2 = new Company<GenericPerson<Guid>>(uniquePerson);

// -=================== Static
//StaticPerson.code = 124; //Ошибка - отсутствует типизация

StaticPerson<int>.code = 123;
StaticPerson<string>.code = "- 123 -";

Console.WriteLine(StaticPerson<int>.code);
Console.WriteLine(StaticPerson<string>.code);
Console.WriteLine(StaticPerson<int>.code);

// -=================== Несколько обобщенных типов
Person<Guid, string> alex = new Person<Guid, string>(Guid.NewGuid(), "wp", "Alex");
Person<Guid, int> olga = new Person<Guid, int>(Guid.NewGuid(), 1, "Olga");

// -=================== Обобщенные методы
int x = 10;
int y = 15;
Helper.Swap<int>(ref x, ref y);

string x1 = "10";
string y1 = "15";
Helper.Swap(ref x1, ref y1);

// -=================== Ограничения Generics ===================-
// -=================== Ограничения методов

Helper.SendMessage(new Message("Bye World!"));
Helper.SendMessage(new EmailMessage("This is EmailMessage..."));
Helper.SendMessage<SmsMessage>(new SmsMessage("This is SMS message..."));

// -=================== Ограничения обобщений в типах
Messenger<Message> telegram = new Messenger<Message>();
telegram.SendMessenger(new Message("Hello World"));

Messenger<EmailMessage> outlook = new Messenger<EmailMessage>();
outlook.SendMessenger(new EmailMessage("Bye World"));

MessengerStruct<MessageStruct> messengerStruct = new MessengerStruct<MessageStruct>();
MessengerStruct<int> test = new MessengerStruct<int>(); 
//MessageStruct<string> test; //ошибка -string не struct
messengerStruct.SendMesseng(new MessageStruct("Struct is cool for small objects..."));

MessengerClass<SmsMessage> smsMessengerClass = new MessengerClass<SmsMessage>();
//MessengerClass<int> test = new MessengerStruct<int>();  //ошибка -  int не class
MessengerClass<string> test1 = new MessengerClass<string>();

//MessengerNew<SmsMessage> smsMessengerNew = new MessengerNew<SmsMessage>(); //ошибка потому что у SmsMessage нет конструктора без параметров
MessengerNew<EmailMessage> messengerNew = new MessengerNew<EmailMessage>(); //Всё ок

// -=================== Ограничения нескольких универсальных параметров
SimplePerson sender = new SimplePerson(1, "Ted");
SimplePerson receiver = new SimplePerson(3, "Fred");
MessengerService<EmailMessage, SimplePerson> messengerService = new MessengerService<EmailMessage, SimplePerson>();
messengerService.SendMessage(sender, receiver, new EmailMessage("Email..."));


// -=================== Наследование обобщенных типов
ChildGenericPerson<Guid> childGenericPerson = new ChildGenericPerson<Guid>(Guid.NewGuid(), "Toma");
IntGenericPerson intGenericPerson = new IntGenericPerson(1, "Vera");
VaryGenericPerson<string> varyGenericPerson = new VaryGenericPerson<string>(2, "Gena");
ChildWherePerson<string> childWherePerson = new ChildWherePerson<string>("1/2", "Dolly");
ChildWherePerson<SimplePerson> childWherePerson1 = new ChildWherePerson<SimplePerson>(new(3, "Sam"), "Dolly");