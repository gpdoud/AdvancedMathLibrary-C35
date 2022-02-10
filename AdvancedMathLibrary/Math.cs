using System;

namespace AdvancedMathLibrary {

    public static class Math {

        public const int Zero = 0;

        public static int AbsoluteValue(int x) {
            return (x < 0) ? -x : x;
        }
        public static int Add(int x, int y) {
            return x + y;
        }
        public static int Subtract(int x, int y) {
            return x - y;
        }
        public static int Multiply(int x, int y) {
            return x * y;
        }
        public static int Divide(int x, int y) {
            if(y == 0) {
                return 0;
            }
            return x / y;
        }
    }
}
