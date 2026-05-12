using AiAnyReports.ReportViewer.Data;
using AiAnyReports.ReportViewer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AiDotNetDemo.Controllers
{
    public class DemoController : Controller
    {
        private readonly ReportDataService _dataService;

        public DemoController()
        {
            ReportViewerPathManager pm = new ReportViewerPathManager();
            string dbPath = pm.GetSavedReportsDatabasePath();
            _dataService = new ReportDataService($"Data Source={dbPath}");
        }

        [HttpGet]
        public async Task<IActionResult> Index(string groupName = "SQLiteDemo")
        {
            List<ReportListItem> reports = await _dataService.GetReportsAsync(groupName) ?? new List<ReportListItem>();

            ReportViewerModel model = new ReportViewerModel
            {
                GroupName = groupName ?? "",
                Reports = reports
            };

            return View(model);
        }
    }
}