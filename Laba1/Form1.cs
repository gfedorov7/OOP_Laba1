using Laba1.Src.Subject;
using Laba1.Src.util;

namespace Laba1;

public partial class Form1 : Form
{
    private HousingDepartment _instance;
    
    public Form1()
    {
        InitializeComponent();
        _instance = new HousingDepartment();
        label1.Text = _instance.ToString();
        label10.Text = HousingDepartment.ObjectCount.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            FillInstance();
        }
        catch (Exception ex)
        {
            NativeMessageBox.MessageBox(
                this.Handle,
                ex.Message,
                "Ошибка",
                NativeMessageBox.MB_OK | NativeMessageBox.MB_ICONERROR
            );
        }
        
        label1.Text = _instance.ToString();
    }

    private void FillInstance()
    {
        string district = textBox1.Text;
        string housingDepartmentNumber = textBox2.Text;
        string residentNames = textBox3.Text;
        string residentNumberHouse = textBox8.Text;
        string paidResidentsCount = textBox4.Text;
        string tariff = textBox5.Text;
        string balance = textBox6.Text;
        string employeeCount = textBox7.Text;
        
        if (district != "")
            _instance.District = district;

        if (housingDepartmentNumber != "")
            _instance.HousingDepartmentNumber = int.Parse(housingDepartmentNumber);

        if (residentNumberHouse != "" && residentNames != "")
            _instance.Residents = ParseResidents(residentNames, residentNumberHouse);
        
        if (paidResidentsCount != "")
            _instance.PaidResidentsCount = int.Parse(paidResidentsCount);

        if (tariff != "")
            _instance.Tariff = double.Parse(tariff);

        if (balance != "")
            _instance.Balance = decimal.Parse(balance);

        if (employeeCount != "")
            _instance.EmployeeCount = int.Parse(employeeCount);
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
}