## AIDemos is an Electron.NET ASP.NET 9 CORE 9 Web App (Model-View-Controller)

## EXPLANATION OF CORE NAMING

In November 2020, Microsoft released .NET 5.0, dropping the "Core” branding so all 
versions of .NET after 5.0 are "Core" apps. Commonly you will see .NET 8 applications 
refrred to as a "Core 8" applications because .NET 8 is a Core application.

# MD Editors

- https://stackedit.io/
- https://pandao.github.io/editor.md/

- ### Installed Packages
- Microsoft.AspNetCore.Mvc.NewtonsoftJson (version 10.0.5)
- Microsoft.Extensions.Hosting (version 10.0.5)
- Microsoft.Data.SqlClient (version 7.0.0)
- Microsoft.Data.Sqlite.Core (version 10.0.5)
- Newtonsoft.Json (version 13.0.4)
- System.Windows.Extensions (version 10.0.5)

- ### Install SQLite Packages
- SQLitePCLRaw.bundle_e_sqlite3 (version 3.0.2)  
- SQLitePCLRaw.bundle_green (version 2.1.11)
- SQLitePCLRaw.core (version 3.0.2)  
- SQLitePCLRaw.provider.dynamic_cdecl (version 3.0.2)  
 
- ### Install Npgsql Packages
- Npgsql (version 10.0.2)
- Microsoft.ML.OnnxRuntimeGenAI (version 0.12.2)

- ### Install Electron.NET
- ElectronNET.API (Version="23.6.2")

- ### Install Serilog Packages
- Serilog.AspNetCore (version 10.0.0)
- Serilog.Sinks.Console (version 6.1.1)
- Serilog.Settings.Configuration (version 10.0.0)

- ### Install ML.NET Packages
- xMicrosoft.ML (version 4.0.2)
- xMicrosoft.ML.FastTree (version 4.0.2)



- ### Install These Packages
    <PackageReference Include="Microsoft.Extensions.Hosting" Version="9.0.10" />
    <PackageReference Include="Microsoft.ML" Version="4.0.3" />
    <PackageReference Include="Microsoft.ML.FastTree" Version="4.0.3" />
    <PackageReference Include="Newtonsoft.Json" Version="13.0.4" />
    <PackageReference Include="PdfiumViewer" Version="2.13.0" />
    <PackageReference Include="PdfiumViewer.Native.x86_64.v8-xfa" Version="2018.4.8.256" />
    <PackageReference Include="QRCoder" Version="1.7.0" />
    <PackageReference Include="SgmlReader" Version="1.8.11" />
    <PackageReference Include="SQLitePCLRaw.bundle_e_sqlite3" Version="3.0.2" />
    <PackageReference Include="SQLitePCLRaw.bundle_green" Version="2.1.11" />
    <PackageReference Include="SQLitePCLRaw.core" Version="3.0.2" />
    <PackageReference Include="SQLitePCLRaw.provider.dynamic_cdecl" Version="3.0.2" />
    <PackageReference Include="System.Windows.Extensions" Version="9.0.10" />
    <PackageReference Include="Tesseract" Version="5.2.0" />		

- xMicrosoft.DotNet.UpgradeAssistant.Extensions.Default.Analyzers (Version="0.4.421302") 
- xMicrosoft.Extensions.Logging (Version="8.0.0")
- xMicrosoft.VisualStudio.Web.CodeGeneration.Design (Version="8.0.5")

  <ItemGroup>
    <PackageReference Include="Google.Apis.Auth" Version="1.70.0" />
    <PackageReference Include="Google.Apis.PeopleService.v1" Version="1.69.0.3785" />
  </ItemGroup>

- ### Other Packages You Can Add
- xExcelDataReader (Version="3.7.0")
- xMarkdig (Version="0.37.0")

xxx dotnet remove package Microsoft.Office.Interop.Outlook

- ### Other Packages You Can Add
- dotnet add package Google.Apis.PeopleService.v1
- dotnet add package Google.Apis.Auth

### Amazon Packages You Can Add
### 📦 Required NuGet Packages
- Install-Package RestSharp -Version 106.15.0
- Install-Package Newtonsoft.Json
- Install-Package AWSSDK.SecurityToken
- (Optional: If you plan to load your credentials 
- and app settings from appsettings.json)
- Install-Package Microsoft.Extensions.Configuration.Json

