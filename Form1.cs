namespace WinForm;

using System;
using System.Data;

public partial class Form1 : Form
{
    private string calculation = "";

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void Button_Function(object sender, EventArgs e)
    {
        //Adds characters to string
        calculation += (sender as Button).Text;

        textBox.Text = calculation;
    }

    private void Button_Equals(object sender, EventArgs e)
    {
        //Formats string for calculation
        string formattedCalculation = calculation.ToString().Replace("X", "*").ToString().Replace("÷", "/");

        //Calculates answer
        try
        {
            textBox.Text = new DataTable().Compute(formattedCalculation, null).ToString();
            calculation = textBox.Text;
        }
        //Checks for invalid formulas
        catch (Exception ex)
        {
            textBox.Text = "0";
            calculation = "";
        }

    }

    private void Button_Clear(object sender, EventArgs e)
    {
        //Empties text box and clears calculation
        textBox.Text = "0";
        calculation = "";
    }

    private void Button_Clear_Entry(object sender, EventArgs e)
    {
        //Clears the most recent character
        if(calculation.Length > 0)
        {
            calculation = calculation.Remove(calculation.Length - 1, 1);
        }

        textBox.Text = calculation;
    }
}
