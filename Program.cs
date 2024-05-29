using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Mod 01", imei: "9999999", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "7891011", modelo: "Mod 11", imei: "00000001", memoria: 120);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");