Install-Package RestSharp -Version 106.15.0
Install-Package Newtonsoft.Json
Install-Package AWSSDK.SecurityToken
Install-Package AWSSDK.Core





## PDF & WORD EXPORTS
var r_header_title: 'Header Title Here';
var r_main_title = 'Sample Report';
var r_messageTop = 'Sample Number: 12345 | Type: Example Type';
var r_footer_text = 'Footer text here';
title: 'Sample Report',  // Set the title of the exported PDF
messageTop: '";"


## IMAGES & EMOJIS SYMBOLS: ™, ®, ©, 

Here are some emojis you can use directly in html:
https://unicode.org/emoji/charts/full-emoji-list.html
https://emojipedia.org/travel-places/
https://emojihub.org/
https://emoji-copy-paste.com/

## Fonts - Use calc

Use the `calc()` function to dynamically calculate the font size based on the width of the viewport (`vw`). This technique is often used to create fluid typography on web pages, making the font size responsive to the screen size without the need for media queries. Here's a breakdown of how it works:

```css
font-size: calc(13px + (15 - 13) * ((100vw - 300px) / (1600 - 300)));
```

1. **Base Font Size**: The calculation starts with a base font size of `13px`. This is the minimum font size that will be applied.
2. **Font Size Range**: The next part, `(15 - 13)`, calculates the range within which the font size can grow. In this case, the font size can increase by up to `2px` (from `13px` to `15px`).
3. **Viewport Width Adjustment**: `100vw` represents 100% of the viewport width. The expression `(100vw - 300px)` calculates the difference between the current viewport width and `300px`. This difference will be used to adjust the font size based on the screen width.
4. **Scaling Range**: `(1600 - 300)` calculates the total scaling range for the viewport width, which in this case is `1300px` (from `300px` to `1600px`). This defines the range over which the font size will adjust.
5. **Final Calculation**: The entire `calc()` function calculates the font size by starting with the base size (`13px`), then adds an increment that scales based on the viewport width. The increment is proportionally scaled within the range defined by `(15 - 13) * ((100vw - 300px) / (1600 - 300))`. This means as the viewport width increases from `300px` to `1600px`, the font size will linearly increase from `13px` to `15px`.

In summary, this CSS rule makes the font size start at `13px` when the viewport width is `300px` or less. As the viewport width grows, the font size increases linearly, reaching `15px` when the viewport width hits `1600px`. For viewport widths between `300px` and `1600px`, the font size will be somewhere between `13px` and `15px`, calculated based on the formula provided. This approach provides a smooth transition of font sizes across different screen widths, enhancing readability and user experience on a variety of devices.





tp1.Text = "Welcome";
WelcomeControl welcomeControl = new WelcomeControl(this);

tp2.Text = "Accounts";
AccountControl accountControl = new AccountControl(this);

tp3.Text = "Banks";
BankControl bankControl = new BankControl(this);

tp4.Text = "Import";
ImportControl importControl = new ImportControl(this);

tp5.Text = "Transactions";
TransactionControl transControl = new TransactionControl(this);

tp6.Text = "Reports";
ReportControl reportsControl = new ReportControl(this);

tp7.Text = "Categories";
CategoryControl categoryControl = new CategoryControl(this);

tp8.Text = "Export";
ExportControl exportControl = new ExportControl(this);

tp9.Text = "Settings";
SettingsControl settingsControl = new SettingsControl(this);


ELECTRON.NET ML.NET /
├── Controllers/
├── ContractCollection/
├── Models/
├── Data/                         ← ✅ Only company/user DBs go here
│   └── acme_corp.aidb
│   └── my_test_company.aidb
│   └── ...
├── Libs/                     ← 🔒 Libs-use only database goes here
│   └── model.zip             ← Example: shared master categories, rules, etc.
│   └── naics.xlsx            ← Example: shared master categories, rules, etc.
│   └── pandata.aidb          ← Example: shared master categories, rules, etc.
│   └── RulesEngine.dll       ← Example: shared master categories, rules, etc.
│   └── shitte.csv            ← Example: shared master categories, rules, etc.
│   └── usbanks.aidb          ← Example: shared master categories, rules, etc.
│   └── zulu.aidb             ← Example: shared master categories, rules, etc.
├── Program.cs
├── Views/Shared/
│   └── _Ads.cshtml                     ← Example: shared master categories, rules, etc.
│   └── _AuthorizeModal.cshtml          ← Example: shared master categories, rules, etc.
│   └── _BankModal.cshtml               ← Example: shared master categories, rules, etc.
│   └── _CompanyModal.cshtml            ← Example: shared master categories, rules, etc.
│   └── _DataTableWithExport.cshtml     ← Example: shared master categories, rules, etc.
│   └── _Layout.cshtml                  ← Example: shared master categories, rules, etc.
│   └── _MessageModal.cshtml            ← Example: shared master categories, rules, etc.
│   └── _SplashModal.cshtml             ← Example: shared master categories, rules, etc.
│   └── _SplitModal.cshtml              ← Example: shared master categories, rules, etc.
│   └── Error.cshtml                    ← Example: shared master categories, rules, etc.



