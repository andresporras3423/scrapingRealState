using scrapingRealState.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace scrapingRealState
{
    public static class DataRowExtensions
    {
        public static DataTable AsTable(this DataRow row)
        {
            if (row == null) throw new ArgumentNullException(nameof(row));
            if (row.Table == null) throw new InvalidOperationException("The DataRow does not belong to any DataTable.");

            // 1. Clone the schema of the source DataTable
            DataTable newTable = row.Table.Clone();

            // 2. Import the DataRow into the new table
            newTable.Rows.Add(row.ItemArray);

            return newTable;
        }
    }
}