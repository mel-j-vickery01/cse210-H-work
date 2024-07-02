class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private int weight;
    public Person(string firstName, string lastName, int age, int weight)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.weight = weight;
    }

    public string PersonInformation()
    {
        return $"{firstName}, {lastName}, {age}, {weight}";
    }

}