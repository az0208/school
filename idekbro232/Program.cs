using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idekbro232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassMember[] members = new ClassMember[3];
            members[0] = new ClassMember("Moshe");
            members[1] = new ClassMember("Dvir");
            members[2] = new ClassMember("Michal");
            for (int i = 0; i < members.Length; i++)
            {
                members[i].EnterDiscs(i);
            }

            Console.WriteLine(members[1].GetStudentAmount());
            Console.WriteLine(ClassMember.GetClassDiscBox());
        }
    }
}
