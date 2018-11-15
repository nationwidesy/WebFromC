using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationCWebForm.App_Code;

namespace WebApplicationCWebForm
{
    public partial class WebApplicationCWebFormDemo : System.Web.UI.Page
    {

        public string myFunction ;
        public const string Age = "Age";
        public const string AgeYMD = "AgeYMD";

        protected void Page_Load(object sender, EventArgs e)
        {
            myFunction = AgeYMD;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //using statment
            using (sophyDB1Entities1 db = new sophyDB1Entities1 ())
            {
                Articoli  art = db.Articolis.Where((x) => x.CodArt == "ART001").FirstOrDefault();
                this.ShowResult.Text = art.DesArt;

                Person p1 = db.People.Where((x) => x.Name.StartsWith("s")).FirstOrDefault();
                this.ShowResult0.Text = p1.Name;

                Famiglie f1 = db.Famiglies.Where((x) => x.CodFamiglia.StartsWith ("F")).FirstOrDefault ();
                this.ShowResult1.Text = f1.DesFamiglia;
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Output.WriteLine("{0} is {1:d}",  "Current Dat time ", DateTime.Now );
            Response.Write ( "<br>Current Dat time: " + DateTime.Now);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            System.Web.Mail.MailMessage mailMsg = new System.Web.Mail.MailMessage
            {
                From = "nationwidejy@hotmail.com",
                To = "nationwidesy@hotmail.com",
                Subject = "Test email from ASP.net",
                Body = "Hi this is a test email"
            };
            /*
             * mailMsg.From = "nationwidejy@hotmail.com";
             * mailMsg.To = "nationwidesy@hotmail.com";
             * mailMsg.From = Subject = "Test email from ASP.net";
             * mailMsg.From = Body = "Hi this is a test email";
             * 
             */
            //SmtpMail.SmtpServer = "smtp.gmail.com";
            //SmtpMail.Send(mailMsg);

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("winbackuponall@gmail.com", "nationwideSophy"),
                EnableSsl = true
            };
            client.Send("winbackuponall@gmail.com", "nationwidejy@hotmail.com", "Test email from ASP.net", "Hi this is a test email");

            
         }

        protected void Button4_Click(object sender, EventArgs e)
        {
            WcfServiceDemoC.Service1 ws = new WcfServiceDemoC.Service1();

            this.ShowResult.Text = ws.GetData(this.ShowResult0.Text);
        }

  
        protected void Button5_Click(object sender, EventArgs e)
        {
            WelcomeWCFService.WelcomeWCFService ws = new WelcomeWCFService.WelcomeWCFService();

            this.ShowResult.Text = ws.Welcome (this.ShowResult0.Text);


        }

 
        protected void Button6_Click(object sender, EventArgs e)
        {
            TestRecordService.TestRecord records = new TestRecordService.TestRecord();
            TestRecordService.TestRecords ws = new TestRecordService.TestRecords();
            DataSet ds = ws.SelectUserDetails();
            this.GridView1.DataSource = ds;
            this.GridView1.DataBind();
            this.GridView1.Visible = true;
            this.hideGridView_bnt.Visible = true;
        }

  
  
        protected void hideGridView_bnt_Click(object sender, EventArgs e)
        {
            this.GridView1.Visible = false;
            this.hideGridView_bnt.Visible = false;
        }

  

        protected void Button9_Click(object sender, EventArgs e)
        {
            this.myFunction = AgeYMD ;
            this.Label1.Visible = false;
            this.TextBox1.Visible = false;
            this.Button11.Visible = true;

            this.Calendar1.Visible = true;

            this.SelectYears.Items.Add("Select year");
            for (int i = 1950; i <= DateTime.Today.Year; i++)
            {
                this.SelectYears.Items.Add(i.ToString());
            }
            this.SelectYears.Visible = true;

            this.SelectMonth.Items.Add("Slect Month");
            for (int i = 1; i <= 12; i++)
            {
                this.SelectMonth.Items.Add(i.ToString());
            }
            this.SelectMonth.Visible = true;

            this.SelectDay.Items.Add("Select Day");
            for (int i = 1 ; i <= 31; i++)
            {
                this.SelectDay.Items.Add(i.ToString());
            }
            this.SelectDay.Visible = true;

            AgeCalculation.Service1 ws = new AgeCalculation.Service1();
           // ws.CalculateDays(int day, out bool daySpecified,  int Month, out bool MonthSpecified,   int year, out bool yearSpecified, out int CalculateDaysResult, out bool CalateDaysResultSpecified);
            ws.CalculateDays(18, true  , 10,  true  , 1960,  true, out int CalculateDaysResult, out bool CalateDaysResultSpecified);
            this.TextBox1.Text = CalculateDaysResult.ToString();
            this.Label1.Text = "Your days in the earth: ";
            this.TextBox1.Visible = true;
            this.Label1.Visible = true;

        }


