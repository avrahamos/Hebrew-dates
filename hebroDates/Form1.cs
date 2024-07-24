using hebroDates.sevice;
using static hebroDates.sevice.HebrewDateService;
namespace hebroDates
{

    public partial class Form1 : Form
    {
        List<string> days = ["ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי", "שבת"];
        List<string> Month = ["תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר", "אדר א", "אדר ב", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול"];
        List<int> dayMonth = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30];
        List<string> years = ["תשפד", "תשפה", "תשפו", "תשפז", "תשפח", "תשפט", "תשצ", "תשצא", "תשצב", "תשצג"];
        public Form1()
        {
            InitializeComponent();
            HebrewDateService.CreateXmlIfNotExists();
            //HebrewDateService.AddDay("ראשון");
            DaycomboBox.DataSource = days;
            MonthcomboBox2.DataSource = Month;
            DayMonthcomboBox3.DataSource = dayMonth;
            YearcomboBox1.DataSource = years;
            string a = ChengeDays("ראשון");
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

                "ראשון" => "באחד בשבת",
                "שני" => "בשני בשבת",
                "שלישי" => "בשלישי בשבת",
                "רביעי" => "ברביעי בשבת",
                "חמישי" => "בחמישי בשבת",
                "שישי" => "בשישי בשבת",
                "שבת" => ""

            };
            return da;
        }
       

        

        public string CangeDayMonth(int dayMonth)
        {
            

            AddDayMonth(dayMonth);
            string d = dayMonth switch
            {
                1 => "יום אחד לירח",
                2 => "שני ימים לירח",
                3 => "שלשה ימים לירח",
                4 => "ארבעה ימים לירח",
                5 => "חמישה ימים לירח",
                6 => "שישה ימים לירח",
                7 => "שבעה ימים לירח",
                8 => "שמונה ימים לירח",
                9 => "תשעה ימים לירח",
                10 => "עשרה ימים לירח",
                11 => "אחד עשר יום לירח",
                12 => "שנים עשר יום לירח",
                13 => "שלושה עשר יום לירח",
                14 => "ארבעה עשר יום לירח",
                15 => "חמישה עשר יום לירח",
                16 => "שישה עשר יום לירח",
                17 => "שבעה עשר יום לירח",
                18 => "שמונה עשר יום לירח",
                19 => "תשעה עשר יום לירח",
                20 => "עשרים לירח",
                21 => "אחד ועשרים יום לירח",
                22 => "שנים ועשרים לירח",
                23 => "שלושה ועשרים יום לירח",
                24 => "ארבעה ועשרים יום לירח",
                25 => "חמישה ועשרים יום לירח",
                26 => "שישה ועשרים יום לירח",
                27 => "שבעה ועשרים יום לירח",
                28 => "שמונה ועשרים יום לירח",
                29 => "תשעה ועשרים יום לירח",
                30 => $"יום שלושים לירח {MonthcomboBox2.Text} שהוא ראש חודש"


            };
            return d;
        }
        
        public string Cangyears(string year)
        {
            string y = year switch
            {
                "תשפד" => "בשנת חמשת אלפים ןשבע מאות ושמונים וארבע לבריאת העולם",
                "תשפה" => "בשנת חמשת אלפים ןשבע מאות ושמונים ווחמישה לבריאת העולם",
                "תשפו" => "בשנת חמשת אלפים ןשבע מאות ושמונים וששה לבריאת העולם",
                "תשפז" => "בשנת חמשת אלפים ןשבע מאות ושמונים וושבעה לבריאת העולם",
                "תשפח" => "בשנת חמשת אלפים ןשבע מאות ושמונים ושמונה לבריאת העולם",
                "תשפט" => "בשנת חמשת אלפים ןשבע מאות ושמונים ותשעה לבריאת העולם",
                "תשצ" => "בשנת חמשת אלפים ןשבע מאות ותשעים לבריאת העולם",
                "תשצא" => "בשנת חמשת אלפים ןשבע מאות ותשעים ואחת לבריאת העולם",
                "תשצב" => "בשנת חמשת אלפים ןשבע מאות ותשעים ושתיים לבריאת העולם",
                "תשצג" => "בשנת חמשת אלפים ןשבע מאות ותשעים ושלושה לבריאת העולם",
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
