using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cokbook
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestMethod()
        {
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
        [Test]
        public void RecipeVoted()
        {
            VoteRecipe TopRecipeVoteed = new VoteRecipe();
            Assert.That(TopRecipeVoteed.AlreadyVoted("Ivo", "1"), Is.EqualTo(false), "Some useful error message");
        }
        [Test]
        public void VotePositive()
        {
            VoteRecipe VotePositive = new VoteRecipe();
            Assert.That(VotePositive.Takepositivevotes("1"), Is.EqualTo(0), "Some useful error message");
        }

        [Test]
        public void Takenegativevotes()
        {
            VoteRecipe Takenegativevotes = new VoteRecipe();
            Assert.That(Takenegativevotes.Takenegativevotes("1"), Is.EqualTo(0), "Some useful error message");
        }
        [Test]
        public void CheckLoginDetails()
        {
            Register_Login_Connection test = new Register_Login_Connection();
            List<string> list = test.CheckLoginDetails("Ivo", "123");
            Assert.That(list.Count, Is.EqualTo(3), "Some useful error message");
        }
        [Test]
        public void Checkform()
        {
            Form1 test = new Form1();
            test.regname.Text = "Dragan";
            test.regage.Text = "42";
            test.reggender.Text = "male";
            test.regemail.Text = "ivo_radev2@abv.bg";
            test.regpassword.Text = "123456789";
            test.Button2_Click("JOIN CHEF FORM",new EventArgs());
        }
        [Test]
        public void Cook_Click()
        {
            Form1 test = new Form1();
            test.chefName.Text = "Ivo";
            test.password.Text = "123";
            test.Cook_Click("COOK",new EventArgs());
        }
    }
}
