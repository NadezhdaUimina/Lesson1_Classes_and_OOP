using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public enum Gender
    {
        Male,
        Female
    }
    internal class FemilyMember
    {
        public FemilyMember Mother { get; set; }
        public FemilyMember Father { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Bird;
     
        public class AdultFamilyMember : FemilyMember
        {
            public AdultFamilyMember[] Children { get; set; }
        } 
        public void ShowParents() //вывод родителей
        {
            Console.WriteLine($"мать: {Mother?.Name}, отец: {Father?.Name}");
        }

        public void ShowFemeliInfo() //вывод дерева
        {
            Console.WriteLine($"бабушка: {Mother?.Mother?.Name}, дедушка: {Father?.Mother?.Name}, \n" +
                $"бабушка: {Mother?.Father?.Name}, дедушка: {Father?.Father?.Name}, \n" +
                $"мать: {Mother?.Name}, отец: {Father?.Name}, \n " +
                $"имя: {Name}, пол: {Gender}, дата рождения: {Bird}");
        }

        public void PersonInfo() //информация о человеке
        {
            Console.WriteLine($"имя: {Name}, пол: {Gender}, дата рождения: {Bird}");
        }

        public void PrintFamilyTree() // вывод детей всех поколений
        { 
            foreach(var child in Children)
            {
                if (child.Cildren is not null)
                {
                    PersonInfo();
                    PrintFamilyTree();
                }
            }
        }
    }  
}
