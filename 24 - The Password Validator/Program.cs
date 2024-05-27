while (true)
{
    Console.WriteLine("Type your password");
    string user_pass = Console.ReadLine();
    PasswordValidator password = new PasswordValidator(user_pass);
    password.Validation();
}


public class PasswordValidator
{
    private string Pass;
    bool Tampersand = false;
    bool Number;
    bool Lower;
    bool Upper;

    public PasswordValidator(string pass)
    {
        Pass = pass;
    }

    public void Validation()
    {
        foreach (char l in Pass)
        {
            if (l == '&' || l =='T') Tampersand = true;
            if (char.IsUpper(l)) Upper = true;
            if (char.IsLower(l)) Lower = true;
            if (char.IsDigit(l)) Number = true;
        }

        if (Tampersand == false && Upper == true && Lower == true && Number == true) Console.WriteLine("Everything ok with your pass!");
        else Console.WriteLine("Check your pass and try again!");
    }
}