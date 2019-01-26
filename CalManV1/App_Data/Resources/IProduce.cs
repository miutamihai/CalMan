using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Resources
{
    interface IProduce
    {
        double GetCalories(int ID, int count);
        string GetName(int ID);
    }
}
