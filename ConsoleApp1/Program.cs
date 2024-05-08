using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using static ConsoleApp1.Program;


namespace ConsoleApp1
{
    internal class Program
    {         
        static void Main(string[] args)
        {
            
            var grandfather = new FemilyMember.AdultFamilyMember() { Mother = null, Father = null, Name = "Иван", Gender = Gender.Male, Bird = DateTime.Parse("01.09.1950") };
            var grandmother = new FemilyMember.AdultFamilyMember() { Mother = null, Father = null, Name = "Мария", Gender = Gender.Female, Bird = DateTime.Parse("20.05.1950") };
            var fater = new FemilyMember.AdultFamilyMember() { Mother = grandfather, Father = null, Name = "Михаил", Gender = Gender.Male, Bird = DateTime.Parse("08.09.1970") };
            var muter = new FemilyMember.AdultFamilyMember() { Mother = null, Father = grandmother, Name = "Ольга", Gender = Gender.Female, Bird = DateTime.Parse("01.10.1962") };
            var son = new FemilyMember() { Mother = muter, Father = fater, Name = "Николай", Gender = Gender.Male, Bird = DateTime.Parse("13.04.1998") };
            var daughter = new FemilyMember() { Mother = muter, Father = fater, Name = "Анастасия", Gender = Gender.Female, Bird = DateTime.Parse("18.12.2000")};
            
            muter.Children = new FemilyMember.AdultFemilyMember[] { son, daughter };
            fater.Children = new FemilyMember.AdultFamilyMember[] { son, daughter };
            grandfather.Children = FemilyMember.AdultFamilyMember[] {  fater };
            grandmother.Children = FemilyMember.AdultFamilyMember[] {  muter };




            son.ShowParents();
            Console.WriteLine();
            Console.WriteLine();
            daughter.ShowParents();
            Console.WriteLine();
            Console.WriteLine();
            son.ShowFemeliInfo();
            Console.WriteLine();
            Console.WriteLine();
            
        }
    }
}