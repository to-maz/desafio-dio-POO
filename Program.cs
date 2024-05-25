using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");

Smartphone Nokia = new Nokia(numero:"165461654", modelo:"nuncavi", imei:"as4321" , memoria:256);
Nokia.Ligar();
Nokia.InstalarAplicativo("TrucoVamos");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"123545646", modelo:"javi", imei:"sa432'" , memoria:512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ZéDelivery");