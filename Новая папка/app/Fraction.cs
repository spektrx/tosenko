class Fraction
    {
        private int numerator;
        private int denominator;
        public Fraction(int numerator, int denominator = 1)
        {
            if (numerator.GetType() != typeof(int) && denominator.GetType() != typeof(int))
            {
                throw new Exception("Можно только целые числа");
            }
            else if (denominator == 0)
            {
                throw new Exception("0 в знаменателе нельзя");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public int get_numerator()
        {
            return this.numerator;
        }
        public int get_denominator()
        {
            return this.denominator;
        }
        public void set_numerator(int numerator)
        {
            if (numerator.GetType() != typeof(int))
            {
                throw new Exception("СТроки нельзя");
            }
            this.numerator = numerator;
        }
        public void set_denominator(int denominator)
        {
            if (denominator.GetType() != typeof(int))
            {
                throw new Exception("СТроки нельзя");
            }
            else if (denominator == 0)
            {
                throw new Exception("0 в знаменателе нельзя");
            }
            this.denominator = denominator;
        }
        public void set_fraction(int numerator, int denominator)
        {
            if (numerator.GetType() != typeof(int) && denominator.GetType() != typeof(int))
            {
                throw new Exception("СТроки нельзя");
            }
            else if (denominator == 0)
            {
                throw new Exception("0 в знаменателе нельзя");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public int[] get_fraction()
        {
            int[] fraction = new int[2];
            fraction[0] = this.numerator;
            fraction[1] = this.denominator;
            return fraction;
        }
        public override string ToString()
        {
            while (this.numerator % 2 == 0 && this.denominator % 2 == 0)
            {
                this.numerator /= 2;
                this.denominator /= 2;
            }
            return this.numerator + "\n———\n" + this.denominator;
        }
        public static bool operator >(Fraction num1, Fraction num2)
        {
            int n1 = num1.numerator * num2.denominator;
            int n2 = num2.numerator * num1.denominator;
            return n1 > n2;
        }
        public static bool operator <(Fraction num1, Fraction num2)
        {
            int n1 = num1.numerator * num2.denominator;
            int n2 = num2.numerator * num1.denominator;
            return n1 < n2;
        }
        public static bool operator >=(Fraction num1, Fraction num2)
        {
            int n1 = num1.numerator * num2.denominator;
            int n2 = num2.numerator * num1.denominator;
            return n1 >= n2;
        }
        public static bool operator <=(Fraction num1, Fraction num2)
        {
            int n1 = num1.numerator * num2.denominator;
            int n2 = num2.numerator * num1.denominator;
            return n1 <= n2;
        }
        public static bool operator ==(Fraction num1, Fraction num2)
        {
            int n1 = num1.numerator * num2.denominator;
            int n2 = num2.numerator * num1.denominator;
            return n1 == n2;
        }
        public static bool operator !=(Fraction num1, Fraction num2)
        {
            int n1 = num1.numerator * num2.denominator;
            int n2 = num2.numerator * num1.denominator;
            return n1 != n2;
        }
        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            Fraction num = new Fraction(num1.numerator * num2.denominator + num2.numerator * num1.denominator, num1.denominator * num2.denominator);
            return num;
        }
        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            Fraction num = new Fraction(num1.numerator * num2.denominator - num2.numerator * num1.denominator, num1.denominator * num2.denominator);
            return num;
        }
        public static Fraction operator *(Fraction num1, Fraction num2)
        {
            Fraction num = new Fraction(num1.numerator * num2.numerator, num1.denominator * num2.denominator);
            return num;
        }
        public static Fraction operator /(Fraction num1, Fraction num2)
        {
            Fraction num = new Fraction(num1.numerator * num2.denominator, num1.denominator * num2.numerator);
            return num;
        }
    }
