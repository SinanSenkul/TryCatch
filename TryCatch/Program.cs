
class Program
{
    static void Main(string[] args)
    {
        void squareFinder()
        {
            try
            {
                Console.WriteLine("bir sayı giriniz");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"girdiğiniz sayının karesi: {num * num}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("format hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }
        squareFinder();
    }
}