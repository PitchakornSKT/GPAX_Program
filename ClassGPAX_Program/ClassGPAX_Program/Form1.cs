namespace ClassGPAX_Program
{
    public partial class Form1 : Form
    {
        Classroom classroom; 
        public Form1()
        {
            InitializeComponent();

            classroom = new Classroom("OOP");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string input_name = this.txtName.Text;
            string input_year = this.txtYear.Text;
            int iYear = Int32.Parse(input_year);
            
            Person person = new Person(input_name, iYear);
            this.classroom.addPerson2Class(person);
            
            this.txtListName.Text = this.classroom.showAllPersoninClass();
           
            this.txtTotalYear.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}