using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added.";
        public static string ProductNameInvalid = "Product name invalid.";
        public static string ProcessCompleted = "Process completed.";
        public static string MaintenanceTime = "Maintenance Time.";
        public static string ProductsListed = "Products listed.";
        public static string ProductCountOfCategoryError = "There must be 10 products in a category.";
        public static string ProductNameAlreadyExist = "Product name already exist.";
        public static string OutOfRangeError = "If the count of the categories more than 15, new products cannot be added.";
        public static string CategoryAdded = "Category added. ";
        public static string AuthorizationDenied = "Authorization denied.";
        public static string UserRegistered = "User registered.";
        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Password error.";
        public static string SuccessfulLogin = "Successful login.";
        public static string UserAlreadyExists = "User already exists.";
        public static string AccessTokenCreated = "Access token created.";
    }
}
