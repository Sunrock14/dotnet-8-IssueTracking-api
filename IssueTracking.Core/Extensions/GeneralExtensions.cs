namespace IssueTracking.Core.Extensions;

public class GeneralExtensions
{
    /// <summary>
    /// Türkçeye özel olan karakterleri değiştirir
    /// </summary>
    /// <param name="Text"></param>
    /// <returns></returns>
    public static string ConvertTurkishChar(string Text)
    {
        Text = Text.Replace("İ", "I");
        Text = Text.Replace("ı", "i");
        Text = Text.Replace("ğ", "g");
        Text = Text.Replace("Ğ", "G");
        Text = Text.Replace("ç", "c");
        Text = Text.Replace("Ç", "C");
        Text = Text.Replace("ö", "o");
        Text = Text.Replace("Ö", "O");
        Text = Text.Replace("ş", "s");
        Text = Text.Replace("Ş", "S");
        Text = Text.Replace("ü", "u");
        Text = Text.Replace("Ü", "U");
        Text = Text.Replace("@", "S");
        Text = Text.Replace("$", "I");
        Text = Text.Replace("!", "G");
        Text = Text.Replace("#", "O");
        Text = Text.Replace("¢", "C");
        return Text;
    }

}
