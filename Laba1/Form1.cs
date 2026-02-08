using System.Diagnostics.Contracts;
using System.DirectoryServices.ActiveDirectory;
using Laba1.Src.Subject;
using Laba1.Src.util;

namespace Laba1;

public partial class Form1 : Form
{
    const int START_WINDOW_HEIGHT = 399;
    const int START_WINDOW_WIDTH = 452;
    const int MAIN_WINDOW_HEIGHT = 518;
    const int MAIN_WINDOW_WIDTH = 452;
 
    private static bool isShowedInfo = false;
    
    private HousingDepartment _instance;

    public Form1()
    {
        InitializeComponent();
        Size = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        _instance = new HousingDepartment();
        _instance = new HousingDepartment();
        _instance = new HousingDepartment();
        _instance = new HousingDepartment();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        label1.Visible = false;
        label2.Visible = false;
        label3.Visible = false;
        label4.Visible = false;
        next.Visible = false;
        Size = new Size(MAIN_WINDOW_WIDTH, MAIN_WINDOW_HEIGHT);
        label5.Visible = true;
        label7.Visible = true;
        btnShow.Visible = true;
        panel1.Visible = true;
        label6.Visible = true;
        comboBox1.Visible = true;
        prev.Visible = true;
        exit.Visible = true;
    }

    private void prev_Click(object sender, EventArgs e)
    {
        label1.Visible = true;
        label2.Visible = true;
        label3.Visible = true;
        label4.Visible = true;
        next.Visible = true;
        Size = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        label5.Visible = false;
        label7.Visible = false;
        btnShow.Visible = false;
        panel1.Visible = false;
        label6.Visible = false;
        comboBox1.Visible = false;
        prev.Visible = false;
        exit.Visible = false;
    }

    private void btnShow_Click(object sender, EventArgs e)
    {
        if (!isShowedInfo)
        {
            label7.Text = _instance.ToString();
            btnShow.Text = "Скрыть информацию";
        }
        else
        {
            label7.Text = "";
            btnShow.Text = "Показать информацию";
        }
        
        isShowedInfo = !isShowedInfo;
    }

    private void exit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void saveBtn_Click(object sender, EventArgs e)
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

    private void FillValues()
    {
        switch (comboBox1.SelectedIndex)
        {
            case 0:
                _instance.District = district.Text;
                break;
            case 1:
                _instance.HousingDepartmentNumber = int.Parse(housingDepartmentNumber.Text);
                break;
            case 2:
                _instance.Residents = ParseResidents(residentName.Text, residentHouseNum.Text);
                break;
            case 3:
                _instance.PaidResidentsCount = int.Parse(paidResidentsCount.Text);
                break;
            case 4:
                _instance.Tariff = double.Parse(tariff.Text);
                break;
            case 5:
                _instance.Balance = balance.Value;
                break;
            case 6:
                _instance.EmployeeCount = int.Parse(employeeCount.Text);
                break;
        }
        
        savedShow.Visible = true;
        label7.Text = _instance.ToString();
        if (!isShowedInfo)
        {
            btnShow.Text = "Скрыть информацию";
            isShowedInfo = true;
        }
    }
    
    private Resident[] ParseResidents(string residentNames, string residentNumberHouse)
    {
        string[] splitNames = residentNames.Split(';');
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

    private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        district.Visible = false;
        housingDepartmentNumber.Visible = false;
        residentHouseNum.Visible = false;
        residentName.Visible = false;
        paidResidentsCount.Visible = false;
        tariff.Visible = false;
        balance.Visible = false;
        employeeCount.Visible = false;

        saveBtn.Visible = true;
        switch (comboBox1.SelectedIndex)
        {
            case 0:
                district.Visible = true;
                break;
            case 1:
                housingDepartmentNumber.Visible = true;
                break;
            case 2:
                residentHouseNum.Visible = true;
                residentName.Visible = true;
                break;
            case 3:
                paidResidentsCount.Visible = true;
                break;
            case 4:
                tariff.Visible = true;
                break;
            case 5:
                balance.Visible = true;
                break;
            case 6:
                employeeCount.Visible = true;
                break;
        }
    }
}