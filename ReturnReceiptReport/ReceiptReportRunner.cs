using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnReceiptReport
{
    /// <summary>
    /// Given a range of dates, runs the reports on the given database.
    /// </summary>
    class ReceiptReportRunner
    {
        public void RunReportGivenDate(DateTime start, DateTime end)
        {
            for (DateTime current = start; current.Month <= end.Month; current.AddMonths(1))
            {

            }
        }
    }
}
