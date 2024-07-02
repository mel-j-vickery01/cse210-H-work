class FireMan : Person
{
    private string _certifications;


    public FireMan(string certifications, string f, string l, int a, int w) : base(f,l,a,w)
    {
        _certifications = certifications;
    }
public string FiremanInformation()
{
    return $"{_certifications}, {PersonInformation()}";

}

public FireMan() : base("", "", 0, 0)
{
    _certifications = "";
}



}