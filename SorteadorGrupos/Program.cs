using SorteadorGrupos.Models;
using static System.Console;

WriteLine("Sorteador de Grupos");

Group group = new();
Drawer drawer = new();
group = drawer.Draw(group);
drawer.Message(group);
drawer.SaveFile(group);

ReadLine();