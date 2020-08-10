using System;
using System.Collections.Generic;
using System.Text;

namespace ConstantVariables
{
    public class Tree
    {
        public string _type;
        public string _color;
        public int _age;
        

        public Tree(string type)
            : this(type, "" , 0) {
        }

        public Tree (string type, string color)
            : this (type, color, 0)  {

        }

        public Tree(string typeName, string colorName, int ageOfTree)
        {
            _type = typeName;
            _color = colorName;
            _age = ageOfTree;
        }
    }
}
