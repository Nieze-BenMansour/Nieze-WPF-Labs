namespace Nieze.WPF.Demos.Demo1;

public class ProduitViewModel
{
    public ProduitViewModel(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public string Name { get; set; }

    public string Code { get; set; }
}


public class ProduitViewModel2
{
    public string Name { get; set; }

    public string Code { get; set; }
}

