using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DP;

public interface IReportFormat
{
    void Generate();
}

public class WebFormat : IReportFormat
{
    public void Generate()
    {
        Console.WriteLine("Report is created at the web platform.");
    }
    public class DesktopFormat : IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Report is created at the desktop platform.");
        }
    }

    public class Report
    {
        public IReportFormat ReportFormat { get; private set; }


        public Report(IReportFormat reportFormat)
        {
            ReportFormat = reportFormat;
        }

        public virtual void Display()
        {
            ReportFormat.Generate();
        }
    }
    public class SalesReport: Report
    {
        public SalesReport(IReportFormat format)
            : base(format)
        {

        }

        public override void Display()
        {
            Console.WriteLine("--- Report of Sale ---");
            base.Display();
        }
    }

    public class EmployeePerformanceReport: Report
    {
        public EmployeePerformanceReport(IReportFormat format)
             :base(format)
        {

        }

        public override void Display()
        {
            Console.WriteLine("--- Report of Performance ---");
            base.Display();
        }
    }

    class Bridge
    {
        static void Main(string[] args)
        {
            Report report = new EmployeePerformanceReport(new DesktopFormat());
            report.Display();

            Console.WriteLine();

            Report report2 = new SalesReport(new WebFormat());
            report2.Display();

            Console.ReadLine();
        }
    }

}