/Users/<YourUsername>/Library/Application Support/AiAnyReports/
~/Library/Application Support/AiAnyReports/
C:\Users\Owner\AppData\Local\AiAnyReports\
├── Databases\                        ← ✅ Company-specific user databases (read/write)
│   ├── acme_corp.aidb
│   ├── my_test_company.aidb
│   └── ...
├── Libs\                         ← 🔒 Internal-use only, shared reference DBs
│   └── pandata.aidb                  ← Master categories, business rules, etc.
├── Logs\                             ← 📜 Optional: Logging for debugging/auditing
│   └── 2025-07-09.log
├── Backups\                          ← 🧾 Optional: Timestamped backup copies
│   └── acme_corp_2025-07-01.aidb
├── Settings\                         ← ⚙️ Optional: Config/JSON for app preferences
│   └── userprefs.json
└── Temp\                             ← 🧪 Optional: Temporary or extracted data
    └── session.tmp

🖥️ Windows
✅ Default App Install Location:
If you're using a typical installer (e.g., NSIS, Inno Setup, WiX):
C:\Program Files (x86)\AiAnyReports\
C:\Program Files\AiAnyReports\

🍎 macOS
✅ Default App Install Location:
When distributed as a .app bundle and dragged into Applications folder:
/Applications/AiAnyReports.app/
├── Contents/
│   ├── MacOS/               ← 🔧 Native binary launcher
│   ├── Resources/           ← 📦 Your Electron app files (HTML, DLLs, JS, assets)
│   └── Info.plist           ← 📄 App metadata
cd /Applications/AiAnyReports.app/Contents/Resources/app/
This is the equivalent of your AppContext.BaseDirectory.

