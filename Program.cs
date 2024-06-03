using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo nokia", imei: "5555555", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Baldurs gate 3 mobile edition");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "321653", modelo: "Modelo iphone", imei: "64646464", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");