using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using Microsoft.Win32;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;


namespace Student_List
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Students> Student_List; 
        public MainWindow()
        {
            InitializeComponent();
            Student_List = new ObservableCollection<Students>();
            dataGrid.ItemsSource = Student_List;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Student_List.Add(new Students());
        }

        private void loadFromXmlButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.xml)|*.xml";
            if ((bool)dlg.ShowDialog())
                loadFromXml(dlg.FileName);
        }

        private void loadFromXml(String fileName)
        {
            Student_List.Clear();
            if (System.IO.File.Exists(fileName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);
                XmlNode rootNode = doc["students"];
                foreach (XmlNode s in rootNode.ChildNodes)
                {
                    string name = s.Attributes["Имя"].Value;
                    int age = 0;
                    int.TryParse(s.Attributes["Возраст"].Value, out age);
                    Students.Gender g = Students.Gender.Мужской;
                    if (s.Attributes["Пол"].Value == "Женский")
                        g = Students.Gender.Женский;
                    string faculty = s.Attributes["Факультет"].Value;
                    string group = s.Attributes["Группа"].Value;
                    int kurs = 0;
                    int.TryParse(s.Attributes["Курс"].Value, out kurs);
                    Students st = new Students(name, g, age, faculty, group, kurs);
                    Student_List.Add(st);
                }
            }
        }

        private void saveToXmlButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(.xml)|*.xml";
            if ((bool)dlg.ShowDialog()) 
                saveToXml(dlg.FileName);
        }

        private void saveToXml(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.InnerXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><students></students>";
            XmlElement rootNode = doc["students"];
            foreach (var s in Student_List)
            {
                XmlElement studentNote = doc.CreateElement("student");
                studentNote.SetAttribute("Имя", s.Имя);
                studentNote.SetAttribute("Возраст", s.Возраст.ToString());
                if (s.Пол == Students.Gender.Мужской)
                    studentNote.SetAttribute("Пол", "Мужской");
                else
                    studentNote.SetAttribute("Пол", "Женский");
                studentNote.SetAttribute("Факультет", s.Факультет);
                studentNote.SetAttribute("Группа", s.Группа);
                studentNote.SetAttribute("Курс", s.Курс.ToString());
                rootNode.AppendChild(studentNote);
            }
            doc.Save(fileName);
        }

        private void serializeButton_Click(object sender, RoutedEventArgs e)
        {
            Stream stream = File.Open("student.bin", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, Student_List);
            stream.Close();
        }

        private void deserializeButton_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("student.bin"))
            {
                Stream stream = File.Open("student.bin", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                Student_List = (ObservableCollection<Students>)bformatter.Deserialize(stream);
                stream.Close();
                dataGrid.ItemsSource = Student_List;
            }
        }
    }
}
