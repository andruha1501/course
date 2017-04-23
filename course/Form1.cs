using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace course
{
    public partial class Form1 : Form
    {
        List<Abiturient> abiturient = new List<Abiturient>();
        Abiturient abit1 = new Abiturient();



        private void Read_List()
        {
            StreamReader stream = new StreamReader("Abiturient.txt");
            abiturient.Clear();

            while(stream.ReadLine() == "^_^")
            {
                abiturient.Add(new Abiturient());
                abiturient[abiturient.Count - 1] = new Abiturient();

                abiturient[abiturient.Count - 1].Surname = stream.ReadLine();
                abiturient[abiturient.Count - 1].Name = stream.ReadLine();
                abiturient[abiturient.Count - 1].LastName = stream.ReadLine();

                abiturient[abiturient.Count - 1].Birthday = stream.ReadLine();
                abiturient[abiturient.Count - 1].Nationality = stream.ReadLine();

                abiturient[abiturient.Count - 1].PlaceLive = stream.ReadLine();

                abiturient[abiturient.Count - 1].Document = stream.ReadLine();
                abiturient[abiturient.Count - 1].NumberDocument = stream.ReadLine();

                abiturient[abiturient.Count - 1].NumberTelefone = stream.ReadLine();
                abiturient[abiturient.Count - 1].Email = stream.ReadLine();

                abiturient[abiturient.Count - 1].Average = stream.ReadLine();
                abiturient[abiturient.Count - 1].Subject1 = stream.ReadLine();
                abiturient[abiturient.Count - 1].Subject2 = stream.ReadLine();
                abiturient[abiturient.Count - 1].Subject3 = stream.ReadLine();
                abiturient[abiturient.Count - 1].Complex = Int32.Parse(stream.ReadLine());
                abiturient[abiturient.Count - 1].PlusComplex = stream.ReadLine();
                abiturient[abiturient.Count - 1].Contract = stream.ReadLine();
              
            }

            stream.Close();
            PrintA();
            Init_comboBoxBase();
        }

        private void Init_comboBoxBase() 
        {
            comboBoxBase.Items.Clear();

            for (int i = 0; i < abiturient.Count; i++)
                comboBoxBase.Items.Add(abiturient[i].Surname);
        }

        private void PrintA() 
        {
            dataGridViewInformation.Rows.Clear();

            for (int i = 0; i < abiturient.Count; i++)
            {
                dataGridViewInformation.Rows.Add(AddToGrid(i, abiturient));
            }
        }

        internal DataGridViewRow AddToGrid(int i, List<Abiturient> abit) 
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewCell Surname = new DataGridViewTextBoxCell();
            Surname.Value = abit[i].Surname;

            DataGridViewCell Name = new DataGridViewTextBoxCell();
            Name.Value = abit[i].Name;

            DataGridViewCell LastName = new DataGridViewTextBoxCell();
            LastName.Value = abit[i].LastName;

            DataGridViewCell Birthday = new DataGridViewTextBoxCell();
            Birthday.Value = abit[i].Birthday;

            DataGridViewCell Nationality = new DataGridViewTextBoxCell();
            Nationality.Value = abit[i].Nationality;


            DataGridViewCell PlaceLive = new DataGridViewTextBoxCell();
            PlaceLive.Value = abit[i].PlaceLive;

            DataGridViewCell Document = new DataGridViewTextBoxCell();
            Document.Value = abit[i].Document;

            DataGridViewCell NumberDocument = new DataGridViewTextBoxCell();
            NumberDocument.Value = abit[i].NumberDocument;

            DataGridViewCell NumberTelefone = new DataGridViewTextBoxCell();
            NumberTelefone.Value = abit[i].NumberTelefone;

            DataGridViewCell Email = new DataGridViewTextBoxCell();
            Email.Value = abit[i].Email;

            DataGridViewCell Average = new DataGridViewTextBoxCell();
            Average.Value = abit[i].Average;

            DataGridViewCell Subject1 = new DataGridViewTextBoxCell();
            Subject1.Value = abit[i].Subject1;

            DataGridViewCell Subject2 = new DataGridViewTextBoxCell();
            Subject2.Value = abit[i].Subject2;

            DataGridViewCell Subject3 = new DataGridViewTextBoxCell();
            Subject3.Value = abit[i].Subject3;

            DataGridViewCell Complex = new DataGridViewTextBoxCell();
            Complex.Value = abit[i].Complex;

            DataGridViewCell PlusComplex = new DataGridViewTextBoxCell();
            PlusComplex.Value = abit[i].PlusComplex;

            DataGridViewCell Contract = new DataGridViewTextBoxCell();
            Contract.Value = abit[i].Contract;


            row.Cells.Add(Surname);
            row.Cells.Add(Name);
            row.Cells.Add(LastName);
            row.Cells.Add(Birthday);
            row.Cells.Add(Nationality);
            row.Cells.Add(PlaceLive);
            row.Cells.Add(Document);
            row.Cells.Add(NumberDocument);
            row.Cells.Add(NumberTelefone);
            row.Cells.Add(Email);
            row.Cells.Add(Average);
            row.Cells.Add(Subject1);
            row.Cells.Add(Subject2);
            row.Cells.Add(Subject3);
            row.Cells.Add(Complex);
            row.Cells.Add(PlusComplex);
            row.Cells.Add(Contract);

            return row;
        }

        public Form1()
        {
           
            InitializeComponent();
         
         
            Read_List();
        }
        

        private void comboBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void добавитьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choosen();
        }

        public void Choosen() 
        {
            if (comboBoxBase.SelectedItem != null) 
            {
                dataGridViewInformation.Rows.Clear();

                int count = 0;

                List<Abiturient> choosen = new List<Abiturient>(); 
                abit1.SortAbit(choosen);

                for (int i = 0; i < abiturient.Count; i++)
                {
                    if (abiturient[i].Surname == comboBoxBase.SelectedItem.ToString())
                    {
                        choosen.Add(new Abiturient());
                        choosen[choosen.Count - 1] = new Abiturient();

                        choosen[choosen.Count - 1].Surname = abiturient[i].Surname;
                        choosen[choosen.Count - 1].Name = abiturient[i].Name;
                        choosen[choosen.Count - 1].LastName = abiturient[i].LastName;

                        choosen[choosen.Count - 1].Birthday = abiturient[i].Birthday;
                        choosen[choosen.Count - 1].Nationality = abiturient[i].Nationality;

                        choosen[choosen.Count - 1].PlaceLive = abiturient[i].PlaceLive;

                        choosen[choosen.Count - 1].Document = abiturient[i].Document;
                        choosen[choosen.Count - 1].NumberDocument = abiturient[i].NumberDocument;

                        choosen[choosen.Count - 1].NumberTelefone = abiturient[i].NumberTelefone;
                        choosen[choosen.Count - 1].Email = abiturient[i].Email;

                        choosen[choosen.Count - 1].Average = abiturient[i].Average;
                        choosen[choosen.Count - 1].Subject1 = abiturient[i].Subject1;
                        choosen[choosen.Count - 1].Subject2 = abiturient[i].Subject2;
                        choosen[choosen.Count - 1].Subject3 = abiturient[i].Subject3;
                        choosen[choosen.Count - 1].Complex = abiturient[i].Complex;
                        choosen[choosen.Count - 1].PlusComplex = abiturient[i].PlusComplex;
                        choosen[choosen.Count - 1].Contract = abiturient[i].Contract;

                        dataGridViewInformation.Rows.Add(AddToGrid(count, choosen)); 

                        count++;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abit1.SortAbit(abiturient);
            Read_List();
            
        }

        private void добавитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add newForm = new add(); 
            newForm.Owner = this;
            newForm.ShowDialog();
        }
    }
}
