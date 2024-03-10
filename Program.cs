
// See https://aka.ms/new-console-template for more information

using System;
using ReadWriteTxt.Read;
using ReadWriteTxt.Write;

ReadTxt readTxt = new();
WriteTxt writeTxt = new();
Console.WriteLine("Escrever:");
writeTxt.Write();
Console.WriteLine("Ler: ");
readTxt.Read();