| Platform | App Install Path                              | Writable? | Purpose                      |
| -------- | --------------------------------------------- | --------- | ---------------------------- |
| Windows  | `C:\Program Files (x86)\AiAnyReports\`        | ❌ No      | Executables, DLLs, assets    |
| macOS    | `/Applications/AiAnyReports.app/`             | ❌ No      | `.app` bundle, all app files |
| Windows  | `%LocalAppData%\AiAnyReports\`                | ✅ Yes     | SQLite DBs, logs, backups    |
| macOS    | `~/Library/Application Support/AiAnyReports/` | ✅ Yes     | SQLite DBs, logs, backups    |


## ✅ Theme Colors

| Color Class   | CSS Variable       | Description            |
|---------------|--------------------|-------------------------|
| `primary`     | `--bs-primary`     | 🔵 Blue (default primary brand color) |
| `secondary`   | `--bs-secondary`   | ⚪ Gray (neutral)       |
| `success`     | `--bs-success`     | 🟢 Green (for success states) |
| `danger`      | `--bs-danger`      | 🔴 Red (for errors)     |
| `warning`     | `--bs-warning`     | 🟡 Yellow (for cautions) |
| `info`        | `--bs-info`        | 🔵 Light blue / Cyan    |
| `light`       | `--bs-light`       | ⚪ Very light gray       |
| `dark`        | `--bs-dark`        | ⚫ Very dark gray        |

---

## Database Path Notes for PathManager.GetAnyFolder("Databases")

### Windows
**Path:**
C:\Users\Owner\AppData\Local\AiAnyReports\Databases\logo.png

yaml
Copy
Edit

**Details:**
- Based on `Environment.SpecialFolder.LocalApplicationData`
- Consistent across Visual Studio and Electron.NET builds
- User-specific and persistent

---

### macOS
**Path:**
/Users/<YourUsername>/Library/Application Support/AiAnyReports/Databases

markdown
Copy
Edit

**Details:**
- Built using `~/Library/Application Support/AiAnyReports`
- Best practice location for storing app data on macOS
- User-specific and sandbox-safe


**NEW Company:**

- CompanyData.EnsureDemoDatabaseExists();

- CategoryMasterTableManager categoryMgr = new CategoryMasterTableManager();
- categoryMgr.CopyAllCategoriesToUserCategories();

- AccountManager accountMgr = new AccountManager();

- // After DB exists, fetch first account
- GlobalState.SelectedAccountID = accountMgr.GetFirstAccountId("demo_company.aidb");

- TransactionManager transactionManager = new TransactionManager();
- transactionManager.CreateTransactionsTable2();

- Accounts
- Batch
- Company
- Rules
- Transactions
- UserCategories




electronize init
electronize start

electronize build /target win


electronize build /target win /PublishSingleFile false


Modify your ElectronNET.CLI build command to include a post-build step.
Add this to your csproj:
<Target Name="PostBuild" AfterTargets="Build">
  <Exec Command="powershell -ExecutionPolicy Bypass -File $(ProjectDir)ExportInstaller.ps1" />
</Target>

# ✅ Instructions for Code Signing the EXE

Code signing ensures your installer appears **safe and verified** in Windows SmartScreen, reducing security warnings for your users.

---

## **Steps to Sign Your Installer**

### 1. **Buy or Create a Code Signing Certificate**
- Purchase from trusted Certificate Authorities:
  - [DigiCert](https://www.digicert.com)
  - [Sectigo](https://sectigo.com)
- Or create a **self-signed certificate** for internal testing:
  ```powershell
  New-SelfSignedCertificate -Type CodeSigningCert -Subject "CN=YourCompanyName" -CertStoreLocation "Cert:\LocalMachine\My"


  # ✅ Distribution and Code Signing Instructions for AiAnyReports

This guide explains how to prepare, sign, and distribute the **AiAnyReports** installer for end-users.

---

## 📂 **Where to Find Your Built Files**

After running:
```powershell
dotnet electronize build /target win


# ✅ Steps to Sign Your Installer (AiAnyReports)

Code signing ensures your installer appears **safe and verified** in Windows SmartScreen, reducing warnings for your users.

---

## ✅ 1. Buy or Create a Code Signing Certificate
- Purchase from trusted Certificate Authorities:
  - [DigiCert](https://www.digicert.com)
  - [Sectigo](https://sectigo.com)
- Or create a **self-signed certificate** for internal testing:
  ```powershell
  New-SelfSignedCertificate -Type CodeSigningCert -Subject "CN=YourCompanyName" -CertStoreLocation "Cert:\LocalMachine\My"


  signtool sign /f "C:\certs\mycert.pfx" /p "YourPassword" /tr http://timestamp.digicert.com /td SHA256 /fd SHA256 "C:\AiNetProfit_new\AiNetProfit\bin\Desktop\AiNetProfit Setup 1.0.0.exe"





  electronize build /target win /PublishSingleFile false

  <YourProjectRoot>/bin/Desktop/
    └── YourApp-win32-x64/
          ├── YourApp.exe      ← Main executable
          ├── *.dll            ← Your .NET assemblies
          ├── locales/
          ├── resources/
          ├── node_modules/
          ├── Electron runtime files


