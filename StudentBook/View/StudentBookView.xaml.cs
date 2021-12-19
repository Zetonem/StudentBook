using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentBook.View
{
    /// <summary>
    /// Логика взаимодействия для StudentBookView.xaml
    /// </summary>
    public partial class StudentBookView : UserControl
    {
        private const String EmployeeViewName = "EmployeeView";
        private const String StudentViewName = "StudentView";
        private const String TeacherViewName = "TeacherView";

        public StudentBookView()
        {
            InitializeComponent();
        }

        public StudentBookView(String role)
        {
            InitializeComponent();
            DisableFields(role);
        }

        void DisableFields(String role)
        {
            switch (role)
            {
                case EmployeeViewName:
                    lastNameTextBox.IsEnabled = false;
                    firstNameTextBox.IsEnabled = false;
                    patronymicTextBox.IsEnabled = false;
                    facultyTextBox.IsEnabled = false;
                    specialityTextBox.IsEnabled = false;
                    groupTextBox.IsEnabled = false;
                    issueDateDatePicker.IsEnabled = false;
                    numberTextBox.IsEnabled = false;
                    rankTextBox.IsEnabled = false;
                    lastNameChairHeadTextBox.IsEnabled = false;
                    firstNameChairHeadTextBox.IsEnabled = false;
                    patronymicChairHeadTextBox.IsEnabled = false;
                    positionTextBox.IsEnabled = false;
                    telNumberTextBox.IsEnabled = false;
                    stringDigitTextBox.IsEnabled = false;
                    digitTextBox.IsEnabled = false;
                    break;
                case StudentViewName:
                    railwayTextBox.IsEnabled = false;
                    locationTextBox.IsEnabled = false;
                    startDatePicker.IsEnabled = false;
                    endDatePicker.IsEnabled = false;
                    work1TextBox.IsEnabled = false;
                    work2TextBox.IsEnabled = false;
                    work3TextBox.IsEnabled = false;
                    relationTextBox.IsEnabled = false;
                    issueDateDatePicker.IsEnabled = false;
                    numberTextBox.IsEnabled = false;
                    rankTextBox.IsEnabled = false;
                    firstNameProductionHeadTextBox.IsEnabled = false;
                    lastNameProductionHeadTextBox.IsEnabled = false;
                    patronymicProductionHeadTextBox.IsEnabled = false;
                    lastNameChairHeadTextBox.IsEnabled = false;
                    firstNameChairHeadTextBox.IsEnabled = false;
                    patronymicChairHeadTextBox.IsEnabled = false;
                    positionTextBox.IsEnabled = false;
                    telNumberTextBox.IsEnabled = false;
                    stringDigitTextBox.IsEnabled = false;
                    digitTextBox.IsEnabled = false;
                    break;
                case TeacherViewName:
                    lastNameTextBox.IsEnabled = false;
                    firstNameTextBox.IsEnabled = false;
                    patronymicTextBox.IsEnabled = false;
                    facultyTextBox.IsEnabled = false;
                    specialityTextBox.IsEnabled = false;
                    groupTextBox.IsEnabled = false;
                    railwayTextBox.IsEnabled = false;
                    locationTextBox.IsEnabled = false;
                    startDatePicker.IsEnabled = false;
                    endDatePicker.IsEnabled = false;
                    work1TextBox.IsEnabled = false;
                    work2TextBox.IsEnabled = false;
                    work3TextBox.IsEnabled = false;
                    relationTextBox.IsEnabled = false;
                    firstNameProductionHeadTextBox.IsEnabled = false;
                    lastNameProductionHeadTextBox.IsEnabled = false;
                    patronymicProductionHeadTextBox.IsEnabled = false;
                    break;
            }
        }
    }
}
