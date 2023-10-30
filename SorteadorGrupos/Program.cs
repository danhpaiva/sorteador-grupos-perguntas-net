using SorteadorGrupos.Models;
using static System.Console;

WriteLine("Sorteador de Grupos");

Group group = new();
Drawer drawer = new();
group = drawer.Sort(group);
drawer.SaveFile(group);