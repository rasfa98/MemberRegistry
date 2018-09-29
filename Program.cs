using System;

namespace MemberRegistry
{
    class Program
    {
        static void Main(string[] args)
        {
            controller.User user = new controller.User();

            while (true)
            {
                try
                {
                    user.StartApplication();
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
