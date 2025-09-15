namespace SimpleCalculator
{
    public static class OperatorConverter
    {
        public static string Convert(string input)
        {
            return input.Trim();
        }

        public static string ToWord(string op)
        {
            switch (op)
            {
                case "+": return "plus";
                case "-": return "minus";
                case "×": return "multiplied by";
                case "÷": return "divided by";
                case "%": return "modulus of";
                default: return "unknown operation";
            }
        }
    }
}
