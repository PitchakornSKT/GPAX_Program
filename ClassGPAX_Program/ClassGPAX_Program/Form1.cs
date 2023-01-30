namespace ClassGPAX_Program
{
    public partial class Form1 : Form
    {
        
        public class Person
        {
            private string name;
            private int age;
            private int birthYear;

            public Person(string name, int bYear)
            {
                this.name = name;
                this.birthYear = bYear;
                this.age = 2565 - bYear;
            }

            public int getAge()
            {
                return this.age;
            }

            public string getName()
            {
                return this.name;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string input_name = txtName.Text;
            string input_year = txtYear.Text;
            int bYear  = Int32.Parse(input_year);

            Person person = new Person(input_name, bYear);

            this.txtListName.Text += person.getName() + "\n";

            int currentAge = Int32.Parse(this.txtTotalYear.Text);
            int newTotalAge = currentAge + person.getAge();
            this.txtTotalYear.Text = newTotalAge.ToString();
        }
    }
}