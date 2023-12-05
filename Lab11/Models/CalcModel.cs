namespace Lab11.Models
{
    public class CalcModel
    {
        public int value1;
        public int value2;

        public CalcModel()
        {
            Random rnd = new Random();

            value1 = rnd.Next(0, 10); 
            value2 = rnd.Next(0, 10);
        }
            
    }
}