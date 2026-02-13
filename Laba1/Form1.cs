using System.Diagnostics.Contracts;
using System.DirectoryServices.ActiveDirectory;
using Laba1.Src.Subject;
using Laba1.Src.util;

namespace Laba1;

public partial class Form1 : Form
{
    const int START_WINDOW_HEIGHT = 451;
    const int START_WINDOW_WIDTH = 526;
    const int MAIN_WINDOW_HEIGHT = 723;
    const int MAIN_WINDOW_WIDTH = 628;
 
    private static bool isShowedInfo = false;
    
    private HousingDepartment _instance;

    public Form1()
    {
        InitializeComponent();
        Size = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MaximumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MinimumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        _instance = new HousingDepartment();
        _instance = new HousingDepartment();
        _instance = new HousingDepartment();
        _instance = new HousingDepartment();
        panel2.Visible = false;
        tableLayoutPanel2.Visible = false;
    }
    
    private void FillValues()
    {
        switch (comboBox_fields.SelectedIndex)
        {
            case 0:
                _instance.District = textBox_district.Text;
                break;
            case 1:
                _instance.HousingDepartmentNumber = int.Parse(numericUpDown_housingDepartmentNumber.Text);
                break;
            case 2:
                _instance.Residents = ParseResidents(textBox_residentName.Text, textBox_residentHouseNum.Text);
                break;
            case 3:
                _instance.PaidResidentsCount = int.Parse(numericUpDown_paidResidentsCount.Text);
                break;
            case 4:
                _instance.Tariff = double.Parse(numericUpDown_tariff.Text);
                break;
            case 5:
                _instance.Balance = numericUpDown_balance.Value;
                break;
            case 6:
                _instance.EmployeeCount = int.Parse(numericUpDown_employeeCount.Text);
                break;
        }
        
        label_saved_status.Visible = true;
        label_show_info.Text = _instance.ToString();
        if (!isShowedInfo)
        {
            button_show.Text = "Скрыть информацию";
            isShowedInfo = true;
        }
    }
    
    private Resident[] ParseResidents(string textBox_residentNames, string residentNumberHouse)
    {
        string[] splitNames = textBox_residentNames.Split(';');
        string[] splitNumber = residentNumberHouse.Split(';');
        
        if (splitNames.Length != splitNumber.Length)
            throw new IndexOutOfRangeException();
        
        Resident[] residents = new Resident[splitNames.Length];
        for (int i = 0; i < splitNames.Length; i++)
        {
            int num = int.Parse(splitNumber[i]);
            residents[i] = new Resident(num, splitNames[i]);
        }
        
        return residents;
    }
    
    private void comboBox_fields_SelectedIndexChanged(object sender, EventArgs e)
    {
        textBox_district.Visible = false;
        numericUpDown_housingDepartmentNumber.Visible = false;
        textBox_residentHouseNum.Visible = false;
        textBox_residentName.Visible = false;
        numericUpDown_paidResidentsCount.Visible = false;
        numericUpDown_tariff.Visible = false;
        numericUpDown_balance.Visible = false;
        numericUpDown_employeeCount.Visible = false;
    
        button_save.Visible = true;
        switch (comboBox_fields.SelectedIndex)
        {
            case 0:
                textBox_district.Visible = true;
                break;
            case 1:
                numericUpDown_housingDepartmentNumber.Visible = true;
                break;
            case 2:
                textBox_residentHouseNum.Visible = true;
                textBox_residentName.Visible = true;
                break;
            case 3:
                numericUpDown_paidResidentsCount.Visible = true;
                break;
            case 4:
                numericUpDown_tariff.Visible = true;
                break;
            case 5:
                numericUpDown_balance.Visible = true;
                break;
            case 6:
                numericUpDown_employeeCount.Visible = true;
                break;
        }
    }

    private void button_next_Click(object sender, EventArgs e)
    {
        panel2.Visible = true;
        tableLayoutPanel2.Visible = true;
        Size = new Size(MAIN_WINDOW_WIDTH, MAIN_WINDOW_HEIGHT);
        MaximumSize = new Size(MAIN_WINDOW_WIDTH, MAIN_WINDOW_HEIGHT);
        MinimumSize = new Size(MAIN_WINDOW_WIDTH, MAIN_WINDOW_HEIGHT);
    }

    private void button_show_Click(object sender, EventArgs e)
    {
        if (!isShowedInfo)
        {
            label_show_info.Text = _instance.ToString();
            button_show.Text = "Скрыть информацию";
        }
        else
        {
            label_show_info.Text = "";
            button_show.Text = "Показать информацию";
        }
        
        isShowedInfo = !isShowedInfo;
    }

    private void button_save_Click(object sender, EventArgs e)
    {
        try
        {
            FillValues();
        }
        catch (Exception ex)
        {
            NativeMessageBox.MessageBox(
                0,
                ex.Message,
                "Ошибка",
                NativeMessageBox.MB_OK | NativeMessageBox.MB_ICONERROR
            );
        }
    }

    private void button_prev_Click(object sender, EventArgs e)
    {
        panel2.Visible = false;
        tableLayoutPanel2.Visible = false;
        Size = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MaximumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MinimumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
    }

    private void button_exit_Click(object sender, EventArgs e)
    {
        Close();
    }
}