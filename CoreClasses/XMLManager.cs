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
using System.Xml.Linq;
using System.IO;

namespace DeakinInformation.CoreClasses
{
    class XMLManager
    {
        private List<InformationPanel> _Panels;
            
        public XMLManager()
        {
            _Panels = new List<InformationPanel>();   
        }

        public void Load(String file_name)
        {
            
            var maps = from c in XElement.Load((file_name)).Elements("ProjectMap")
                       select c;

            _Panels = new List<InformationPanel>();

            foreach (var item in maps)
            {
                _Panels.Add(new InformationPanel() { Id = item.Element("panelid").Value, Title = item.Element("title").Value, Description = item.Element("description").Value });
            }
        }

        public InformationPanel GetPanel(String id)
        {
            foreach (InformationPanel panel in _Panels)
            {
                if (id == panel.Id)
                    return panel;
            }
            return null;
        }

        public void AddPanel(InformationPanel panel)
        {
            _Panels.Add(panel);
        }

        public void RemovePanel(String id)
        {
            if (GetPanel(id) != null)
                _Panels.Remove(GetPanel(id));
        }

        public void UpdatePanel(InformationPanel panel)
        {
            for(int i=0;i<_Panels.Count;i++)
            {
                if (_Panels[i].Id == panel.Id)
                    _Panels[i] = panel;
            }
        }

        public List<InformationPanel> GetAllPanels()
        {
            return _Panels; 
        }

        public List<String> GetInformationCategories()
        {
            List<String> _Categories;
            _Categories = new List<String>();

            for (int i = 0; i < _Panels.Count; i++)
            {
                _Categories.Add(_Panels[i].Title);
            }
            return _Categories;
        }
    }
}