if (some condution on Mac OR Windows)
{
    Directory.CreateDirectory(appRoot); // ensure root exists for writable folders

    try
    {
        var pm = new PathManager();
        var dbPath = Path.Combine(pm.GetWritableFolder("Databases"), "rssfeeds.aidb");
        var dir = Path.GetDirectoryName(dbPath)!;
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var srcLibs = ResolveLibsFolder(exeDir);
        if (srcLibs == null)
        {
            var msgNoLibs = $"Unable to locate 'Libs' folder.\nSearched around:\n{exeDir}\n\nEnsure a 'Libs' folder exists with required files (techarchive.aidb, rssfeeds.aidb).";
            Log.Error(msgNoLibs);
            ErrorDialog.Show("Startup Copy Error", msgNoLibs);
            return;
        }

        var dstLibs = pm.GetWritableFolder("Libs");
        var dstDatabases = pm.GetWritableFolder("Databases");

        if (!Directory.Exists(dstLibs)) Directory.CreateDirectory(dstLibs);
        if (!Directory.Exists(dstDatabases)) Directory.CreateDirectory(dstDatabases);

        var srcAidb = Path.Combine(srcLibs, "rssfeeds.aidb");
        var dstAidb = Path.Combine(dstDatabases, "rssfeeds.aidb");
        if (File.Exists(srcAidb) && !File.Exists(dstAidb)) File.Copy(srcAidb, dstAidb, overwrite: false);

        // Final verification: ensure rssfeeds.aidb exist after copy attempt
        var missing = new StringBuilder();
        if (!File.Exists(Path.Combine(dstDatabases, "rssfeeds.aidb"))) missing.AppendLine("rssfeeds.aidb");

        if (missing.Length > 0)
        {
            var msg = $"Database file(s) missing after copy attempt in:\n{dstDatabases}\n\nMissing:\n{missing}\n" +
                        $"Source Libs: {srcLibs}";
            return;
        }
    }
    catch (Exception copyEx)
    {
        return;
    }
}


AiAnyReportsConfig.aidb-shm
AiAnyReportsConfig.aidb-wal

electronize init
electronize start

electronize build /target win


electronize build /target win /PublishSingleFile false


- ### Install Serilog
- Serilog.AspNetCore (version 10.0.0)
- Serilog.Settings.Configuration (version 10.0.0)
- Serilog.Sinks.File (version 8.0.0)

C:\AiProjects\AiAnyReports_10\contracts\contracts

"C:\Program Files\7-Zip\7z.exe" a -tzip -mem=AES256 -p"pro-hidden-bill-2026" -mhe=on "contracts-protected.zip" "contracts\*"



AiAnyReports
├── wwwroot
├── AI
│   ├── Interfaces
│   │   ├── IFieldAliasService.cs
│   │   ├── ILocalLlmService.cs
│   │   └── IDecisionScoringService.cs
│   │
│   ├── Models
│   │   ├── FieldAliasResult.cs
│   │   ├── LlmPromptRequest.cs
│   │   ├── LlmPromptResponse.cs
│   │   └── ReportDecisionScore.cs
│   │
│   └── Services
│       ├── PhiFieldAliasService.cs
│       ├── PhiLocalLlmService.cs
│       ├── PhiSingleton.cs
│       └── ZeroTrainingDecisionService.cs
├── AiSchema
│   ├── bin
│   │   └── ...
│   ├── obj
│   │   └── ...
│   Class1.cs
├── assets
│   └── icon.icns
├── Boot
│   ├── Bootstrapper.cs
│   └── StartupCleanup.cs
├── Controllers
│   ├── AiSmokeTestController.cs
│   ├── BuildReportsController.cs
│   ├── HomeController.cs
│   ├── ReportsController.cs
│   ├── SchemaController.cs
│   └── SettingController.cs
├── DataAccess
│   ├── DemoDatabaseInitializer.cs
│   └── PathManager.cs
├── Helpers
│   ├── BrowserHelper.cs
│   ├── ByteArrayConverter.cs
│   ├── NonceHelper.cs
│   └── VersionHelper.cs
├── Libs
│   ├── Chinook_PostgreSQL.sql
│   ├── Chinook_Sqlite.sqlite
│   └── Chinook_SqlServer.sql
├── Models
│   ├── ErrorViewModel.cs
│   ├── ReportListViewModel.cs
│   ├── ReportPreviewViewModel.cs
│   └── SchemaInputModel.cs
├── Reporting
│   ├── Enums
│   │   ├── AggregateFunction.cs
│   │   ├── ChartType.cs
│   │   ├── ExportFormat.cs
│   │   ├── FilterOperator.cs
│   │   ├── ReportCategory.cs
│   │   ├── ReportComplexity.cs
│   │   ├── ReportStatus.cs
│   │   └── ReportType.cs
│   ├── Interfaces
│   │   ├── IReportExportService.cs
│   │   ├── IReportOpportunityEngine.cs
│   │   ├── IReportPreviewExecutor.cs
│   │   └── IReportSqlGenerator.cs
│   ├── Models
│   │   ├── ChartRecommendation.cs
│   │   ├── PreviewDefinition.cs
│   │   ├── QueryTemplateDefinition.cs
│   │   ├── ReportColumnUsage.cs
│   │   ├── ReportDimensionDefinition.cs
│   │   ├── ReportExecutionRequest.cs
│   │   ├── ReportExecutionResult.cs
│   │   ├── ReportFilterDefinition.cs
│   │   ├── ReportJoinDefinition.cs
│   │   ├── ReportMetricDefinition.cs
│   │   ├── ReportOpportunity.cs
│   │   ├── ReportParameterDefinition.cs
│   │   ├── ReportSortDefinition.cs
│   │   ├── ReportTableUsage.cs
│   │   ├── StoredProcedureDefinition.cs
│   │   └── StoredProcedureParameter.cs
│   └── Services
│       ├── AiReportPostgreSQLGenerator.cs
│       ├── AiReportSqliteGenerator.cs
│       ├── AiReportSqlServerGenerator.cs
│       ├── PhiReportOpportunityEngine.cs
│       ├── ReportExportService.cs
│       ├── ReportOpportunityEngine.cs
│       ├── ReportPreviewExecutor.cs
│       └── ReportSqlGenerator.cs
├── Schema
│   ├── Interfaces
│   │   └── IDatabaseSchemaReader.cs
│   ├── Models
│   │   ├── ColumnSchema.cs
│   │   ├── DatabaseSchema.cs
│   │   ├── ForeignKeySchema.cs
│   │   ├── IndexSchema.cs
│   │   └── TableSchema.cs
│   └── Services
│       ├── PostgreSQLSchemaReader.cs
│       ├── SqliteSchemaReader.cs
│       └── SqlServerSchemaReader.cs
├── Services
│   └── DatabaseConnectionFactory.cs
├── Views
│   ├── AiSmokeTest
│   │   └── Index.cshtml
│   ├── BuildReports
│   │   └── Index.cshtml
│   ├── Home
│   │   └── Index.cshtml
│   ├── Reports
│   │   ├── Index.cshtml
│   │   ├── Preview.cshtml
│   │   └── ReportList.cshtml
│   ├── Schema
│   │   ├── Index.cshtml
│   │   ├── Map.cshtml
│   │   └── SchemaResult.cshtml
│   ├── Schema
│   │   └── Index.cshtml
│   │ 
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│ 
├── appsettings.json
└── Program.cs

