using SQLiteSample.Helpers;
using SQLiteSample.Models;
using System;
using System.Collections.Generic;

namespace SQLiteSample.Services
{
    public class ContactRepository : IContactRepository 
    {
        DatabaseHelper _databaseHelper;  
        public ContactRepository(){  
            _databaseHelper = new DatabaseHelper();  
        }
  
        public int DeleteContact(int contactID)  
        {  
            return _databaseHelper.DeleteContact(contactID);  
        }
  
        public void DeleteAllContacts()  
        {  
            _databaseHelper.DeleteAllContacts();  
        }
  
        public List<ContactInfo> GetAllContactsData()  
        {  
            return _databaseHelper.GetAllContactsData();  
        }
  
        public ContactInfo GetContactData(int contactID)  
        {  
            return _databaseHelper.GetContactData(contactID);  
        }
  
        public int InsertContact(ContactInfo contact)  
        {  
            return _databaseHelper.InsertContact(contact);  
        }
  
        public void UpdateContact(ContactInfo contact)  
        {  
            _databaseHelper.UpdateContact(contact);  
        }
    }
}
