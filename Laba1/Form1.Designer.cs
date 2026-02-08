namespace Laba1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        next = new System.Windows.Forms.Button();
        label5 = new System.Windows.Forms.Label();
        btnShow = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        label6 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        district = new System.Windows.Forms.TextBox();
        housingDepartmentNumber = new System.Windows.Forms.NumericUpDown();
        residentName = new System.Windows.Forms.TextBox();
        residentHouseNum = new System.Windows.Forms.TextBox();
        tariff = new System.Windows.Forms.NumericUpDown();
        paidResidentsCount = new System.Windows.Forms.NumericUpDown();
        balance = new System.Windows.Forms.NumericUpDown();
        employeeCount = new System.Windows.Forms.NumericUpDown();
        savedShow = new System.Windows.Forms.Label();
        prev = new System.Windows.Forms.Button();
        exit = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        saveBtn = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)housingDepartmentNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)tariff).BeginInit();
        ((System.ComponentModel.ISupportInitialize)paidResidentsCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)balance).BeginInit();
        ((System.ComponentModel.ISupportInitialize)employeeCount).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(30, 21);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(391, 64);
        label1.TabIndex = 0;
        label1.Text = "Лабораторная работа 1";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label2.Location = new System.Drawing.Point(30, 85);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(391, 64);
        label2.TabIndex = 1;
        label2.Text = "Вариант 4 - ЖЭК";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label3.Location = new System.Drawing.Point(30, 143);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(391, 64);
        label3.TabIndex = 2;
        label3.Text = "Выполнили: Федоров, Фомин";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label4.Location = new System.Drawing.Point(30, 193);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(391, 67);
        label4.TabIndex = 3;
        label4.Text = "Группа 24ВП1";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // next
        // 
        next.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        next.Location = new System.Drawing.Point(137, 278);
        next.Name = "next";
        next.Size = new System.Drawing.Size(179, 51);
        next.TabIndex = 4;
        next.Text = "Далее";
        next.UseVisualStyleBackColor = true;
        next.Click += button1_Click;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label5.Location = new System.Drawing.Point(30, 9);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(391, 33);
        label5.TabIndex = 5;
        label5.Text = "Вывод информации";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label5.Visible = false;
        // 
        // btnShow
        // 
        btnShow.Location = new System.Drawing.Point(82, 244);
        btnShow.Name = "btnShow";
        btnShow.Size = new System.Drawing.Size(280, 28);
        btnShow.TabIndex = 6;
        btnShow.Text = "Показать информацию";
        btnShow.UseVisualStyleBackColor = true;
        btnShow.Visible = false;
        btnShow.Click += btnShow_Click;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        panel1.Location = new System.Drawing.Point(0, 278);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(446, 5);
        panel1.TabIndex = 7;
        panel1.Visible = false;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label6.Location = new System.Drawing.Point(30, 287);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(391, 33);
        label6.TabIndex = 8;
        label6.Text = "Изменение информации";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label6.Visible = false;
        // 
        // comboBox1
        // 
        comboBox1.BackColor = System.Drawing.SystemColors.Window;
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Район", "Номер ЖЭК\'a", "Резиденты", "Количество оплативших резидентов", "Тариф", "Баланс", "Количество работников" });
        comboBox1.Location = new System.Drawing.Point(29, 328);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(391, 23);
        comboBox1.TabIndex = 9;
        comboBox1.Visible = false;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
        // 
        // district
        // 
        district.Location = new System.Drawing.Point(29, 364);
        district.Name = "district";
        district.Size = new System.Drawing.Size(391, 23);
        district.TabIndex = 10;
        district.Visible = false;
        // 
        // housingDepartmentNumber
        // 
        housingDepartmentNumber.Location = new System.Drawing.Point(25, 364);
        housingDepartmentNumber.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        housingDepartmentNumber.Name = "housingDepartmentNumber";
        housingDepartmentNumber.Size = new System.Drawing.Size(395, 23);
        housingDepartmentNumber.TabIndex = 11;
        housingDepartmentNumber.Visible = false;
        // 
        // residentName
        // 
        residentName.Location = new System.Drawing.Point(25, 364);
        residentName.Name = "residentName";
        residentName.Size = new System.Drawing.Size(258, 23);
        residentName.TabIndex = 12;
        residentName.Visible = false;
        // 
        // residentHouseNum
        // 
        residentHouseNum.Location = new System.Drawing.Point(289, 364);
        residentHouseNum.Name = "residentHouseNum";
        residentHouseNum.Size = new System.Drawing.Size(135, 23);
        residentHouseNum.TabIndex = 13;
        residentHouseNum.Visible = false;
        // 
        // tariff
        // 
        tariff.DecimalPlaces = 2;
        tariff.Location = new System.Drawing.Point(25, 364);
        tariff.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        tariff.Name = "tariff";
        tariff.Size = new System.Drawing.Size(403, 23);
        tariff.TabIndex = 14;
        tariff.Visible = false;
        // 
        // paidResidentsCount
        // 
        paidResidentsCount.Location = new System.Drawing.Point(25, 364);
        paidResidentsCount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        paidResidentsCount.Name = "paidResidentsCount";
        paidResidentsCount.Size = new System.Drawing.Size(403, 23);
        paidResidentsCount.TabIndex = 14;
        paidResidentsCount.Visible = false;
        // 
        // balance
        // 
        balance.DecimalPlaces = 2;
        balance.Location = new System.Drawing.Point(25, 364);
        balance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        balance.Name = "balance";
        balance.Size = new System.Drawing.Size(403, 23);
        balance.TabIndex = 15;
        balance.Visible = false;
        // 
        // employeeCount
        // 
        employeeCount.Location = new System.Drawing.Point(25, 364);
        employeeCount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        employeeCount.Name = "employeeCount";
        employeeCount.Size = new System.Drawing.Size(403, 23);
        employeeCount.TabIndex = 16;
        employeeCount.Visible = false;
        // 
        // savedShow
        // 
        savedShow.ForeColor = System.Drawing.Color.ForestGreen;
        savedShow.Location = new System.Drawing.Point(159, 435);
        savedShow.Name = "savedShow";
        savedShow.Size = new System.Drawing.Size(133, 31);
        savedShow.TabIndex = 17;
        savedShow.Text = "Сохранено";
        savedShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        savedShow.Visible = false;
        // 
        // prev
        // 
        prev.Location = new System.Drawing.Point(22, 435);
        prev.Name = "prev";
        prev.Size = new System.Drawing.Size(133, 31);
        prev.TabIndex = 18;
        prev.Text = "<<< Назад";
        prev.UseMnemonic = false;
        prev.UseVisualStyleBackColor = false;
        prev.Visible = false;
        prev.Click += prev_Click;
        // 
        // exit
        // 
        exit.Location = new System.Drawing.Point(295, 433);
        exit.Name = "exit";
        exit.Size = new System.Drawing.Size(133, 31);
        exit.TabIndex = 19;
        exit.Text = "Выход\r\n";
        exit.UseMnemonic = false;
        exit.UseVisualStyleBackColor = false;
        exit.Visible = false;
        exit.Click += exit_Click;
        // 
        // label7
        // 
        label7.BackColor = System.Drawing.SystemColors.ControlLight;
        label7.Location = new System.Drawing.Point(29, 67);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(391, 174);
        label7.TabIndex = 20;
        label7.Visible = false;
        // 
        // saveBtn
        // 
        saveBtn.Location = new System.Drawing.Point(159, 393);
        saveBtn.Name = "saveBtn";
        saveBtn.Size = new System.Drawing.Size(133, 39);
        saveBtn.TabIndex = 21;
        saveBtn.Text = "Сохранить";
        saveBtn.UseMnemonic = false;
        saveBtn.UseVisualStyleBackColor = false;
        saveBtn.Visible = false;
        saveBtn.Click += saveBtn_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(436, 476);
        Controls.Add(saveBtn);
        Controls.Add(label7);
        Controls.Add(exit);
        Controls.Add(prev);
        Controls.Add(savedShow);
        Controls.Add(employeeCount);
        Controls.Add(balance);
        Controls.Add(tariff);
        Controls.Add(paidResidentsCount);
        Controls.Add(residentHouseNum);
        Controls.Add(residentName);
        Controls.Add(housingDepartmentNumber);
        Controls.Add(district);
        Controls.Add(comboBox1);
        Controls.Add(label6);
        Controls.Add(panel1);
        Controls.Add(btnShow);
        Controls.Add(label5);
        Controls.Add(next);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Location = new System.Drawing.Point(15, 15);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)housingDepartmentNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)tariff).EndInit();
        ((System.ComponentModel.ISupportInitialize)paidResidentsCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)balance).EndInit();
        ((System.ComponentModel.ISupportInitialize)employeeCount).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button saveBtn;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Button prev;
    private System.Windows.Forms.Button exit;

    private System.Windows.Forms.Label savedShow;

    private System.Windows.Forms.NumericUpDown tariff;
    private System.Windows.Forms.NumericUpDown paidResidentsCount;
    private System.Windows.Forms.NumericUpDown balance;
    private System.Windows.Forms.NumericUpDown employeeCount;

    private System.Windows.Forms.TextBox residentName;
    private System.Windows.Forms.TextBox residentHouseNum;

    private System.Windows.Forms.TextBox district;
    private System.Windows.Forms.NumericUpDown housingDepartmentNumber;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button btnShow;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button next;


    #endregion
}