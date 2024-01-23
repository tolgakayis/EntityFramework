using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "Product added";
		public static string ProductNameInvalid = "Product name is invalid";
		public static string MaintenanceTime = "System is under maintenance";
		public static string ProductsListed = "Products are listed";
		public static string UnitPriceInvalid = "Unit Price invalid";
        public static string ProductCountOfCategoryError = "There must be only maximum 15 products in a category";
		public static string ProductNameExists = "Product name exists";
		public static string CategoryLimitError = "Too many categories (15 max). Can not add more products";
		public static string AuthorizationDenied = "You DO NOT have the authorization to access this feature";
		public static string UserRegistered = "User registered successfully";
        public static string UserAlreadyExists = "User already exists";
		public static string UserNotFound = "User not found";
        public static string AccessTokenCreated = "Access Token has been created";
        public static string SuccessfulLogin = "Successful login";
        public static string PasswordError = "Wrong password";
    }
}
