using Animali;

Animale a1, a2;     

a1 = new Mucca();       //late binding

Console.WriteLine("Mucca: ");
a1.faiVerso(2);       //si sa cosa fare
a1.dormi();          //già implementato nella classe padre

a2 = new Gatto();
Console.WriteLine("\nGatto: ");
a2.faiVerso(3);       //sarà diverso da quello della mucca!
a2.dormi();


List<Animale> elencoAnimali = new List<Animale>(); 

elencoAnimali.Add(new Mucca());
elencoAnimali.Add(new Gatto());
elencoAnimali.Add(new Mucca());

Console.WriteLine("LISTA ANIMALI:");
foreach (Animale a in elencoAnimali)
    if (a.GetType() == typeof(Mucca))
        a.faiVerso(1);


  