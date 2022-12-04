using Microsoft.Maui;
using Microsoft.Maui.Controls;
using SQLiteSample.Services;
using SQLiteSample.Models;  
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SQLiteSample.Helpers
{
    public class DatabaseHelper
    {
        static SQLiteConnection sqliteconnection;
        public const string DbFileName = "Contacts.db";
        private GenerateConnection SqlLiteConnection { get; set; }

        public DatabaseHelper()
        {
            SqlLiteConnection = new GenerateConnection();
            sqliteconnection = SqlLiteConnection.Connection;

            sqliteconnection.CreateTable<ContactInfo>();
        }

        // Get All Contact data      
        public List<ContactInfo> GetAllContactsData()
        {
            return (from data in sqliteconnection.Table<ContactInfo>()
                    select data).ToList();
        }

        //Get Specific Contact data  
        public ContactInfo GetContactData(int id)
        {
            return sqliteconnection.Table<ContactInfo>().FirstOrDefault(t => t.Id == id);
        }

        // Delete all Contacts Data  
        public void DeleteAllContacts()
        {
            sqliteconnection.DeleteAll<ContactInfo>();
        }

        // Delete Specific Contact  
        public int DeleteContact(int id)
        {
            return sqliteconnection.Delete<ContactInfo>(id);
        }

        // Insert new Contact to DB   
        public int InsertContact(ContactInfo contact)
        {
            return sqliteconnection.Insert(contact);
        }

        // Update Contact Data  
        public void UpdateContact(ContactInfo contact)
        {
            sqliteconnection.Update(contact);
        }
    }
}