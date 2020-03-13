using Newtonsoft.Json;

using StudentManagementSystem.Object;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentManagementSystem
{
    public class DataManager
    {
        private List<Student> listStudent = new List<Student>();
        private List<Lecturer> listLecturer = new List<Lecturer>();
        private string studentDbPath = "./db/students.db";
        private string lecturerDbPath = "./db/lecturer.db";
        private static DataManager instance;

        public static DataManager GetInstance()
        {
            if (instance == null)
                instance = new DataManager();
            return instance;
        }
        private DataManager()
        {
            Load();
        }

        public void Add(Person p)
        {
            if (p is Student)
            {
                Student s = p as Student;
                //if (s.isValidID())
                listStudent.Add(s);

            }
            else
            {
                Lecturer l = p as Lecturer;
                //if (l.isValidID())
                listLecturer.Add(l);

            }
            Save();
        }
        public string GetNextLecturerId()
        {
            return listLecturer.Count == 0 ? "00000001" : (listLecturer.Max(l => Convert.ToInt32(l.ID)) + 1).ToString().PadLeft(8, '0');
        }

        public string GetNextStudentId(string type)
        {

            return type + (listStudent.Count == 0 ? "000001" : (listStudent.Max(s => Convert.ToInt32(s.ID.Substring(2, 6))) + 1).ToString().PadLeft(6, '0'));
        }
        public List<Student> FindStudent(string query)
        {
            return listStudent.FindAll(s => s.ToString().ToLower().Trim().Contains(query.ToLower().Trim()));
        }

        public List<Lecturer> FindLecturer(string query)
        {
            return listLecturer.FindAll(l => l.ToString().ToLower().Trim().Contains(query.ToLower().Trim()));
        }

        public Student FindStudentByID(string id)
        {
            return listStudent.Find(s => s.ID == id);
        }
        public Lecturer FindLecturerByID(string id)
        {
            return listLecturer.Find(l => l.ID == id);
        }
        public List<Student> AllStudent()
        {
            return listStudent;
        }

        public List<Lecturer> AllLecturer()
        {
            return listLecturer;
        }

        public void Delete(Person p)
        {
            if (p is Student)
                listStudent.Remove(p as Student);
            else
                listLecturer.Remove(p as Lecturer);

            Save();
        }

        private void Load()
        {
            listStudent = JsonConvert.DeserializeObject<List<Student>>(ReadFile(studentDbPath));
            listLecturer = JsonConvert.DeserializeObject<List<Lecturer>>(ReadFile(lecturerDbPath));
        }

        private void Save()
        {
            if (!Directory.Exists("./db/")) Directory.CreateDirectory("./db/");

            File.WriteAllText(studentDbPath, JsonConvert.SerializeObject(listStudent));
            File.WriteAllText(lecturerDbPath, JsonConvert.SerializeObject(listLecturer));
        }

        private string ReadFile(string filename)
        {
            return File.Exists(filename) ? File.ReadAllText(filename) : "[]";
        }

        internal void Update(string id, Person n)
        {
            int i = listStudent.FindIndex(s => s.ID == id);
            if (n is Student)
                listStudent[listStudent.FindIndex(s => s.ID == id)] = n as Student;
            else
                listLecturer[listLecturer.FindIndex(l => l.ID == id)] = n as Lecturer;

            Save();
        }
    }
}
