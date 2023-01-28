using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1844456", modelo: "Tejolo", imei: "111111111", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");
Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "47587", modelo: "ZOOM-Out", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");