﻿using System;
using System.Collections.Generic;  
using SQLiteSample.Models;  

namespace SQLiteSample.Services
{
    public interface IContactRepository
    {
        List<ContactInfo> GetAllContactsData();  

        //Get Specific Contact data  
        ContactInfo GetContactData(int contactID);  

        // Delete all Contacts Data  
        void DeleteAllContacts();  

        // Delete Specific Contact  
        int DeleteContact(int contactID);  

        // Insert new Contact to DB   
        int InsertContact(ContactInfo contact);  

        // Update Contact Data  
        void UpdateContact(ContactInfo contact);
    }
}