        protected void Button10_Click(object sender, EventArgs e)
        {
            this.Calendar1.Visible = false;
            this.Button10.Visible = false;
            this.myFunction = string.Empty;
            this.SelectYears.Visible = false;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            switch (myFunction)
            {
                case Age: //DOB not working value won't passed to service
                    AgeCalculation.DOB d = new AgeCalculation.DOB();
                    AgeCalculation.Service1 ws = new AgeCalculation.Service1();
                    d.Day = this.Calendar1.SelectedDate.Day;
                    d.Month = this.Calendar1.SelectedDate.Month;
                    d.Year = this.Calendar1.SelectedDate.Year;
                    //ws.Ages(d, out int agesResult, out bool AgesresualtSpecified, out int days, out bool daysSpecified, out string yourAge);
                    int agesResult;
                    bool AgesresualtSpecified;
                    int days;
                    bool daysSpecified;
                    string yourAge;
                    ws.Ages(d, out   agesResult, out   AgesresualtSpecified, out days, out   daysSpecified, out   yourAge);

                    this.Label1.Text = "Your ages: ";
                    this.TextBox1.Text =  yourAge;
                    this.Label1.Visible = true;
                    this.TextBox1.Visible = true;

                    break;
                case AgeYMD:
                     
                    AgeCalculation.Service1 wsYMD = new AgeCalculation.Service1();
                    int day = this.Calendar1.SelectedDate.Day;
                    int month = this.Calendar1.SelectedDate.Month;
                    int year  = this.Calendar1.SelectedDate.Year;


                    wsYMD.AgesYMD(year, true, month, true, day, true, out int AgesYMDResult, out bool agesYMDResultSpecified, out int Outdays, out bool dayspecified, out string OutyourAge);

                    this.Label1.Text = "Your ages: ";
                    this.TextBox1.Text = OutyourAge;
                    this.Label1.Visible = true;
                    this.TextBox1.Visible = true;

                    break;
            }
                        
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ShowResult_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ShowResult0_TextChanged(object sender, EventArgs e)
        {

        }

  
        protected void SelectYears_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        protected void SelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
         }

        protected void SelectDay_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        protected void Button11_Click(object sender, EventArgs e)
        {

            int year = System.Convert.ToInt32(SelectYears.SelectedValue);
            int month = System.Convert.ToInt32(SelectMonth.SelectedValue);
            int day = System.Convert.ToInt32(SelectDay.SelectedValue);
            DateTime dt = new DateTime(year, month, day);
             switch (myFunction)
            {
                case Age: //DOB not working value won't passed to service
                    AgeCalculation.DOB d = new AgeCalculation.DOB();
                    AgeCalculation.Service1 ws = new AgeCalculation.Service1();
                    d.Day = dt.Day ;
                    d.Month = dt.Month ;
                    d.Year = dt.Year ;
 
                    //ws.Ages(d, out int agesResult, out bool AgesresualtSpecified, out int days, out bool daysSpecified, out string yourAge);
                    ws.Ages(d, out int AgesResult, out bool AgesResultSpecified, out int days, out bool daysSpecified, out string yourAge);
                    this.Label1.Text = "Your ages: ";
                    this.TextBox1.Text = yourAge;
                    this.Label1.Visible = true;
                    this.TextBox1.Visible = true;
                    this.SelectDay.Items.Clear();
                    this.SelectMonth.Items.Clear();
                    this.SelectYears.Items.Clear();
                    break;
                case AgeYMD:

                    AgeCalculation.Service1 wsYMD = new AgeCalculation.Service1();
                     

                    wsYMD.AgesYMD(year, true, month, true, day, true, out int AgesYMDResult, out bool agesYMDResultSpecified, out int Outdays, out bool dayspecified, out string OutyourAge);

                    this.Label1.Text = "Your ages: ";
                    this.TextBox1.Text = OutyourAge;
                    this.Label1.Visible = true;
                    this.TextBox1.Visible = true;

                    break;
            }
            this.SelectYears.Visible = false;
            this.SelectDay.Visible = false;
            this.SelectMonth.Visible = false;
            this.Button11.Visible = false;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            ArrayDemo array = new ArrayDemo();
            this.ShowResult.Text = array.output;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            this.ShowResult.Text = string.Empty;
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            this.ShowResult1.Text = string.Empty;
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            this.ShowResult0.Text = string.Empty;
        }

        protected void ShowResult1_TextChanged(object sender, EventArgs e)
        {
            
        }
    } 
}