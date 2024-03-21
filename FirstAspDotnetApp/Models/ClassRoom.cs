using System;
using FirstAspDotnetApp.Models;

namespace FirstAspDotnetApp.ViewModels.Home
{
	public class ClassRoom
	{
		public string Name { get; set; }
        public List<Students> Students { get; set; }

        public ClassRoom(string name)
        {
            Name = name;
            Students = new List<Students>();
        }
    }
}

