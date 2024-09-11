using System;
using System.Collections.Generic;
using System.Text;

namespace AstraEditor.GameProject
{

    public class ProjectTemplate
    {
        public string ProjectType { get; set; }

        public string ProjectFile { get; set; }

        public List<string> Folders { get; set; }
    }
    class NewProject : ViewModelBase
    {
        private readonly string _templatePath = @"..\..\AstraEngine\ProjectTemplates";

        private string _name = "New Project";

        public string Name
        {
           get => _name;
           set
            {
               if( _name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }

        }

        private string _path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\AstraEngine\";
        public string Path
        {
            get => _path;
            set
            {
                if (_path != value)
                {
                    _path = value;
                    OnPropertyChanged(nameof(Path));
                }
            }

        }

        public NewProject()
        {

        }
    }
}
