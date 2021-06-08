namespace AlgoPrep
{
    public static class ReverseStringExtensions
    {
        public static string Reverse(this string input)
        {
            if(string.IsNullOrEmpty(input))
                return string.Empty;

            char[] chars = input.ToCharArray();
            char temp;
            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i];
               chars[i]= input[input.Length -1 -i];
               chars[input.Length -1 -i] = temp;
            }
            return new string(chars);
        }
    }
}