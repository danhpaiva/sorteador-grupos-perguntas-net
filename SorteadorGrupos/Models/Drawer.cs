namespace SorteadorGrupos.Models;

using System.Text;
using static System.Console;

public class Drawer
{
    private int Amount { get; set; }
    public Group Draw(Group group)
    {
        Random random = new();

        WriteLine("\nDigite o número do Grupo que irá se apresentar neste momento: ");
        group.Number = int.Parse(ReadLine());

        WriteLine("\nDigite a quantidade de grupos que estão participando " +
            "\nnesse trabalho acadêmico: ");
        Amount = int.Parse(ReadLine());

        group.Sorted = random.Next(1, Amount);

        return group;
    }

    public void SaveFile(Group group)
    {
        try
        {
            DateTime dateTime = DateTime.Now;
            StreamWriter sw = new($"avaliacao_{dateTime.ToString("yyyy_MM_dd_HH_mm_ss")}.txt", true, Encoding.UTF8);
            sw.WriteLine($"\n{DateTime.Now} : O {group.Name} {group.Sorted} fará perguntas ao {group.Name} {group.Number}");

            WriteLine($"Digite a nota parcial para o {group.Name} {group.Number} :");
            group.Grade = int.Parse(ReadLine());

            sw.WriteLine($"\n{DateTime.Now} : Nota para o {group.Name} {group.Number}: {group.Grade}");
            WriteLine("\nArquivo salvo com sucesso!\nAperte Enter!");
            sw.Close();
        }
        catch (Exception erro)
        {
            WriteLine($"Deu erro ao tentar gravar o arquivo: {erro.Message}");
        }
        finally
        {
           
        }
    }

    public void Message(Group group)
    {
        WriteLine($"\n{DateTime.Now} : O {group.Name} {group.Sorted} fará perguntas ao {group.Name} {group.Number}");
    }
}