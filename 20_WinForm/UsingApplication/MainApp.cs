using System;
using System.Windows.Forms;

namespace UsingApplication
{
    class MyForm : System.Windows.Forms.Form
    {
    }

    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();

            // 윈도우를 클릭하면 Application.Exit()를 호출
            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Closing Window...");
                    Application.Exit();
                });

            Console.WriteLine("Starting Window Application...");
            Application.Run(form);

            Console.WriteLine("Exiting Window Application...");
        }
    }
}
