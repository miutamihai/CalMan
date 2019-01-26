using System;
using Resources;

namespace Logic
{
    public class Calculate
    {
        private double inputValue;
        private int size;
        private bool[] selectedIDs = new bool[61];
        Storage storage = new Storage();
        public Calculate()
        {
            size = storage.ListSize;
        }
        public void SetInput(double input) => inputValue = input;
        private int GetID()
        {

            Random random = RandomProvider.GetThreadRandom();
            int aux = random.Next(size);
            while (selectedIDs[aux])
                aux = random.Next(size);
            selectedIDs[aux] = true;
            return aux;
        }
        private int Substract(int ID, double value)
        {
            int ct = -1;
            while (value <= inputValue)
            {
                inputValue -= value;
                ct++;
                if (ct == 6) break;
            }
            return ct;
        }
        public string Result()
        {

            int ID = GetID();
            string result;
            double calories = storage.GetCalories(ID, 100);
            int multiplier = Substract(ID, calories);
            if (multiplier == -1) return "";
            result = System.Convert.ToString(calories * multiplier) + "g " + storage.GetName(ID) + "\n";
            ID = GetID();
            calories = storage.GetCalories(ID, 50);
            multiplier = Substract(ID, calories);
            if (multiplier == -1) return result;
            result += System.Convert.ToString(calories * multiplier) + "g " + storage.GetName(ID) + "\n";
            ID = GetID();
            calories = storage.GetCalories(ID, 10);
            multiplier = Substract(ID, calories);
            if (multiplier == -1) return result;
            return result + System.Convert.ToString(calories * multiplier) + "g " + storage.GetName(ID);

        }
    }
}
