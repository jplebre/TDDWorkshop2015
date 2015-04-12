using NUnit.Framework;
using Rhino.Mocks;
using System;
using Movies4You;

namespace Movies4YouTests
{
    [TestFixture()]
    public class LibraryTests
    {
        [Test()]
        public void KnowsAboutTitles()
        {
            Library library = new Library();
            Assert.That(library.Titles, Is.Not.Null);
        }

        [Test()]
        public void AddsNewTitles()
        {
            Library library = new Library();
            Title title = new Title();

            library.AddNewTitle(title);

            Assert.That(library.Titles.Count, Is.EqualTo(1));
            Assert.That(library.Titles[0], Is.EqualTo(title));
        }

        [Test()]
        public void TellsTitleToIncreaseCopiesWhenExisitingTitleAdded()
        {
            Library library = new Library();
            Title title = MockRepository.GenerateStub<Title>();

            library.AddNewTitle(title);

            title.AssertWasCalled(t => t.AddCopy());
        }

        [Test()]
        public void AddsDonatedTitle()
        {
            Library library = new Library();
            Title donatedTitle = new Title();
            Member donator = new Member();

            library.AddDonatedTitle(donatedTitle, donator);

            Assert.That(library.Titles.Count, Is.EqualTo(1));
            Assert.That(library.Titles[0], Is.EqualTo(donatedTitle));
        }

    }
}

