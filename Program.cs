using System.ComponentModel.DataAnnotations;
using DesafioTrilhaNetPoo.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987654321", modelo: "Nokia 3310", imei: "IMEI987", memoria: 36);
nokia.Ligar();
nokia.InstalarAplicativo("Nokia");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "iPhone X", imei: "IMEI123", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("iPhone");

