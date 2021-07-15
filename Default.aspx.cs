using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace webappPolutionIndex
{
    public partial class _Default : Page
    {
       
        Dictionary<string,string> MainlistFromJson;

        string path1 = AppDomain.CurrentDomain.BaseDirectory + "english.json";
        string pathImg = "ciggrette_icon.png";
        protected void Page_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadAllText();
        }

        private void LoadAllText()
        {
             
        }

        void onClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int id = Convert.ToInt32(b.ID);
            GenerateAitQualityIndex(id);
            GenerateCigImages(id);
        }
        public List<string> listOfaqis = new List<string>();
        public List<string> listOfCiggs = new List<string>();
        public void loaddata()
        {
            string myJsonResponse = File.ReadAllText(path1);
            MainlistFromJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(myJsonResponse);

            GenerateHeaderImage();

            GenerateHeaderText();

            GeneratePlaceButton();
            
            GenerateFooterText();
        }

        private void GenerateHeaderImage()
        {
            Image img = new Image();
            string im = "hero_1_image";
            var c = MainlistFromJson.Where(a => a.Key == im).Select(b => b.Value).ToList();
            img.ImageUrl = c[0];
            img.Width = Unit.Percentage(100);
            img.Height = Unit.Percentage(100); 
            PanelHeadImage.Controls.Add(img);

        }

        private void GenerateHeaderText()
        {
            for (int i = 1; i <= 5; i++)
            {
                //PanelFooter.Controls.Add(lblAiq);
                Literal ltrDyn = new Literal();
                string name = "p_" + i + "_value";
                var c1 = MainlistFromJson.Where(a => a.Key == name).Select(b => b.Value).ToList();
                ltrDyn.Text = "<html><body><p>" + c1[0] + "</p></br></body></html>";
                PanelHeader.Controls.Add(ltrDyn);

            }
            
        }

        private void GenerateFooterText()
        {
            for(int i=6; i<=10; i++)
            {

                //PanelFooter.Controls.Add(lblAiq);
                Literal ltrDyn = new Literal();
                string name = "p_" + i + "_value";
                var c1 = MainlistFromJson.Where(a => a.Key == name).Select(b => b.Value).ToList();
                ltrDyn.Text = "<html><body><p>"+ c1[0] + "</p></br></body></html>";
                PanelFooter.Controls.Add(ltrDyn);

            }
            
            
        }

        private void GenerateCigImages(int id)
        {
            Label lblAiq = new Label();
            string name = "compare-tabs_1_city_" + id + "_name";
            var c1 = MainlistFromJson.Where(a => a.Key == name).Select(b => b.Value).ToList();
            lblAiq.Text = c1[0];
            PanelCity.Controls.Add(lblAiq);

            string cig = "compare-tabs_1_city_" + id + "_cigg";
            var c = MainlistFromJson.Where(a => a.Key == cig).Select(b => b.Value).ToList();
            int no = Convert.ToInt32(c[0]);
           // Image image2 = Image.("c:\\FakePhoto2.jpg");
            for (int count = 0; count < no; count++)
            {
                Image img = new Image();
                img.ImageUrl = pathImg;
                img.Width = 20;
                img.Height = 60;
                PanelCig.Controls.Add(img);
              
            }
        }

        private void GenerateAitQualityIndex(int id)
        {
                    int i = 0;
                    i++;
                    Label lblAiq = new Label();
                     string aiq = "compare-tabs_1_city_" + id+"_aqi";
                     var c = MainlistFromJson.Where(a => a.Key == aiq).Select(b => b.Value).ToList();
                    lblAiq.Text = c[0];
                    lblAiq.ID = i.ToString();
            
                    //ButtonChange.Font.Size = FontUnit.Point(7);
                    lblAiq.ForeColor= System.Drawing.Color.Black;
                    lblAiq.Font.Size = 10;
                    lblAiq.Width = Unit.Pixel(lblAiq.Text.Length * 16);
                    PanelAirQualityIndex.Controls.Add(lblAiq);
        }

        private void GeneratePlaceButton()
        {
            int i = 0; 
            foreach (var item in MainlistFromJson)
            {


                if (item.Key.Contains("name"))
                {
                    i++;
                    Button ButtonChange = new Button();

                    ButtonChange.Text = item.Value.ToString();
                    ButtonChange.ID = i.ToString();
                    //ButtonChange.Font.Size = FontUnit.Point(7);
                    ButtonChange.ControlStyle.CssClass = "button";
                    ButtonChange.Font.Size = 10;
                    ButtonChange.Width = Unit.Pixel((item.Value.Length) * 10);
                    btnPanel.Controls.Add(ButtonChange);

                    ButtonChange.Click += new EventHandler(onClick);
                    
                    // listOfPlaces = new List<model.Dropdownmodel.places>();
                    // listOfPlaces.Add(new model.Dropdownmodel.places { Id = i, Name = item.Value.ToString() });
                }

                if (item.Key.Contains("aqi"))
                {
                     listOfaqis.Add(item.Value.ToString());
                }
                if (item.Key.Contains("cig"))
                {
                     listOfCiggs.Add(item.Value.ToString());
                }
            }
        }


    }
}