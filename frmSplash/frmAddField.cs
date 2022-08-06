using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace frmSplash
{
    public partial class frmAddField : Form
    {
        SqlConnection connection;
        string connectionString;
        string Querystring;
        bool ContainsNumbers;
        List<bool> ValidFields = new List<bool>();
        bool ValidFirstName;
        bool ValidSurname;
        int FieldLength;
        DateTime EnteredDate = new DateTime();
        string SelectedDate;
        bool SpacePresent;
        int Spacelocation;
        string TextStringTest;
        char[] StringChracters = new char[50];
        string NumberStringTest;
        bool containsLetters;
        string FirstSection;
        string SecondSection;
        bool PresenceOfSymbols;
        bool PresenceOfPunctuation;


        public frmAddField()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmAddField_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 12; x++)
            {
                ValidFields.Add(false);
            }

            cbFieldInfo1.Hide();
            cbFieldInfo2.Hide();
            cbFieldInfo3.Hide();
            CheckBox1.Hide();
            btnCalender.Hide();
            Calender1.Hide();
            lblErrorPlaceholder2.Hide();
            lblErrorPlaceholder3.Hide();
            lblErrorPlaceholder4.Hide();
            lblErrorPlaceholder5.Hide();
            lblErrorPlaceholder6.Hide();
            lblErrorPlaceholder7.Hide();
            lblErrorPlaceholder8.Hide();
            lblErrorPlaceholder9.Hide();
            lblErrorPlaceholder10.Hide();
            lblErrorPlaceholder11.Hide();
            lblErrorPlaceholder12.Hide();
            lblErrorPlaceholder13.Hide();

            DisplayDetails();
            HideExcessInformation();
           
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                frmStudents StudentTable = new frmStudents();
                StudentTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                frmTeachers TeacherTable = new frmTeachers();
                TeacherTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                frmInstrument InstrumentTable = new frmInstrument();
                InstrumentTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "RoomTable")
            {
                frmRoom RoomTable = new frmRoom();
                RoomTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "GradeTable")
            {
                frmGrade GradeTable = new frmGrade();
                GradeTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {
                frmLessonBundle LessonBundleTable = new frmLessonBundle();
                LessonBundleTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {
                //
            }
            else if (GlobalVariables.PreviousForm == "PurchasedLessonBundleTable")
            {
                //
            }

            lblFieldData2.Show();
            lblFieldData3.Show();
            lblFieldData4.Show();
            lblFieldData5.Show();
            lblFieldData6.Show();
            lblFieldData7.Show();
            lblFieldData8.Show();
            lblFieldData9.Show();
            lblFieldData10.Show();
            lblFieldData11.Show();
            lblFieldData12.Show();
            lblFieldData13.Show();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //if (GlobalVariables.StudentTable == true && Valid == true)
            //{
            //    using (connection = new SqlConnection(connectionString))
            //    using (SqlCommand AddStudent = new SqlCommand(Querystring, connection))
            //    {
            //        connection.Open();
            //        AddStudent.Parameters.AddWithValue("@First_Name", tbFieldInfo2.Text);
            //        AddStudent.Parameters.AddWithValue("@Other_Name(s)", tbFieldInfo3.Text);
            //        AddStudent.Parameters.AddWithValue("@Surname", tbFieldInfo4.Text);
            //        AddStudent.Parameters.AddWithValue("@Date_Of_Birth", tbFieldInfo5.Text);
            //        AddStudent.Parameters.AddWithValue("@Address", tbFieldInfo6.Text);
            //        AddStudent.Parameters.AddWithValue("@Town", tbFieldInfo7.Text);
            //        AddStudent.Parameters.AddWithValue("@PostCode", tbFieldInfo8.Text);
            //        AddStudent.Parameters.AddWithValue("@Contact_Number", tbFieldInfo9.Text);
            //        AddStudent.Parameters.AddWithValue("@Email_Address", tbFieldInfo10.Text);
            //        AddStudent.Parameters.AddWithValue("@GradeID", tbFieldInfo11.Text);
            //        AddStudent.Parameters.AddWithValue("@InstrumentID", tbFieldInfo12.Text);
            //        AddStudent.Parameters.AddWithValue("@Tuition_Fee_Recieved", tbFieldInfo13.Text);
            //        AddStudent.ExecuteNonQuery();
            //        connection.Close();
            //    }
            //    frmStudents Students = new frmStudents();
            //    Students.Close();
            //    Students.Show();
            //    this.Hide();
            //}
            //else
            //{
            //}

            lblErrorPlaceholder2.Hide();
            lblErrorPlaceholder3.Hide();
            lblErrorPlaceholder4.Hide();
            lblErrorPlaceholder5.Hide();
            lblErrorPlaceholder6.Hide();
            lblErrorPlaceholder7.Hide();
            lblErrorPlaceholder8.Hide();
            lblErrorPlaceholder9.Hide();
            lblErrorPlaceholder10.Hide();
            lblErrorPlaceholder11.Hide();
            lblErrorPlaceholder12.Hide();
            lblErrorPlaceholder13.Hide();

            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                StudentValidation();
            }
        }


        public void StudentValidation()
        {
            // Sets bool true if number is located.
            ContainsNumbers = tbFieldInfo2.Text.Any(char.IsDigit);
            PresenceOfPunctuation = tbFieldInfo2.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo2.Text.Any(char.IsSymbol);

            // First Name Field
            if (tbFieldInfo2.Text != "")
            {
                // If Field Contains a value. <Run If Statement>

                if (PresenceOfPunctuation == false && PresenceOfSymbols == false)
                {
                    // If Field does not contain a non-numeric or alphabetical character. <Run If Statement>
                    if (ContainsNumbers == true)
                    {
                        // If value contains numeric Characters. <Error Message>
                        ValidFields[0] = false;
                        lblErrorPlaceholder2.Show();
                        lblErrorPlaceholder2.Text = "Please Remove Numerical Characters.";
                    }
                    else
                    {
                        // Value Contains solely text. <Validate Field>
                        ValidFields[0] = true;
                    }
                }
                else
                {
                    // If field does contain non-Numeric or Alphabetical characters. <Error Message>
                    ValidFields[0] = false;
                    lblErrorPlaceholder2.Show();
                    lblErrorPlaceholder2.Text = "Please Remove Symbols or Punctuation.";
                }
            }
            else
            {
                // If Textbox contains no value.
                ValidFields[0] = false;
                lblErrorPlaceholder2.Show();
                lblErrorPlaceholder2.Text = "Data Required. Please Complete.";
            }




            // OtherName(s) Field
            ContainsNumbers = tbFieldInfo3.Text.Any(char.IsDigit);
            PresenceOfPunctuation = tbFieldInfo3.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo3.Text.Any(char.IsSymbol);


            if (tbFieldInfo3.Text != "")
            {
                // If field contains a value. <Run If Statement>

                if (PresenceOfSymbols == false && PresenceOfPunctuation == false)
                {
                    // If value does not contain non-alphapetical or numerical values. <Run IF Statement>

                    if (ContainsNumbers == true)
                    {
                        // If Value Contains Numerical characters. <Error Message>
                        ValidFields[1] = false;
                        lblErrorPlaceholder3.Show();
                        lblErrorPlaceholder3.Text = "Please Remove Numerical Characters.";
                    }
                    else
                    {
                        // If value contains no numerical characters or symbols. <Validate Field>
                        ValidFields[1] = true;
                    }
                }
                else
                {
                    // If Value Contains symbol(s). <Error Message>
                    ValidFields[1] = false;
                    lblErrorPlaceholder3.Show();
                    lblErrorPlaceholder3.Text = "Please remove symbols or punctuation.";
                }
            }
            else
            {
                // If no value present. <Erro Message>
                ValidFields[1] = false;
                lblErrorPlaceholder3.Show();
                lblErrorPlaceholder3.Text = "Data Required. please Complete.";
            }





            // Surname Field
            ContainsNumbers = tbFieldInfo4.Text.Any(char.IsDigit);
            PresenceOfPunctuation = tbFieldInfo4.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo4.Text.Any(char.IsSymbol);


            if (tbFieldInfo4.Text != "")
            {
                // If field contains a value. <Run If Statement>

                if (PresenceOfPunctuation == false && PresenceOfSymbols == false)
                {
                    // Value does not contain symbols. <Run If Statement>

                    if (ContainsNumbers == true)
                    {
                        // Value Contains Numbers. <Error Message>

                        ValidFields[2] = false;
                        lblErrorPlaceholder4.Show();
                        lblErrorPlaceholder4.Text = "Please Remove Numerical Characters.";
                    }
                    else
                    {
                        // Value contains valid characters. <Validate Field>
                        ValidFields[2] = true;
                    }
                }
                else
                {
                    // Value contains symbols. <Error Message>
                    ValidFields[2] = false;
                    lblErrorPlaceholder4.Show();
                    lblErrorPlaceholder4.Text = "please Remove Symbols or punctuation.";
                }
            }
            else
            {
                // No Value Present. <Error Message>
                ValidFields[2] = false;
                lblErrorPlaceholder4.Show();
                lblErrorPlaceholder4.Text = "Data Required. Please Complete.";
            }




            // Date Of Birth Field
            if (tbFieldInfo5.Text != "")
            {
                // Value is present. <Run IF Statement>

                EnteredDate = Convert.ToDateTime(tbFieldInfo5.Text);
                if (EnteredDate > DateTime.Today)
                {
                    // Entered Date > CurrentDate. <Error Message>
                    ValidFields[3] = false;
                    lblErrorPlaceholder5.Show();
                    lblErrorPlaceholder5.Text = "Please select prior date.";
                }
                else
                {
                    // Date is Valid. <Validate Field>.
                    ValidFields[3] = true;
                }
            }
            else
            {
                // No Value Present. <Error Message>
                ValidFields[3] = false;
                lblErrorPlaceholder5.Show();
                lblErrorPlaceholder5.Text = "Data Required. Please use Calender provided.";
            }




            //Address Field
            int y = 0;
            SpacePresent = false;
            Spacelocation = 0;
            containsLetters = true;
            ContainsNumbers = true;
            FirstSection = "";
            SecondSection = "";
            PresenceOfPunctuation = tbFieldInfo4.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo4.Text.Any(char.IsSymbol);



            if (tbFieldInfo6.Text != "")
            {
                SpacePresent = false;
                StringChracters = tbFieldInfo6.Text.ToCharArray();

                while (SpacePresent == false)
                {
                    while (y < StringChracters.Length)
                    {
                        if (StringChracters[y] == ' ')
                        {
                            Spacelocation = y;
                            break;
                        }
                        y++;
                    }
                    break;
                }


                if (Spacelocation > 0)
                {
                    SpacePresent = true;

                }
            }


            if (tbFieldInfo6.Text != "")
            {
                // If Value is present. <Run Statement>

                if (PresenceOfSymbols == false && PresenceOfPunctuation == false)
                {
                    // If No symbols present. <Run Statement>

                    if (SpacePresent == true)
                    {
                        // These lines of code segment the address number and the street.
                        FirstSection = tbFieldInfo6.Text.Substring(0, (y));
                        SecondSection = tbFieldInfo6.Text.Substring((y + 1), ((tbFieldInfo6.TextLength - FirstSection.Length) - 1));

                        // Test address number for text.
                        containsLetters = FirstSection.Any(Char.IsLetter);

                        // Test the address name for numbers.
                        ContainsNumbers = SecondSection.Any(Char.IsNumber);


                        if (FirstSection != "" && SecondSection != "")
                        {
                            if (containsLetters == false && ContainsNumbers == false)
                            {
                                // If both sections are validated. <Validate this field>
                                ValidFields[4] = true;
                            }
                            else if (containsLetters == true && ContainsNumbers == false)
                            {
                                // If first section invalid, yet second valid. <Error Message>
                                ValidFields[4] = false;
                                lblErrorPlaceholder6.Show();
                                lblErrorPlaceholder6.Text = "Please Remove alphametical Characters from street number.";

                            }
                            else if (containsLetters == false && ContainsNumbers == true)
                            {
                                // If first section valid, yet second invalid. <Error Messagae>
                                ValidFields[4] = false;
                                lblErrorPlaceholder6.Show();
                                lblErrorPlaceholder6.Text = "Please Remove Numerical Characters from street name.";
                            }
                            else if (containsLetters == true && ContainsNumbers == true)
                            {
                                // If first section valid, yet second invalid. <Error Messagae>
                                ValidFields[4] = false;
                                lblErrorPlaceholder6.Show();
                                lblErrorPlaceholder6.Text = "Invalid Characters. Please Review.";
                            }
                        }
                    }
                    else
                    {
                        // Space not present, thus field does not contain proper format. <Error Message>
                        ValidFields[4] = false;
                        lblErrorPlaceholder6.Show();
                        lblErrorPlaceholder6.Text = "Space Neccessary between house Number and Street.";
                    }
                }
                else
                {
                    // Symbol present in value. <Error Message>
                    ValidFields[4] = false;
                    lblErrorPlaceholder6.Show();
                    lblErrorPlaceholder6.Text = "Please Remove Symbol or punctuation.";
                }
            }
            else
            {
                // Field does not contain text. <Error Message>
                ValidFields[4] = false;
                lblErrorPlaceholder6.Show();
                lblErrorPlaceholder6.Text = "Data Required. Please Complete.";
            }




            // Continue From this poimt
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //

            // Town Field
            ContainsNumbers = tbFieldInfo7.Text.Any(char.IsDigit);

                if (tbFieldInfo7.Text != "")
                {
                    if (ContainsNumbers == true)
                    {
                        ValidFields[5] = false;
                        lblErrorPlaceholder7.Show();
                        lblErrorPlaceholder7.Text = "The Town value entered is incorrect, please ensure that no numerical values are present.";
                    }
                    else
                    {

                        ValidFields[5] = true;
                    }
                }
                else
                {
                    ValidFields[5] = false;
                    lblErrorPlaceholder7.Show();
                    lblErrorPlaceholder7.Text = "The Town value entered is incorrect, please enter text.";
                }




                // postCode Field
                if (tbFieldInfo8.Text != "")
            {

                // If textbox contains a value. <Run if statement>
                if (tbFieldInfo8.TextLength == tbFieldInfo8.MaxLength)
                {
                    // If entered value length matches total field length. <Start Validation>
                    string PostcodeLetters = tbFieldInfo8.Text.Substring(0, 2) + tbFieldInfo8.Text.Substring(5, 2);
                    string PostcodeNumbers = tbFieldInfo8.Text.Substring(2, 3);
                    bool ValidPostLetters = false;
                    bool validPostNumbers = false;

                    // <Run if Statement>
                    if (ValidPostLetters == true && validPostNumbers == true)
                    {
                        // If the entered value matches the designated format. <Validate Field>
                        ValidFields[6] = true;
                    }
                    else if(ValidPostLetters == false && validPostNumbers == true)
                    {
                        // If letters contain invalid characters, yet numbers match format. <Error Message>
                        ValidFields[6] = false;
                        lblErrorPlaceholder8.Show();
                        lblErrorPlaceholder8.Text = "The PostCode contains numerical values in text locations. Please use the format LL000LL";

                    }
                    else if(ValidPostLetters == true && validPostNumbers == false)
                    {
                        // If numbers contain invalid characters, yet letters match format. <Error Message>
                        ValidFields[6] = false;
                        lblErrorPlaceholder8.Show();
                        lblErrorPlaceholder8.Text = "The PostCode contains alphabetical values in number locations. Please use the format LL000LL";

                    }
                    else if(ValidPostLetters == false && validPostNumbers == false)
                    {
                        // If value does not match format at all. <Error Message>

                    }
                }
                else
                {
                    // If entered text does not use all values, it cannot attempt to match designated format. <Error Message>

                }
            }
            else
            {
                // Field does not contian a value. <Erro Message>

            }




                if (tbFieldInfo8.TextLength == tbFieldInfo8.MaxLength)
                {
                    string PostcodeLetters = tbFieldInfo8.Text.Substring(0, 2) + tbFieldInfo8.Text.Substring(5, 2);
                    string PostcodeNumbers = tbFieldInfo8.Text.Substring(2, 3);
                    bool LettersValid;
                    bool NumbersValid;

                    LettersValid = PostcodeLetters.Any(char.IsDigit);
                    NumbersValid = PostcodeNumbers.Any(char.IsLetter);

                    if (LettersValid == true && NumbersValid == true)
                    {
                        ValidFields[6] = false;
                        lblErrorPlaceholder8.Show();
                        lblErrorPlaceholder8.Text = "The PostCode entered is incorrect, please ensure that no alphabetical values are present.";
                    }
                    else
                    {

                        ValidFields[6] = true;
                    }

                }



                // Contact Number
                containsLetters = tbFieldInfo9.Text.Any(char.IsLetter);

                if (tbFieldInfo7.Text != "")
                {
                    if (containsLetters == true)
                    {
                        ValidFields[7] = false;
                        lblErrorPlaceholder9.Show();
                        lblErrorPlaceholder9.Text = "The Contact Number entered is incorrect, please ensure that no alphabetical values are present.";
                    }
                    else
                    {

                        ValidFields[7] = true;
                    }
                }
                else
                {
                    ValidFields[7] = false;
                    lblErrorPlaceholder9.Show();
                    lblErrorPlaceholder9.Text = "The Town value entered is incorrect, please enter text.";
                }
            }




            // Email Address
            //int A = 0;
            //bool test4 = false;
            //int location = 0;


            //if (tbFieldInfo10.Text != "")
            //{
            //    while (test4 == false)
            //    {
            //        while (A < tbFieldInfo10.TextLength)
            //        {
            //            StringChracters = Convert.ToChar(tbFieldInfo10.Text.Substring(A, 1));
            //            if (StringChracters == '@')
            //            {
            //                test4 = true;
            //                location = A;
            //            }
            //        }
            //    }

            //    if (test4 != true)
            //    {
            //        ValidFields[8] = false;
            //        lblErrorPlaceholder10.Show();
            //        lblErrorPlaceholder10.Text = "The Town value entered is incorrect, please enter text.";
            //    }
            //    else
            //    {

            //        ValidFields[8] = true;
            //    }
        //    }
        //}





        public void DisplayDetails()
        {
            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                lblFieldData2.Text = "First Name:";
                lblFieldData3.Text = "Other Name(s):";
                lblFieldData4.Text = "Surname";
                lblFieldData5.Text = "Date Of Birth:";
                lblFieldData6.Text = "Address:";
                lblFieldData7.Text = "Town";
                lblFieldData8.Text = "PostCode";
                lblFieldData9.Text = "Contact Number:";
                lblFieldData10.Text = "Email Address";
                lblFieldData11.Text = "GradeID";
                lblFieldData12.Text = "InstrumentID";
                lblFieldData13.Text = "Tuition Fee Recieved:";

                tbFieldInfo11.Hide();
                cbFieldInfo1.Show();
                cbFieldInfo1.Location = new Point(146, 495);

                tbFieldInfo12.Hide();
                cbFieldInfo2.Show();
                cbFieldInfo2.Location = new Point(146, 527);

                tbFieldInfo13.Hide();
                CheckBox1.Show();
                CheckBox1.Location = new Point(146, 559);

                btnCalender.Show();
                btnCalender.Location = new Point(308, 297);

                tbFieldInfo2.MaxLength = 50;
                tbFieldInfo3.MaxLength = 50;
                tbFieldInfo4.MaxLength = 50;
                tbFieldInfo5.MaxLength = 10;
                tbFieldInfo6.MaxLength = 50;
                tbFieldInfo7.MaxLength = 50;
                tbFieldInfo8.MaxLength = 7; 
                tbFieldInfo9.MaxLength = 8; // WIthout first 3 digits
                tbFieldInfo10.MaxLength = 50;

                tbFieldInfo5.Enabled = false;


                lbMain.Text = "Add Student";
                btnAddRecord.Text = "Add New Student";
                btnReturn.Text = "Return to Students Table";

                Querystring = "INSERT INTO Students VALUES(@First_Name, @Other_Name(s), @Surname, @Date_Of_Birth, @Address, @Town, @PostCode, @Contact_Number, @Email_Address, @GradeID, @InstrumentID, @Tuition_Fee_Recieved)";
            }

            else if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                lblFieldData2.Text = "First Name:";
                lblFieldData3.Text = "Surname:";
                lblFieldData4.Text = "Address:";
                lblFieldData5.Text = "Town:";
                lblFieldData6.Text = "PostCode:";
                lblFieldData7.Text = "Email Address:";
                lblFieldData8.Text = "Contact Number:";
                lblFieldData9.Text = "Specialisation:";
                lblFieldData10.Text = "RoomID:";

                tbFieldInfo10.Hide();
                cbFieldInfo1.Show();
                cbFieldInfo1.Location = new Point(146, 381);

                lbMain.Text = "Add Teacher";
                btnAddRecord.Text = "Add New Teacher";
                btnReturn.Text = "Return to Teacher Table";

                Querystring = "INSERT INTO Teachers VALUES(@First_Name, @Surname, @Address, @Town, @PostCode, @Email_Address, @Contact_Number, @Specialisation, @RoomID";
            }

            else if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                lblFieldData2.Text = "Instrument Type:";
                lblFieldData3.Text = "Instrument Name:";
                lblFieldData4.Text = "Quantity:";

                tbFieldInfo2.Hide();
                cbFieldInfo1.Show();
                cbFieldInfo1.Location = new Point(146, 125);

                lbMain.Text = "Add Instrument";
                btnAddRecord.Text = "Add New Instrument";
                btnReturn.Text = "Return to Instrument Table";

                Querystring = "INSERT INTO Instruments VALUES(@Instrument Type, @Instrument Name, @Quantity";
            }

            else if (GlobalVariables.PreviousForm == "RoomTable")
            {
                lblFieldData2.Text = "Room Type:";
                lblFieldData3.Text = "Specialisation:";

                tbFieldInfo3.Hide();
                cbFieldInfo1.Show();
                cbFieldInfo1.Location = new Point(146, 157);

                lbMain.Text = "Add Room";
                btnAddRecord.Text = "Add New Room";
                btnReturn.Text = "Return to Room Table";

                Querystring = "INSERT INTO Room VALUES(@Room_Type, @Specialisation";
            }

            else if (GlobalVariables.PreviousForm == "GradeTable")
            {
                lblFieldData2.Text = "Grade Level:";
                lblFieldData3.Text = "GradeFee:";

                lbMain.Text = "Add Grade";
                btnAddRecord.Text = "Add New Grade";
                btnReturn.Text = "Return to Grade Table";

                Querystring = "INSERT INTO Grade VALUES(@GradeLevel, @GradeFee";
            }

            else if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {

            }

            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {

            }

            else if (GlobalVariables.PreviousForm == "PurchasedLessonBundleTable")
            {

            }

        }

        public void HideExcessInformation()
        {
            if (lblFieldData2.Text == "[PlaceHolder]")
            {
                HidePlaceholder2();
                HidePlaceholder3();
                HidePlaceholder4();
                HidePlaceholder5();
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData3.Text == "[PlaceHolder]")
            {
                HidePlaceholder3();
                HidePlaceholder4();
                HidePlaceholder5();
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData4.Text == "[PlaceHolder]")
            {
                HidePlaceholder4();
                HidePlaceholder5();
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData5.Text == "[PlaceHolder]")
            {
                HidePlaceholder5();
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData6.Text == "[PlaceHolder]")
            {
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData7.Text == "[PlaceHolder]")
            {
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData8.Text == "[PlaceHolder]")
            {
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData9.Text == "[PlaceHolder]")
            {
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData10.Text == "[PlaceHolder]")
            {
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData11.Text == "[PlaceHolder]")
            {
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData12.Text == "[PlaceHolder]")
            {
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData12.Text == "[PlaceHolder]")
            {
                HidePlaceholder13();
            }
        }


        public void HidePlaceholder2()
        {
            lblFieldData2.Hide();
            tbFieldInfo2.Hide();
        }
        public void HidePlaceholder3()
        {
            lblFieldData3.Hide();
            tbFieldInfo3.Hide();
        }
        public void HidePlaceholder4()
        {
            lblFieldData4.Hide();
            tbFieldInfo4.Hide();
        }
        public void HidePlaceholder5()
        {
            lblFieldData5.Hide();
            tbFieldInfo5.Hide();
        }
        public void HidePlaceholder6()
        {
            lblFieldData6.Hide();
            tbFieldInfo6.Hide();
        }
        public void HidePlaceholder7()
        {
            lblFieldData7.Hide();
            tbFieldInfo7.Hide();
        }
        public void HidePlaceholder8()
        {
            lblFieldData8.Hide();
            tbFieldInfo8.Hide();
        }
        public void HidePlaceholder9()
        {
            lblFieldData9.Hide();
            tbFieldInfo9.Hide();
        }
        public void HidePlaceholder10()
        {
            lblFieldData10.Hide();
            tbFieldInfo10.Hide();
        }
        public void HidePlaceholder11()
        {
            lblFieldData11.Hide();
            tbFieldInfo11.Hide();
        }
        public void HidePlaceholder12()
        {
            lblFieldData12.Hide();
            tbFieldInfo12.Hide();
        }
        public void HidePlaceholder13()
        {
            lblFieldData13.Hide();
            tbFieldInfo13.Hide();
        }




        private void btnCalender_Click(object sender, EventArgs e)
        {
            btnCalender.Hide();
            Calender1.Show();
            Calender1.Location = new Point(308, 209);
        }

        private void Calender1_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectedDate = Calender1.SelectionRange.Start.ToShortDateString();
            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                tbFieldInfo5.Text = SelectedDate;
            }
            btnCalender.Show();
            Calender1.Hide();
        }
    }
    }
