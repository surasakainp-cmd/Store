using Store;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Store
{
    // Simple POCO model for customer (kept in this file per request)
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string CustomerType { get; set; } = string.Empty;
        public int Status { get; set; } // 1 = active, 0 = inactive
    }

    // SQLite helper and CRUD methods (all in this file)
    public static class SqliteDb
    {
        private const string DbFile = "customer.db";
        private static string ConnectionString => $"Data Source={DbFile}";
    }
}