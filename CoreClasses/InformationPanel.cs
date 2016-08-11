using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DeakinInformation.CoreClasses
{
    class InformationPanel
    {
        private String id;
        private String title;
        private String description;

        public InformationPanel()
        {
            this.id = "";
            this.title = "";
            this.description = "";
        }

        public InformationPanel(String id, String title, String description)
        {
            this.id = id;
            this.title = title;
            this.description = description;
        }

        public String Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
    }
}