using System.Text.RegularExpressions;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        // At least 8 chars, 1 uppercase, 1 digit
        string pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";
        return Regex.IsMatch(password, pattern);
    }
}
