﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987654321", modelo: "Nokia 3310", imei: "IMEI987", memoria: 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "iPhone X", imei: "IMEI123", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("IOS 17");