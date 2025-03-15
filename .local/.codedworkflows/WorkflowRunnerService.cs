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
        public void ExtractCurrentRealState(string in_currentUrl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractCurrentRealState.xaml", new Dictionary<string, object>{{"in_currentUrl", in_currentUrl}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExtractCurrentRealState.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ExtractCurrentRealState(string in_currentUrl, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractCurrentRealState.xaml", new Dictionary<string, object>{{"in_currentUrl", in_currentUrl}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the fincaRaizAdditionalDetails.xaml
        /// </summary>
        public System.Data.DataRow fincaRaizAdditionalDetails(string in_link, UiPath.Database.DatabaseConnection db_conn, System.Data.DataRow io_dr_inmuebleDetalles)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaizAdditionalDetails.xaml", new Dictionary<string, object>{{"in_link", in_link}, {"db_conn", db_conn}, {"io_dr_inmuebleDetalles", io_dr_inmuebleDetalles}}, default, default, default, GetAssemblyName());
            return (System.Data.DataRow)result["io_dr_inmuebleDetalles"];
        }

        /// <summary>
        /// Invokes the fincaRaizAdditionalDetails.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataRow fincaRaizAdditionalDetails(string in_link, UiPath.Database.DatabaseConnection db_conn, System.Data.DataRow io_dr_inmuebleDetalles, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaizAdditionalDetails.xaml", new Dictionary<string, object>{{"in_link", in_link}, {"db_conn", db_conn}, {"io_dr_inmuebleDetalles", io_dr_inmuebleDetalles}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataRow)result["io_dr_inmuebleDetalles"];
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExtractForEachRealState.xaml
        /// </summary>
        public void ExtractForEachRealState(System.Data.DataTable ExtractDataTable)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractForEachRealState.xaml", new Dictionary<string, object>{{"ExtractDataTable", ExtractDataTable}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExtractForEachRealState.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ExtractForEachRealState(System.Data.DataTable ExtractDataTable, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractForEachRealState.xaml", new Dictionary<string, object>{{"ExtractDataTable", ExtractDataTable}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the listFiscaRaizAdditionalDetails.xaml
        /// </summary>
        public void listFiscaRaizAdditionalDetails()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"listFiscaRaizAdditionalDetails.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the listFiscaRaizAdditionalDetails.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void listFiscaRaizAdditionalDetails(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"listFiscaRaizAdditionalDetails.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the fincaRaiz.xaml
        /// </summary>
        public void fincaRaiz()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaiz.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the fincaRaiz.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void fincaRaiz(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaiz.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the test.xaml
        /// </summary>
        public void test()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"test.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the test.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void test(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"test.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the fincaRaiz - Copy (1).xaml
        /// </summary>
        public void fincaRaiz___Copy__1_()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaiz - Copy (1).xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the fincaRaiz - Copy (1).xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void fincaRaiz___Copy__1_(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"fincaRaiz - Copy (1).xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}