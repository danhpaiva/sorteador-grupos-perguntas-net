using System.Text;
using static System.Console;
namespace SorteadorGrupos.Models;
public class Drawer
{
    private int Amount { get; set; }
    public Group Draw(Group group)
    {
        Random random = new();

        try
        {
            WriteLine("\nDigite o número do Grupo que irá se apresentar neste momento: ");
            group.Number = int.Parse(ReadLine());

            WriteLine("\nDigite a quantidade de grupos que estão participando " +
                "\nnesse trabalho acadêmico: ");
            Amount = int.Parse(ReadLine());

            group.Sorted = random.Next(1, Amount);
        }
        catch (Exception)
        {
            WriteLine("Deu erro ao coletar os Grupos");
        }

        return group;
    }

    public void SaveFile(Group group)
    {
        string message = $"\n{DateTime.Now} : O {group.Name} {group.Sorted} fará perguntas ao {group.Name} {group.Number}";
        try
        {
            DateTime dateTime = DateTime.Now;
            StreamWriter sw = new($"avaliacao_{dateTime.ToString("yyyy_MM_dd_HH_mm_ss")}.txt", true, Encoding.UTF8);
            WriteLine(message);
            sw.WriteLine(message);

            WriteLine($"Digite a nota parcial para o {group.Name} {group.Number} :");
            group.Grade = int.Parse(ReadLine());

            sw.WriteLine($"\n{DateTime.Now} : Nota para o {group.Name} {group.Number}: {group.Grade}");
            WriteLine("\nArquivo salvo com sucesso!" +
                "\nPressione Enter!");
            sw.Close();
        }
        catch (Exception erro)
        {
            WriteLine($"Deu erro ao tentar gravar o arquivo: {erro.Message}" +
                $"\nPressione Enter!");
        }
        finally
        {
            ReadLine();
        }
    }
}