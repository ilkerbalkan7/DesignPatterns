using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Decorator_DP;


public interface IMail
{
    void Send();
}

public class GeneralMail : IMail
    {
    private string from_who;
    private string to_who;

    public GeneralMail(string from_who, string to_who)
    {
        this.from_who = from_who;
        this.to_who = to_who;
    }

    public void Send()
    {
        Console.WriteLine("Mail is going from person {0} to person {1}.", from_who, to_who);
    }

    public abstract class Decorator : IMail
    {
        private IMail mail;
        public Decorator(IMail mail)
        {
            this.mail = mail;
        }

        public virtual void Send()
        {
            mail.Send();
        }
    }

    public class MakePasswordDecorator : Decorator
    {
        public MakePasswordDecorator(IMail mail): base(mail)
        {

        }
        public override void Send()
        {
            base.Send();
            Console.WriteLine("The password is created.");
        }
    }

    public class SignDecorator: Decorator
    {
        private string sign;
        public SignDecorator(IMail mail, string sign): base(mail)
        {
            this.sign = sign;
        }
        public override void Send()
        {
            base.Send();
            Console.WriteLine(sign + " signed as it.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string from_who = "İlker Balkan";
            string to_who = "Cumhur Balkan";
            IMail standardMail = new GeneralMail(from_who, to_who);
            IMail signMail = new SignDecorator(standardMail, "İlker Balkan");
            IMail passwordMail = new MakePasswordDecorator(signMail);
            passwordMail.Send();

            Console.ReadLine();

        }
    }

}

