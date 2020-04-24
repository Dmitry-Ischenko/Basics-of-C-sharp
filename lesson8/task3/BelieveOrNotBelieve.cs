using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task3
{
    [Serializable]
    public class Question
    {
        public string TextQuestion { get; set; }
        public Boolean Answer { get; set; }
        public Question ()
        {

        }
         public Question (string textQuestion, Boolean answer)
        {
            TextQuestion = textQuestion;
            Answer = answer;
        }
    }
    public class TrueFalse
    {
        List<Question> questionsList;

        public TrueFalse ()
        {
            questionsList = new List<Question>();
        }
        public void LoadFromFile (string path)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            questionsList = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public void SaveInFile(string path)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, questionsList);
            fStream.Close();
        }
        public void Add(string textQuestion, bool answer)
        {
            questionsList.Add(new Question(textQuestion, answer));
        }
        public void Remove(int index)
        {
            if (questionsList != null && index < questionsList.Count && index >= 0) questionsList.RemoveAt(index);
        }
        public Question this[int index]
        {
            get { return questionsList[index]; }
        }
        public int Count
        {
            get { return questionsList.Count; }
        }


    }
}
