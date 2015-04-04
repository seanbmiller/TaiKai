using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace PanelCsvConvert
{
    public sealed class PanelApplicationMap:CsvClassMap<PanelApplication>
    {
        public PanelApplicationMap()
        {
            Map(m => m.Title).Name("Title");
            Map(m => m.ContentRating).Name("Content Rating");
            Map(m => m.PreferredPanelDuration).Name("Preferred Panel Duration");
            Map(m => m.SchedulePreference).Name("Schedule Preference");
            Map(m => m.ConbookDescription).Name("Conbook Description");
            Map(m => m.DescriptionForPanelApplication).Name("Description for Panel Application");
            Map(m => m.PreferredPanelAudienceLayout).Name("Preferred Panel Audience Layout");
            Map(m => m.Email).Name("Email");
            Map(m => m.NameFirst).Name("Name (First)");
            Map(m => m.NameLast).Name("Name (Last)");
            Map(m => m.NamesOfOtherPresenters).Name("Names of Other Presenters");
            Map(m => m.Phone).Name("Phone #");
            Map(m => m.OtherPanelsActivities).Name("Other Panels/Activities");
            Map(m => m.AdditionalNotes).Name("Additional Notes");
            Map(m => m.CreatedByUserId).Name("Created By (User Id)");
            Map(m => m.EntryId).Name("Entry Id");
            Map(m => m.EntryDate).Name("Entry Date");
            Map(m => m.SourceUrl).Name("Source Url");
            Map(m => m.TransactionId).Name("Transaction Id");
            Map(m => m.PaymentAmount).Name("Payment Amount");
            Map(m => m.PaymentDate).Name("Payment Date");
            Map(m => m.PaymentStatus).Name("Payment Status");
            Map(m => m.PostId).Name("Post Id");
            Map(m => m.UserAgent).Name("User Agent");
            Map(m => m.UserIp).Name("User IP");
        }
    }

    public class PanelApplication
    {
        public String Title { get; set; }
        public String ContentRating { get; set; }
        public String PreferredPanelDuration { get; set; }
        public String SchedulePreference { get; set; }
        public String ConbookDescription { get; set; }
        public String DescriptionForPanelApplication { get; set; }
        public String PreferredPanelAudienceLayout { get; set; }
        public String Email { get; set; }
        public String NameFirst { get; set; }
        public String NameLast { get; set; }
        public String NamesOfOtherPresenters { get; set; }
        public String Phone { get; set; }
        public String OtherPanelsActivities { get; set; }
        public String AdditionalNotes { get; set; }
        public String CreatedByUserId { get; set; }
        public String EntryId { get; set; }
        public String EntryDate { get; set; }
        public String SourceUrl { get; set; }
        public String TransactionId { get; set; }
        public String PaymentAmount { get; set; }
        public String PaymentDate { get; set; }
        public String PaymentStatus { get; set; }
        public String PostId { get; set; }
        public String UserAgent { get; set; }
        public String UserIp { get; set; }
    }
}
