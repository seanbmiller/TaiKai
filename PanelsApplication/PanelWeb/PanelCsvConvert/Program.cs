using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace PanelCsvConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var csv = new CsvReader(File.OpenText("panel-application-2015-02-27.csv"));
            csv.Configuration.RegisterClassMap<PanelApplicationMap>();
            var applications = csv.GetRecords<PanelApplication>();
            foreach (var a in applications)
            {
                var sb = new StringBuilder();
                sb.AppendFormat("Entry ID : {0}", a.EntryId).AppendLine();
                sb.AppendFormat("Entry Date : {0}", a.EntryDate).AppendLine();
                sb.AppendFormat("Presenter Name : {0} {1}", a.NameFirst, a.NameLast).AppendLine();
                sb.AppendFormat("Other Presenters : {0}", a.NamesOfOtherPresenters).AppendLine();
                sb.AppendFormat("Title : {0}", a.Title).AppendLine();
                sb.AppendFormat("Phone #: {0}", a.Phone).AppendLine();
                sb.AppendFormat("Content Rating : {0}", a.ContentRating).AppendLine();
                sb.AppendFormat("Preferred Panel Duration : {0}", a.PreferredPanelDuration).AppendLine();
                sb.AppendFormat("Schedule Preference : {0}", a.SchedulePreference).AppendLine();
                sb.AppendFormat("Conbook Description : {0}", a.ConbookDescription).AppendLine();
                sb.AppendFormat("Description for Panel Application : {0}", a.DescriptionForPanelApplication).AppendLine();
                sb.AppendFormat("Additional Notes : {0}", a.AdditionalNotes).AppendLine();
                sb.AppendFormat("Other Panels/Activities : {0}", a.OtherPanelsActivities).AppendLine();

                using (var outfile = new StreamWriter(a.EntryId + @".txt"))
                {
                    outfile.Write(sb.ToString());
                }
            }
        }
    }
}
