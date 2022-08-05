using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection2
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true)]
    class InformationAttribute : Attribute
    {
        public string InformationString { get; set; }
    }
    [Information(InformationString = "Class")]
    public class ProjectDetails
    {
        private string ProjectName;
        private string Description;
        private string ClientName;
        private string StartDate;
        private string EndDate;
        public string projectname
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        public string clientname
        {
            get { return ClientName; }
            set { ClientName = value; }
        }
        public string startdate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        public string enddate
        {
            get { return EndDate; }
            set
            {
                EndDate = value;
            }
        }
        [Information(InformationString = "Constructor")]
        public ProjectDetails(string ProjectName, string Description, string ClientDetails, string StartDate, string EndDate)
        {
            this.ProjectName = ProjectName;
            this.Description = Description;
            this.ClientName = ClientName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        [Information(InformationString = "Method")]
        public void Display()
        {
            Console.WriteLine("Project Name:{0} ", ProjectName);
            Console.WriteLine("Description:{0}", Description);
            Console.WriteLine("Client Name : {0}", ClientName);
            Console.WriteLine("Start Date: {0}", StartDate);
            Console.WriteLine("End Date: {0}", EndDate);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ProjectDetails PD = new ProjectDetails("C#", " To Create Appliclatons", "Natasha", "07-07-2022", "07-07-2024");
            PD.Display();
            Console.WriteLine("------***------");
            PD.projectname = "C#";
            PD.description = "To Create Applications";
            PD.clientname = "Natasha";
            PD.startdate = "07-07-2022";
            PD.enddate = "07-07-2024";
            Console.WriteLine("project name :" + PD.projectname);
            Console.WriteLine("description:" + PD.description);
            Console.WriteLine("client details: " + PD.clientname);
            Console.WriteLine("start date: " + PD.startdate);
            Console.WriteLine("end date: " + PD.enddate);
        }
    }
}