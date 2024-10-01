using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia n1 = new Nokia("82847519", "Nokia K4756", "948734873638", 256);
n1.InstalarAplicativo("whatsgb");
n1.Ligar();
n1.ReceberLigacao();

Console.WriteLine("");

Console.WriteLine("Smartphone Iphone: ");
Iphone i1 = new Iphone("5896-8978", "Iphone 15", "283426534826348", 512);
i1.InstalarAplicativo("Telegram");
i1.Ligar();
i1.ReceberLigacao();
