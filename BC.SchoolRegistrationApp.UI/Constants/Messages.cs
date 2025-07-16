using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.UI.Constants
{
    public static class Messages
    {
        // Genel
        public const string OperationSuccessful = "{0} {1}ed successfully.";
        public const string OperationFailed = "{0} couldn't be {1.ToLower()}ed. Error: {2}";
        public const string AreYouSureToDelete = "Are you sure you want to delete {0}?";
        public const string ConfirmDeleteTitle = "Confirm Delete";
        public const string UnexpectedError = "An unexpected error occurred: {0}";
        public const string InnerException = "Inner exception: {0}";

        // Formlar
        public const string FieldCannotBeEmpty = "Please fill in the {0} field.";
        public const string SelectItem = "Please select a {0}.";
        public const string NoItemFound = "No {0} found with the given criteria.";

        // Öğrenci
        public const string StudentNotFound = "No student found with number: {0}";
        public const string StudentNotSelected = "No student selected.";
        public const string EnterStudentNumber = "Please enter a student number.";
    }
}
