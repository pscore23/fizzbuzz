using System;

namespace FizzBuzz {
    public static class Program {
        public static void Main(string[] args) {
            for (int i = 1; i <= 100000; i++) {
                Console.WriteLine(Calc(i));
            }
        }

        private static string Calc(int n) {
            string is_fb = "";

            if (n % 3 == 0) {
                is_fb+= "Fizz";
            }

            if (n % 5 == 0) {
                is_fb+= "Buzz";
            }

            return is_fb == "" ? n.ToString() : is_fb;
        }
    }
}