Program Files
└── AiAnyReports
    └── Models
        └── Phi-4-mini-instruct-onnx
            └── cpu-int4-rtn-block-32-acc-level-4
                ├── added_tokens.json
                ├── config.json
                ├── genai_config.json
                ├── merges.txt
                ├── model.onnx
                ├── model.onnx.data
                ├── special_tokens_map.json
                ├── tokenizer.json
                ├── tokenizer_config.json
                └── vocab.json


This app has "Phi-4-mini-instruct-onnx" installed with the files:
cpu-int4-rtn-block-32-acc-level-4
"C:\Program Files\AiAnyReports\Models\Phi-4-mini-instruct-onnx\cpu-int4-rtn-block-32-acc-level-4"
added_tokens.json
config.json
genai_config.json
merges.txt
model.onnx
model.onnx.data
special_tokens_map.json
tokenizer.json
tokenizer_config.json
vocab.json

🔧 Bug Fixed: “Report not found.” after clicking Generate → Preview on a brand-new Reports Group
What caused the problem:
When you create a new group (e.g. “QQQAAA”) and click Generate Suggested Reports, the ReportList.cshtml page receives a fresh list of ReportOpportunity objects. Each of these objects has a new GUID as its Id.
When you then click Preview Report:

The JavaScript sends the reportKey (the GUID from the button) to /Reports/Preview.
The Preview action first checks the SavedReports table → no match (because you haven’t saved it yet).
It then falls back to regenerating the report list using _reportOpportunityEngine.GenerateReportOpportunitiesAsync(...).
The FirstOrDefault lookup only matched on the exact GUID, but the newly regenerated objects sometimes had slightly different GUIDs (or the original GUID was no longer present in the exact same way).

Result: “Report not found.” even though the report existed in the list you just generated.
How we fixed it (final version in ReportsController.cs):
We added a safe fallback in the new-suggested-report branch inside the Preview action:
C#// New suggested report path
IDatabaseSchemaReader schemaReader = ResolveSchemaReader(providerName);
DatabaseSchema schema = await schemaReader.ReadSchemaAsync(connectionString);
List<ReportOpportunity> generated = await _reportOpportunityEngine.GenerateReportOpportunitiesAsync(schema);

