using System;
using FirstAspDotnetApp.Models;
using FirstAspDotnetApp.ViewModels.Home;

namespace FirstAspDotnetApp.ViewModels.Classroom
{
	public class IndexViewModel
	{
		public List<ClassRoom> ClassRooms { get; set; } = new List<ClassRoom>();
        ClassRoom CDA = new ClassRoom("CDA");
        public List<Students> Student = new List<Students>();

        public IndexViewModel()
        {
            Student.Add (new Students("Imane", "Cherraj", CDA));
            Student.Add(new Students("Arnaud", "Muller", CDA));
            Student.Add(new Students("Alexandre", "Dach", CDA));
            Student.Add(new Students("Axel", "Martin", CDA));
            Student.Add(new Students("Cyril", "Cherrier", CDA));
            Student.Add(new Students("Jessica", "Gualtieri", CDA));
            Student.Add(new Students("Mathias", "Dumas", CDA));
            Student.Add(new Students("Isabelle", "Apoux", CDA));
            Student.Add(new Students("Florent", "Bernar", CDA));
            Student.Add(new Students("Alexandre", "Cerf", CDA));
            Student.Add(new Students("Clément", "Parpaiola", CDA));
            Student.Add(new Students("Fabien", "Hasselmann", CDA));
            Student.Add(new Students("Louis", "Kuster", CDA));
            Student.Add(new Students("Thomas", "Thouvenin", CDA));
            Student.Add(new Students("Nadejda", "Teriokhina", CDA));
            Student.Add(new Students("Necati", "Han", CDA));
            ClassRooms.Add(CDA);
        }

    }
}

