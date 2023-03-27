// See https://aka.ms/new-console-template for more information
using AddDashAndStar;
//var write = new Write();
//write.write();
//var star =new AddStar();
//star.write();
//var dash = new AddDash();
//dash.write();

IWriter writer = new AddDashDecorator(new AddStarDecorator(new Write()));
writer.write();

var rl = Console.ReadLine();
