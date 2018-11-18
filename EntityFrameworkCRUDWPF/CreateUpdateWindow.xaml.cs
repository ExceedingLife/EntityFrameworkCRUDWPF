using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EntityFrameworkCRUDWPF
{
    /// <summary>
    /// Interaction logic for CreateUpdateWindow.xaml
    /// </summary>
    public partial class CreateUpdateWindow : Window
    {
        private CRUD entityFramework;
        private Person personWindowObject;
        private int numberTest = 0;

        public CreateUpdateWindow()
        {
            InitializeComponent();
            entityFramework = new CRUD();
            LblIdlabel.Visibility = Visibility.Hidden;
            LblIdInput.Visibility = Visibility.Hidden;
            LblHeader.Content = "Create New Profile";
        }
        public CreateUpdateWindow(Person insertedPerson)
        {
            InitializeComponent();
            entityFramework = new CRUD();
            LblHeader.Content = "Update Selected Profile";
            if(insertedPerson != null)
            {
                personWindowObject = insertedPerson;
                numberTest = insertedPerson.Id;
                PopulatePersonControls(insertedPerson);
            }            
        }

        private void PopulatePersonControls(Person populatePerson)
        {
            if (populatePerson != null)
            {
                DateTime personDate = Convert.ToDateTime(populatePerson.DateCreated);
                LblIdlabel.Content = "Your ID:\t";
                LblIdInput.Content = populatePerson.Id + "\tCreated On: " + personDate.ToString("MM/dd/yyyy");
                TxtFirstName.Text = populatePerson.FirstName;
                TxtLastName.Text = populatePerson.LastName;
                TxtAge.Text = populatePerson.Age.ToString();
                TxtProgrammingLanguage.Text = populatePerson.ProgrammingLanguage;
            }

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Person personObject = new Person();

            if (!string.IsNullOrEmpty(TxtFirstName.Text))
            {
                personObject.FirstName = TxtFirstName.Text;
            }
            else
                MessageBox.Show("Enter a First Name", "First Name txtbox");
            if (!string.IsNullOrEmpty(TxtLastName.Text))
            {
                personObject.LastName = TxtLastName.Text;
            }
            else
                MessageBox.Show("Enter a Last Name", "Last Name txtbox");
            if (!string.IsNullOrEmpty(TxtAge.Text))
            {
                int number;
                if (int.TryParse(TxtAge.Text, out number))
                {
                    personObject.Age = Convert.ToInt32(TxtAge.Text);
                }
                else
                {
                    MessageBox.Show("Age must be a number.", "Incorrect value");
                    return;
                }                                  
            }
            else
                MessageBox.Show("Enter a Age", "Age txtbox");
            if (!string.IsNullOrEmpty(TxtProgrammingLanguage.Text))
            {
                personObject.ProgrammingLanguage = TxtProgrammingLanguage.Text;
            }
            else
                MessageBox.Show("Enter a Programming Language", "Programming Language txtbox");

            try
            {
                if(numberTest >= 1)
                {
                    personObject.Id = personWindowObject.Id;
                    personObject.DateCreated = personWindowObject.DateCreated;
                    entityFramework.UpdatePerson(personObject);
                    MessageBox.Show("Person successfully updated!", "Update");
                    Window mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    DateTime dateNow = DateTime.Now;
                    personObject.DateCreated = dateNow;
                    entityFramework.CreatePerson(personObject);
                    MessageBox.Show("Created new person.", "Created");
                    Window mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
