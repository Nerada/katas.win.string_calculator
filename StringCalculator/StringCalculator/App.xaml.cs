using System.Windows;

namespace StringCalculator;

/// <summary>
///     https://osherove.com/tdd-kata-1
/// </summary>
public partial class App
{
    private void OnStartup(object sender, StartupEventArgs e)
    {
        int number = CalculateString.Add("//;\n1;2");

        MessageBox.Show($"We made a number! {number}");
    }
}