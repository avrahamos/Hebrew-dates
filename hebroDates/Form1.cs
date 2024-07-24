using hebroDates.sevice;
using static hebroDates.sevice.HebrewDateService;
namespace hebroDates
{

    public partial class Form1 : Form
    {
        List<string> days = ["�����", "���", "�����", "�����", "�����", "����", "���"];
        List<string> Month = ["����", "�������", "����", "���", "���", "���", "��� �", "��� �", "����", "����", "�����", "����", "��", "����"];
        List<int> dayMonth = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30];
        List<string> years = ["����", "����", "����", "����", "����", "����", "���", "����", "����", "����"];
        public Form1()
        {
            InitializeComponent();
            HebrewDateService.CreateXmlIfNotExists();
            //HebrewDateService.AddDay("�����");
            DaycomboBox.DataSource = days;
            MonthcomboBox2.DataSource = Month;
            DayMonthcomboBox3.DataSource = dayMonth;
            YearcomboBox1.DataSource = years;
            string a = ChengeDays("�����");
            MessageBox.Show(a);

        }

        private void DaycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string ChengeDays(string day)
        {
            AddDay(day);
            string da = day switch
            {

                "�����" => "���� ����",
                "���" => "���� ����",
                "�����" => "������ ����",
                "�����" => "������ ����",
                "�����" => "������ ����",
                "����" => "����� ����",
                "���" => ""

            };
            return da;
        }
       

        

        public string CangeDayMonth(int dayMonth)
        {
            

            AddDayMonth(dayMonth);
            string d = dayMonth switch
            {
                1 => "��� ��� ����",
                2 => "��� ���� ����",
                3 => "���� ���� ����",
                4 => "����� ���� ����",
                5 => "����� ���� ����",
                6 => "���� ���� ����",
                7 => "���� ���� ����",
                8 => "����� ���� ����",
                9 => "���� ���� ����",
                10 => "���� ���� ����",
                11 => "��� ��� ��� ����",
                12 => "���� ��� ��� ����",
                13 => "����� ��� ��� ����",
                14 => "����� ��� ��� ����",
                15 => "����� ��� ��� ����",
                16 => "���� ��� ��� ����",
                17 => "���� ��� ��� ����",
                18 => "����� ��� ��� ����",
                19 => "���� ��� ��� ����",
                20 => "����� ����",
                21 => "��� ������ ��� ����",
                22 => "���� ������ ����",
                23 => "����� ������ ��� ����",
                24 => "����� ������ ��� ����",
                25 => "����� ������ ��� ����",
                26 => "���� ������ ��� ����",
                27 => "���� ������ ��� ����",
                28 => "����� ������ ��� ����",
                29 => "���� ������ ��� ����",
                30 => $"��� ������ ���� {MonthcomboBox2.Text} ���� ��� ����"


            };
            return d;
        }
        
        public string Cangyears(string year)
        {
            string y = year switch
            {
                "����" => "���� ���� ����� ���� ���� ������� ����� ������ �����",
                "����" => "���� ���� ����� ���� ���� ������� ������� ������ �����",
                "����" => "���� ���� ����� ���� ���� ������� ���� ������ �����",
                "����" => "���� ���� ����� ���� ���� ������� ������ ������ �����",
                "����" => "���� ���� ����� ���� ���� ������� ������ ������ �����",
                "����" => "���� ���� ����� ���� ���� ������� ����� ������ �����",
                "���" => "���� ���� ����� ���� ���� ������ ������ �����",
                "����" => "���� ���� ����� ���� ���� ������ ���� ������ �����",
                "����" => "���� ���� ����� ���� ���� ������ ������ ������ �����",
                "����" => "���� ���� ����� ���� ���� ������ ������ ������ �����",
            };
            return y;
        }

        private void PrintDatebutton1_Click(object sender, EventArgs e)
        {
            AddMonth(MonthcomboBox2.Text);

            string mesege = $"{ChengeDays(DaycomboBox.Text)} {CangeDayMonth(int.Parse(DayMonthcomboBox3.Text))} {Cangyears(YearcomboBox1.Text)}";
            res(mesege);
            MessageBox.Show(mesege);
        }
    }

}
