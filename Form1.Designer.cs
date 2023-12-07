namespace WinForm;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        button0 = new Button();
        buttonAddition = new Button();
        buttonSubtraction = new Button();
        buttonMultiplication = new Button();
        button12 = new Button();
        buttonDecimal = new Button();
        buttonEquals = new Button();
        buttonLeftParetheses = new Button();
        buttonRightParentheses = new Button();
        buttonClear = new Button();
        buttonClearEntry = new Button();
        panel1 = new Panel();
        textBox = new TextBox();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(11, 310);
        button1.Name = "button1";
        button1.Size = new Size(75, 77);
        button1.TabIndex = 0;
        button1.Text = "1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += Button_Function;
        // 
        // button2
        // 
        button2.Location = new Point(92, 310);
        button2.Name = "button2";
        button2.Size = new Size(75, 77);
        button2.TabIndex = 1;
        button2.Text = "2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += Button_Function;
        // 
        // button3
        // 
        button3.Location = new Point(173, 310);
        button3.Name = "button3";
        button3.Size = new Size(75, 77);
        button3.TabIndex = 2;
        button3.Text = "3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += Button_Function;
        // 
        // button4
        // 
        button4.Location = new Point(11, 227);
        button4.Name = "button4";
        button4.Size = new Size(75, 77);
        button4.TabIndex = 3;
        button4.Text = "4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += Button_Function;
        // 
        // button5
        // 
        button5.Location = new Point(92, 227);
        button5.Name = "button5";
        button5.Size = new Size(75, 77);
        button5.TabIndex = 4;
        button5.Text = "5";
        button5.UseVisualStyleBackColor = true;
        button5.Click += Button_Function;
        // 
        // button6
        // 
        button6.Location = new Point(173, 227);
        button6.Name = "button6";
        button6.Size = new Size(75, 77);
        button6.TabIndex = 5;
        button6.Text = "6";
        button6.UseVisualStyleBackColor = true;
        button6.Click += Button_Function;
        // 
        // button7
        // 
        button7.Location = new Point(11, 144);
        button7.Name = "button7";
        button7.Size = new Size(75, 77);
        button7.TabIndex = 6;
        button7.Text = "7";
        button7.UseVisualStyleBackColor = true;
        button7.Click += Button_Function;
        // 
        // button8
        // 
        button8.Location = new Point(92, 144);
        button8.Name = "button8";
        button8.Size = new Size(75, 77);
        button8.TabIndex = 7;
        button8.Text = "8";
        button8.UseVisualStyleBackColor = true;
        button8.Click += Button_Function;
        // 
        // button9
        // 
        button9.Location = new Point(173, 144);
        button9.Name = "button9";
        button9.Size = new Size(75, 77);
        button9.TabIndex = 8;
        button9.Text = "9";
        button9.UseVisualStyleBackColor = true;
        button9.Click += Button_Function;
        // 
        // button0
        // 
        button0.Location = new Point(11, 393);
        button0.Name = "button0";
        button0.Size = new Size(75, 77);
        button0.TabIndex = 9;
        button0.Text = "0";
        button0.UseVisualStyleBackColor = true;
        button0.Click += Button_Function;
        // 
        // buttonAddition
        // 
        buttonAddition.BackColor = SystemColors.AppWorkspace;
        buttonAddition.Location = new Point(254, 393);
        buttonAddition.Name = "buttonAddition";
        buttonAddition.Size = new Size(75, 77);
        buttonAddition.TabIndex = 11;
        buttonAddition.Text = "+";
        buttonAddition.UseVisualStyleBackColor = false;
        buttonAddition.Click += Button_Function;
        // 
        // buttonSubtraction
        // 
        buttonSubtraction.BackColor = SystemColors.AppWorkspace;
        buttonSubtraction.Location = new Point(254, 310);
        buttonSubtraction.Name = "buttonSubtraction";
        buttonSubtraction.Size = new Size(75, 77);
        buttonSubtraction.TabIndex = 12;
        buttonSubtraction.Text = "-";
        buttonSubtraction.UseVisualStyleBackColor = false;
        buttonSubtraction.Click += Button_Function;
        // 
        // buttonMultiplication
        // 
        buttonMultiplication.BackColor = SystemColors.AppWorkspace;
        buttonMultiplication.Location = new Point(254, 227);
        buttonMultiplication.Name = "buttonMultiplication";
        buttonMultiplication.Size = new Size(75, 77);
        buttonMultiplication.TabIndex = 13;
        buttonMultiplication.Text = "X";
        buttonMultiplication.UseVisualStyleBackColor = false;
        buttonMultiplication.Click += Button_Function;
        // 
        // button12
        // 
        button12.BackColor = SystemColors.AppWorkspace;
        button12.Location = new Point(254, 144);
        button12.Name = "button12";
        button12.Size = new Size(75, 77);
        button12.TabIndex = 14;
        button12.Text = "÷";
        button12.UseVisualStyleBackColor = false;
        button12.Click += Button_Function;
        // 
        // buttonDecimal
        // 
        buttonDecimal.Location = new Point(92, 393);
        buttonDecimal.Name = "buttonDecimal";
        buttonDecimal.Size = new Size(75, 77);
        buttonDecimal.TabIndex = 16;
        buttonDecimal.Text = ".";
        buttonDecimal.UseVisualStyleBackColor = true;
        buttonDecimal.Click += Button_Function;
        // 
        // buttonEquals
        // 
        buttonEquals.BackColor = SystemColors.ActiveCaption;
        buttonEquals.Location = new Point(173, 393);
        buttonEquals.Name = "buttonEquals";
        buttonEquals.Size = new Size(75, 77);
        buttonEquals.TabIndex = 17;
        buttonEquals.Text = "=";
        buttonEquals.UseVisualStyleBackColor = false;
        buttonEquals.Click += Button_Equals;
        // 
        // buttonLeftParetheses
        // 
        buttonLeftParetheses.BackColor = SystemColors.AppWorkspace;
        buttonLeftParetheses.Location = new Point(173, 61);
        buttonLeftParetheses.Name = "buttonLeftParetheses";
        buttonLeftParetheses.Size = new Size(75, 77);
        buttonLeftParetheses.TabIndex = 18;
        buttonLeftParetheses.Text = "(";
        buttonLeftParetheses.UseVisualStyleBackColor = false;
        buttonLeftParetheses.Click += Button_Function;
        // 
        // buttonRightParentheses
        // 
        buttonRightParentheses.BackColor = SystemColors.AppWorkspace;
        buttonRightParentheses.Location = new Point(254, 61);
        buttonRightParentheses.Name = "buttonRightParentheses";
        buttonRightParentheses.Size = new Size(75, 77);
        buttonRightParentheses.TabIndex = 19;
        buttonRightParentheses.Text = ")";
        buttonRightParentheses.UseVisualStyleBackColor = false;
        buttonRightParentheses.Click += Button_Function;
        // 
        // buttonClear
        // 
        buttonClear.BackColor = Color.DarkSalmon;
        buttonClear.Location = new Point(11, 61);
        buttonClear.Name = "buttonClear";
        buttonClear.Size = new Size(75, 77);
        buttonClear.TabIndex = 20;
        buttonClear.Text = "C";
        buttonClear.UseVisualStyleBackColor = false;
        buttonClear.Click += Button_Clear;
        // 
        // buttonClearEntry
        // 
        buttonClearEntry.BackColor = Color.DarkSalmon;
        buttonClearEntry.Location = new Point(92, 61);
        buttonClearEntry.Name = "buttonClearEntry";
        buttonClearEntry.Size = new Size(75, 77);
        buttonClearEntry.TabIndex = 21;
        buttonClearEntry.Text = "CE";
        buttonClearEntry.UseVisualStyleBackColor = false;
        buttonClearEntry.Click += Button_Clear_Entry;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ActiveCaption;
        panel1.Controls.Add(textBox);
        panel1.Location = new Point(11, 9);
        panel1.Name = "panel1";
        panel1.Size = new Size(318, 44);
        panel1.TabIndex = 22;
        // 
        // textBox
        // 
        textBox.BorderStyle = BorderStyle.FixedSingle;
        textBox.Enabled = false;
        textBox.Location = new Point(8, 12);
        textBox.Name = "textBox";
        textBox.Size = new Size(303, 23);
        textBox.TabIndex = 0;
        textBox.Text = "0";
        textBox.TextAlign = HorizontalAlignment.Right;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(340, 478);
        Controls.Add(panel1);
        Controls.Add(buttonClearEntry);
        Controls.Add(buttonClear);
        Controls.Add(buttonRightParentheses);
        Controls.Add(buttonLeftParetheses);
        Controls.Add(buttonEquals);
        Controls.Add(buttonDecimal);
        Controls.Add(button12);
        Controls.Add(buttonMultiplication);
        Controls.Add(buttonSubtraction);
        Controls.Add(buttonAddition);
        Controls.Add(button0);
        Controls.Add(button9);
        Controls.Add(button8);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Calculator";
        Load += Form1_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button0;
    private Button buttonAddition;
    private Button buttonSubtraction;
    private Button buttonMultiplication;
    private Button button12;
    private Button buttonDecimal;
    private Button buttonEquals;
    private Button buttonLeftParetheses;
    private Button buttonRightParentheses;
    private Button buttonClear;
    private Button buttonClearEntry;
    private Panel panel1;
    private TextBox textBox;
}
