using ExcHomework;

Console.WriteLine("Правильный ввод ничего не выводится, т.к. данные совпадают с условием.");
new Authorization();
Authorization.CheckData("pavel", "password1", "password1"); //правильный ввод

Console.WriteLine("--------------------------------");
Console.WriteLine("Проверка на ошибку в логине данные: \"pavel \", \"password1\", \"password1\" ");
new Authorization();
Authorization.CheckData("pavel ", "password1", "password1");//ошибка в логине

Console.WriteLine("-------------------------------");                                                     
Console.WriteLine("Проверка на ошибку в пароле данные: \"pavel\", \"password1 \", \"password1\" ");
new Authorization();
Authorization.CheckData("pavel", "password1 ", "password1");//ошибка в пароле

Console.WriteLine("-------------------------------");
Console.WriteLine("Проверка на несовпадения паролей данные: \"pavel\", \"password1\", \"password2\" ");
new Authorization();
Authorization.CheckData("pavel", "password1", "password2");//ошибка в подтверждении пароля

