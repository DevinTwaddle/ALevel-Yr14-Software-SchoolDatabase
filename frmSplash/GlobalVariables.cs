using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmSplash
{
    class GlobalVariables
    {
        // Calender Dates
        public static bool Date1;
        public static bool Date2;
        public static bool Date3;
        public static bool Date4;
        public static bool Date5;
        public static bool Date6;
        public static bool Date7;
        public static bool Date8;
        public static bool Date9;
        public static bool Date10;
        public static bool Date11;
        public static bool Date12;
        public static bool Date13;
        public static bool Date14;
        public static bool Date15;
        public static bool Date16;
        public static bool Date17;
        public static bool Date18;
        public static bool Date19;
        public static bool Date20;
        public static bool Date21;
        public static bool Date22;
        public static bool Date23;
        public static bool Date24;
        public static bool Date25;
        public static bool Date26;
        public static bool Date27;
        public static bool Date28;
        public static bool Date29;
        public static bool Date30;
        public static bool Date31;
        public static int SelectedDay;
        public static string DayName;

        // Calendar Months
        public static bool January;
        public static bool February;
        public static bool March;
        public static bool April;
        public static bool May;
        public static bool June;
        public static bool July;
        public static bool August;
        public static bool September;
        public static bool October;
        public static bool November;
        public static bool December;
        public static int SelectedMonthInt;
        public static string SelectedMonthString;

        public static bool CalendarReturn;

        // Time Varaibles
        public static string SelectedTime;
        public static string SelectedTimeTextFormat;

        // Selected Year
        public static int SelectedYear;

        // Selected Schedule Date
        public static string SelectedScheduleDate;

        // Student Table
        public static List<int> GlobalStudentID = new List<int>();

        // Add Field Pevious Form
        public static string PreviousForm;
        public static string Purpose;
        public static string UpdateID;

        // Student Record
        public static string Student_FirstName;
        public static string Student_OtherNames;
        public static string Student_Surname;
        public static string Student_DOB;
        public static string Student_Address;
        public static string Student_Town;
        public static string Student_PostCode;
        public static string Student_ContactNumber;
        public static string Student_Email;
        public static string Student_GradeID;
        public static string Student_InstrumentID;
        public static string Student_PaymentFee;

        // Teacher Record
        public static string Teacher_FirstName;
        public static string Teacher_Surname;
        public static string Teacher_Address;
        public static string Teacher_Town;
        public static string Teacher_PostCode;
        public static string Teacher_ContactNumber;
        public static string Teacher_Email;
        public static string Teacher_Specialisation;
        public static string Teacher_RoomID;

        // Instrument Record
        public static string Instrument_Type;
        public static string Instrument_Name;
        public static string Instrument_Quantity;

        // Room Record
        public static string Room_Type;
        public static string Room_Specialisation;

        // Grade Record
        public static string Grade_Level;
        public static string Grade_Fee;

        // LessonBundle Record
        public static string Bundle_Name;
        public static string Bundle_Cost;
        public static string Bundle_Discount;

        // Scheudled Lesson Record
        public static string Schedule_StudentID;
        public static string Schedule_TeacherID;
        public static string Schedule_PurchaseID;
        public static string Schedule_Weeks;
        public static string Schedule_StartDate;
        public static string Schedule_BookedDays;
        public static string Schedule_BookedTime;
        public static string Schedule_EndDate;

        // Purchased Lesson Record
        public static string Purchase_StudentID;
        public static string Purchase_BundleID;
        public static string Purchase_Date;
        public static string Purchase_Method;
        public static string Purchase_Recieved;
        public static string Purchase_ReceivedDate;
        public static string Purchase_BundleCosts;

        // Canender selected Varaibles
        public static int CalenderStudentID;
        public static int CalenderScheduledID;

        public static bool scheduleErrorMessage;

        // Admin Login
        public static string Username;
        public static bool UserLoggedIn;

        // Delete Details
        public static int TableID;
        public static string FieldNames;

        // Global Form Entities
        public static frmStudents StudentForm = new frmStudents();
        public static frmTeachers TeacherForm = new frmTeachers();
        public static frmInstrument InstrumentForm = new frmInstrument();
        public static frmLessonBundle LessonBundleForm = new frmLessonBundle();
        public static frmGrade GradeForm = new frmGrade();
        public static frmRoom RoomForm = new frmRoom();
        public static frmScheduleTable ScheduledLessonForm = new frmScheduleTable();
        public static PurchasedLessonBundles PurchasedLessonForm = new PurchasedLessonBundles();
        public static frmCalenderDates Calendar = new frmCalenderDates();
        public static frmAddField AddField = new frmAddField();

        // Invoice
        public static int Invoice_SelectedStudentID;
        public static string StudentName;
    }
}
