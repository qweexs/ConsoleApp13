using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Persona
{
    private string name;
    string fam;
    string otch;
    int Vector { get; set; }

    public string Name
    {
        get { return string.IsNullOrEmpty(name) ? "..." : name; }
        set { name = value.Trim().ToUpper(); }
    }
    public string Fam
    {
        get { return string.IsNullOrEmpty(fam) ? "..." : fam; }
        set { fam = value; }
    }
    public string Otch
    {
        get { return string.IsNullOrEmpty(otch) ? "..." : otch; }
        set { otch = value; }
    }
    public Persona()
    {
        name = string.Empty;
        fam = string.Empty;
        otch = string.Empty;
    }
    public Persona(string n) : this() { name = n; }
    public Persona(string n, string f) : this(n) { fam = f; }
    public Persona(string f, string n, string ot) : this(n, f) { otch = ot; }
    public void Show()
    {
        Console.WriteLine("{0} {1} {2} ", Fam, Name, Otch);

    }
    public int _Show()
    {
        Console.WriteLine("{0} {1} {2} ", Fam, Name, Otch);
        return 0;
    }
    public void Show(int x)
    {
        System.Windows.Forms.MessageBox.Show(
        string.Format("{0} {1} {2} ", Fam, Name, Otch)
        );
    }

    public override string ToString()
    {

        return string.Format("{0} {1}. {2}. ", Fam, Name.Substring(0, 1), Otch.Substring(0, 1));
    }
    public void Init()
    {
        Console.Write("Фамилия >>");
        fam = Console.ReadLine();
        Console.Write("Имя >>");
        name = Console.ReadLine();
        Console.Write("Отчество >>");
        otch = Console.ReadLine();

    }
}