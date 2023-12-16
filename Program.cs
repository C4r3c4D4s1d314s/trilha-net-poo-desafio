using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"16991234567", modelo: "Modelo Nk1", imei:"ab.cd.ef.gh.ij.kl", memoria:8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("/n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero:"16920003736", modelo: "Ip12", imei:"ab.cd.ef.gh.ij.no", memoria:128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");