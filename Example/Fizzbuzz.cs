namespace fizzy
{
    using System;
    public class fizzbuzz
    {
        public string getname(int number)
        {
            if (number % 15 == 0)
            {
                return "fizzbuzz";
            }
            if (number % 5 == 0)
            {
                return "buzz";
            }
            if (number % 3 == 0)
            {
                return "fizz";
            }


            return number.ToString();
        }
        public string getlist(int number)
        {
            var list = "";
            for (var i = 1; i <= number; i++)
            {
                list += this.getname(i);
                if (i < number)
                {
                    list += ",";
                }
            }

            return list;
        }
    }
}