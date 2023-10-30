namespace SorteadorGrupos.Models;

public class Group
{
    public string? Name { get; set; }
    public int Number { get; set; }

    public int Sorted { get; set; }

    public int Grade { get; set; }

    public Group()
    {
        Name = "Grupo";
    }
}