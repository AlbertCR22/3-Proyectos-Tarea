using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso4
{
    public abstract class Banco
    {
        public abstract void enviarFondos();
        public abstract void recibirFondos();
        public abstract void venderDolares();
        public abstract void comprarDolares();

    }

    public class BancoInternacional : Banco
    {
        public override void comprarDolares()
        {
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaa");
        }
        public override void enviarFondos()
        {
            Console.WriteLine("bbbbbbbbbbbbbbbbbbbbbbb");
        }
        public override void recibirFondos()
        {
            Console.WriteLine("cccccccccccccccccccccc");
        }
        public override void venderDolares()
        {
            Console.WriteLine("dddddddddddddddddddddddd");
        }

    }

    public class BancoNacional : Banco
    {
        public override void comprarDolares()
        {
        }

        public override void enviarFondos()
        {
        }

        public override void recibirFondos()
        {
        }

        public override void venderDolares()
        {
        }
    }

    public class BancoPymes : Banco
    {
        public override void comprarDolares()
        {
            Console.WriteLine("eeeeeeeeeeee");
        }

        public override void enviarFondos()
        {
            Console.WriteLine("fffffffffffffffffffffff");

        }

        public override void recibirFondos()
        {
            Console.WriteLine("ggggggggggggggggggggggg");

        }

        public override void venderDolares()
        {
            Console.WriteLine("hhhhhhhhhhhhhhhhhhhhhhhh");

        }
    }
    //public class Creadora
    //{
    //    public const int BI = 1;
    //    public const int BN = 2;
    //    public const int BP = 3;

    //    public static Banco CrearBanco(int TipoBanco)
    //    {
    //        switch (TipoBanco)
    //        {
    //            case BI:
    //                return new BancoInternacional();
    //            case BN:
    //                return new BancoNacional();
    //            case BP:
    //                return new BancoPymes();
    //            default:
    //                return null;

    //        }
    //    }
    //}
}
