using DomaciUkol_8Lekce_TvaryATelesa;

bool JeKonec = false;
while (!JeKonec)
{
    Console.WriteLine("Uveďte, jaké těleso/tvar chcete vypočítat.\n1 - Čtverec \n2 - Kruh \n3 - Kvádr \n4 - Válec \n0 - Konec");
    string answ = Console.ReadLine();
    bool zkusToZnovu = true;

    while (zkusToZnovu)
    {
        try
        {
            switch (Int32.Parse(answ))
            {
                case (int)Answer.konec:
                    JeKonec = true;
                    break;

                case (int)Answer.ctverec:
                    Ctverec ctverec = new Ctverec();
                    ctverec.Obsah();
                    ctverec.Obvod();
                    break;

                case (int)Answer.kruh:
                    Kruh kruh = new Kruh();
                    kruh.Obsah();
                    kruh.Obvod();
                    break;

                case (int)Answer.kvadr:
                    Kvadr kvadr = new Kvadr();
                    kvadr.Objem();
                    kvadr.Povrch();
                    break;

                case (int)Answer.valec:
                    Valec valec = new Valec();
                    valec.Objem();
                    valec.Povrch();
                    break;

                default:
                    Console.WriteLine("Zřejmě jste jako odpověď nezadali vytyčené číslo, zkuste to znovu:");
                    answ = Console.ReadLine();
                    break;
            }

            zkusToZnovu = false;
        }
        catch (FormatException e)
        {
            Console.WriteLine("Zřejmě jste jako odpověď nezadali vytyčené číslo, zkuste to znovu:");
            answ = Console.ReadLine();
        }
    }
}


enum Answer
{
    konec = 0,
    ctverec = 1,
    kruh = 2,
    kvadr = 3,
    valec = 4
}
