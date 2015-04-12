using System;
using System.Collections.Generic;

namespace Movies4You
{
    public class Library
    {
        public IList<Title> Titles { get; private set; }

        public Library()
        {
            Titles = new List<Title>();
        }

        public void AddNewTitle(Title title)
        {
            this.Titles.Add(title);
        }

        public void AddDonatedTitle(Title donatedTitle, Member donator)
        {
            AddNewTitle(donatedTitle);
            //donator.AddPoints(3);
        }
    }
}

