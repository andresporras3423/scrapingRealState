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
    public class BusinessLogic
    {
        public void Execute()
        {
            // Create a new DataTable named dt_inmuebles
            DataTable dt_inmuebles = new DataTable("dt_inmuebles");

            // Add columns to the DataTable
            dt_inmuebles.Columns.Add("precio", typeof(decimal));
            dt_inmuebles.Columns.Add("codigoInmueble", typeof(string));
            dt_inmuebles.Columns.Add("banyos", typeof(int));
            dt_inmuebles.Columns.Add("habitaciones", typeof(int));
            dt_inmuebles.Columns.Add("areaPrivada", typeof(double));
            dt_inmuebles.Columns.Add("areaConstruida", typeof(double));
            dt_inmuebles.Columns.Add("estrato", typeof(int));
        }

    }
}