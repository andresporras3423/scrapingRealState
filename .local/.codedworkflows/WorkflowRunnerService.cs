using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using scrapingRealState;

[assembly: WorkflowRunnerServiceAttribute(typeof(scrapingRealState.WorkflowRunnerService))]
namespace scrapingRealState
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the ExtractCurrentRealState.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ExtractCurrentRealState(string in_currentUrl, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractCurrentRealState.xaml", new Dictionary<string, object> { { "in_currentUrl", in_currentUrl } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExtractForEachRealState.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ExtractForEachRealState(System.Data.DataTable ExtractDataTable, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractForEachRealState.xaml", new Dictionary<string, object> { { "ExtractDataTable", ExtractDataTable } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the fincaRaiz.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void fincaRaiz(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaiz.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the fincaRaiz - Copy (1).xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void fincaRaiz___Copy__1_(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaiz - Copy (1).xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the fincaRaizAdditionalDetails.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataRow fincaRaizAdditionalDetails(string in_link, UiPath.Database.DatabaseConnection db_conn, System.Data.DataRow io_dr_inmuebleDetalles, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaizAdditionalDetails.xaml", new Dictionary<string, object> { { "in_link", in_link }, { "db_conn", db_conn }, { "io_dr_inmuebleDetalles", io_dr_inmuebleDetalles } }, default, isolated, default, GetAssemblyName());
            return (System.Data.DataRow)result["io_dr_inmuebleDetalles"];
        }

        /// <summary>
        /// Invokes the rentaLocales/fincaRaizLocalesAdditionalDetails.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataRow fincaRaizLocalesAdditionalDetails(string in_link, UiPath.Database.DatabaseConnection db_conn, System.Data.DataRow io_dr_localDetalles, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"rentaLocales\fincaRaizLocalesAdditionalDetails.xaml", new Dictionary<string, object> { { "in_link", in_link }, { "db_conn", db_conn }, { "io_dr_localDetalles", io_dr_localDetalles } }, default, isolated, default, GetAssemblyName());
            return (System.Data.DataRow)result["io_dr_localDetalles"];
        }

        /// <summary>
        /// Invokes the rentaLocales/fincaRaizRentaLocales.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void fincaRaizRentaLocales(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"rentaLocales\fincaRaizRentaLocales.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the rentaLocales/listFincaRaizlocalesAdditionalDetails.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void listFincaRaizlocalesAdditionalDetails(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"rentaLocales\listFincaRaizlocalesAdditionalDetails.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the listFiscaRaizAdditionalDetails.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void listFiscaRaizAdditionalDetails(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"listFiscaRaizAdditionalDetails.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the rentaLocales/StartRentaLocales.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void StartRentaLocales(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"rentaLocales\StartRentaLocales.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}