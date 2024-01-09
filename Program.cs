using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");

Nokia nokia1100 = new Nokia("34316893", "flip phone", "010510007600428", 2);
nokia1100.Ligar();
nokia1100.InstalarAplicativo("Stack Attack");

Console.WriteLine();


Console.WriteLine("Iphone");
Iphone iphone3gs = new Iphone("30522131", "multi touch", "010510004247355", 16);
iphone3gs.ReceberLigacao();
iphone3gs.InstalarAplicativo("Whatsapp");

