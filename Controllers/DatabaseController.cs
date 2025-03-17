using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Globalization;
using System.Runtime.InteropServices;

// using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.FileIO;


namespace CodingLogger.Coding.Controllers;

internal class DatabaseController {
    
    static string connectionString = @"Data Source=codeLogger.db";


    internal void createTable() {
        string cmd = 
        @"CREATE TABLE IF NOT EXISTS coding_session (
           Id INTEGER PRIMARY KEY AUTOINCREMENT,
           StartTime DATETIME,
           EndTime DATETIME)";

        executeCommands(cmd);
    }

    internal void executeCommands(string userCommand) {
        using (var connection = new SQLiteConnection(connectionString)) {
            connection.Open();
            var tableCmd = connection.CreateCommand();

            tableCmd.CommandText = userCommand;
            tableCmd.ExecuteNonQuery();
            connection.Close();
        }
        
    }

    internal void CreateMockData() {
        
    }

    private void ViewItems() {

    }

    private void AddItem() {

    }

    private void DeleteItem() {

    }

}