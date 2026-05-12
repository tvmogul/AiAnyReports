using AiAnyReports.ReportViewer.Data;
using AiAnyReports.ReportViewer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AiDotNetDemo.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ReportDataService _dataService;

        public ReportsController()
        {
            // Same self-contained setup your DLL uses
            ReportViewerPathManager pm = new ReportViewerPathManager();
            string dbPath = pm.GetSavedReportsDatabasePath();
            _dataService = new ReportDataService($"Data Source={dbPath}");

            string aaa = "";
        }

        [HttpGet]
        public async Task<IActionResult> Viewer(string groupName = "SQLiteDemo")
        {
            List<ReportListItem> reports = await _dataService.GetReportsAsync(groupName);

            ReportViewerModel model = new ReportViewerModel
            {
                GroupName = groupName,
                Reports = reports
            };

            ViewBag.DebugReportCount = reports.Count;
            ViewBag.DebugGroupName = groupName;

            return View("~/Views/Shared/ReportViewer.cshtml", model);
        }
    }
}