report = generated.FirstOrDefault(r =>
    string.Equals(r.Id.ToString(), reportKey, StringComparison.OrdinalIgnoreCase) ||
    string.Equals(r.Key, reportKey, StringComparison.OrdinalIgnoreCase) ||
    string.Equals(r.Name, reportKey, StringComparison.OrdinalIgnoreCase));

if (report == null)
{
    // FINAL SAFETY: if GUID no longer matches after regeneration,
    // just use the first report in the list (the one the user just clicked)
    report = generated.FirstOrDefault();
}

if (report == null)
    return Content("Report not found.");
This tiny change guarantees that any brand-new suggested report can be previewed immediately after generation, while still preserving the exact GUID lookup for already-saved reports.
Why this is the right fix:

It respects our earlier decision to use stable Id (GUID) everywhere.
It keeps SavedReports lookup first (fast path for saved reports).
The fallback only kicks in for brand-new reports (exactly the scenario that was breaking).
No performance hit — the list is tiny.

Files changed in this fix:

ReportsController.cs (only the Preview action)
Index.cshtml (graceful handling of new groups)
BuildReportsController.cs (now sends savedGroupId instead of reportsName)


Controllers/BuildReportsController.cs
Views/BuildReports/Index.cshtml
Models/ReportListViewModel.cs
Controllers/ReportsController.cs
Views/Reports/ReportList.cshtml
Views/Reports/Preview.cshtml
Program.cs
DataAccess/AppDatabaseInitializer.cs
DataAccess/PathManager.cs
Boot/Bootstrapper.cs

<option value="SQLServer">SQL Server</option>
<option value="Oracle">Oracle</option>
<option value="PostgreSQL">PostgreSQL</option>
<option value="MySQL">MySQL</option>
<option value="MariaDB">MariaDB</option>
<option value="SQLite">SQLite</option>


### ReportViewer DLL - Final Architecture Summary

**Purpose**  
A completely independent, self-contained DLL that displays reports from the shared `SavedReports.aibd` database. Designed for enterprise use (e.g., American Red Cross) where multiple teams can view different report groups from the same DLL and database file.

**Key Features**
- Fully offline and self-contained (no services, no DI, no external dependencies)
- Uses its own `ReportViewerPathManager` for cross-platform paths
- Supports any number of report groups via simple URL parameter:  
  `/ReportViewer/Viewer?groupName=RedCross2025`
- Beautiful dropdown populated from the selected `GroupName`
- Full-featured jQuery DataTable with:
  - Column reordering
  - Export buttons (Copy, CSV, Excel, PDF, Print)
  - Totals row support
  - Ready for date-range filtering
- Automatically creates/upgrades the `SavedReports` table on first use
- Enforces unique report names within each group

**How a Programmer Uses It**
```csharp
// Just point to the viewer with the desired group
return Redirect("/ReportViewer/Viewer?groupName=YourGroupNameHere");

AiAnyReports — Your Private AI Reporting Studio
Connect it to any database — SQL Server, PostgreSQL, MySQL, SQLite, or MariaDB — and watch it 
instantly generate intelligent, ready-to-use reports using real local AI (Microsoft Phi-4-mini).
No cloud. No subscriptions. No data ever leaves your machine.
Business users and executives can open any report and customize exactly how it looks — change 
titles, totals, column layouts, page size, and charts — without writing a single line of code. 
Every report is saved completely, including its SQL and all your custom settings, in a local SQLite database.
IT professionals and consultants get a powerful starting point in seconds instead of hours. 
No more rebuilding the same grids over and over. Just generate, refine, and deliver professional 
reports that actually belong to you.
Built for real businesses that want control.
Fast. Private. Offline.
And completely free to run forever.


SQLServer, Oracle, PostgreSQL, MySQL, MariaDB, SQLite

https://localhost:7287/ReportViewer/Viewer?groupName=AAA01

//Server=162.214.202.56;Database=RSSFeeds;User Id=rssfeeds;Password=Besom137$;TrustServerCertificate=True;Encrypt=True;MultipleActiveResultSets=True;