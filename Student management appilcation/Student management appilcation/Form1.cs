using System.Text;

namespace Student_management_appilcation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void addDatatoGridView(Student student)
        {
            this.dataGridView1.DataSource = student;
        }
        private void toolStripMenuOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string studentRAW = readAllLine[i];
                    string[] studentSplited = studentRAW.Split(',');
                    Student student = new Student(studentSplited[0], studentSplited[1], studentSplited[2]);
                    addDatatoGridView(studentSplited[0], studentSplited[1], studentSplited[2]);
                    //TODO: Add student obj to dataGribview
                }

                //TODO: calculate max, min, gpax

            }

        }

        

        void addDatatoGridView(string id , string name , string major) {
            this.dataGridView1.Rows.Add(new string[] { id , name , major });
        }

        private void toolStripMenuSave_Click(object sender, EventArgs e)
        {

            string strData = string.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {


                    int row = this.dataGridView1.Rows.Count;
                    for (int i = 0; i < row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for (int j = 0; j < column; j++)
                        {
                            strData = this.dataGridView1.Rows[i].Cells[j].RowIndex.ToString();
                            //TODO: save data from datagridview to variable
                        }
                    }
                    //save file 
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);
                }
            }


        }
        double sum = 0;
        int n = 0;
        double max = 0;
        double min = 1;
        
        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: add data to datagribview

            this.dataGridView1.Rows.Add(textBoxID_input.Text, textBoxName_input.Text, comboBox1.Text,textBoxGpa_input.Text);

            
            textBoxID_input.Text = "";
            textBoxName_input.Text = "";

            //TODO: Calculate GPAX, Max, Min

            //name
            string strname = textBoxName_input.Text;
            


            //GPA
            string strgpa = textBoxGpa_input.Text;
            double Ginput = double.Parse(strgpa);

           
            if (Ginput < min)
                min = Ginput;

            if (Ginput > max)
                max = Ginput;

            
            sum = sum + Ginput;
            n = n + 1;


            double Regpax = sum / n;
            textBoxGPAX.Text = Regpax.ToString();


            textBoxMax.Text = max.ToString();

            textBoxMin.Text = min.ToString();


            textBoxGpa_input.Text = "";
        }



    }
}