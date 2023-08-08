namespace CSharp9
{
    public class DicSamples
    {
        public void Run()
        {

            try
            {
                //GetFromDicSample();
                //Console.WriteLine("GetFromDicSample");
                
                //AddToDicSample();
                //Console.WriteLine("AddToDicSample");
                
                //WriteToFile();
                //Console.WriteLine("WriteToFile");
                
                ReadFromFile();
                Console.WriteLine("ReadFromFile");
            }
            catch (Exception ex)
            {
                //ex.Message
                Console.WriteLine("Error ....!!!!");
            }

        }

        private void ReadFromFile()
        {
            var FileName = "D:\\userInput.txt";

            string content = "";

            //if (File.Exists(FileName))
            content = File.ReadAllText(FileName);
        }
        private void WriteToFile()
        {
            Console.WriteLine("input : ");

            while (true)
            {

                var str = Console.ReadLine();
                if (str == "0")
                    break;
                File.AppendAllText("userInput.txt", str + Environment.NewLine);
            }
        }

        private void GetFromDicSample()
        {
            Dictionary<string, User> usersDic = new();
            usersDic.TryGetValue("b", out User user);

            if (user != null)
                Console.WriteLine(user.Age);
            else
                Console.WriteLine("User Is null");

        }
        private void AddToDicSample()
        {
            Dictionary<string, User> usersDic = new();
            usersDic.Add("a", new User());

            if (usersDic.ContainsKey("a"))
                Console.WriteLine("Key is duplicate");
            else
                usersDic.Add("a", new User());
        }
    }

}
