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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EntityFrameworkCRUDWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CRUD entityFramework;
        private Person dataGridPerson;

        public MainWindow()
        {
            InitializeComponent();
            entityFramework = new CRUD();
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            DataGridPeople.ItemsSource = entityFramework.GetAllPeopleByList();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Window CreatePerson = new CreateUpdateWindow();
            CreatePerson.Show();
            Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            dataGridPerson = (Person)DataGridPeople.SelectedItem;
            if (dataGridPerson != null)
            {
                Window UpdatePerson = new CreateUpdateWindow(dataGridPerson);
                UpdatePerson.Show();
                Close();
            }
            else
                MessageBox.Show("Select person to update", "Select Person");
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            dataGridPerson = (Person)DataGridPeople.SelectedItem;
            if (dataGridPerson != null)
            {
                if(MessageBox.Show("Are you sure you want to remove: " + dataGridPerson.FirstName,
                    "Delete Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {
                        entityFramework.DeletePerson(dataGridPerson.Id);
                        MessageBox.Show("Record successfully deleted", "Delete success");
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                    finally
                    {
                        PopulateDataGrid();
                    }
                }
            }                
        }           
    }
}

