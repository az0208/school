using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idekbro232
{
    public class ClassMember
    {
        private string name;
        private int myAmount;
        private static int classDiscBox = 0;
        public const int INITIAL_AMOUNTS_OF_DISCS = 3;
        public ClassMember(string name)
        {
            this.name = name;
            this.myAmount = INITIAL_AMOUNTS_OF_DISCS;
            classDiscBox += INITIAL_AMOUNTS_OF_DISCS;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetStudentAmount()
        {
            return this.myAmount;
        }

        public static int GetClassDiscBox()
        {
            return ClassMember.classDiscBox;
        }
        public void EnterDiscs(int amount)
        {
            ClassMember.classDiscBox += amount;
            this.myAmount += amount;
        }
    }
}

