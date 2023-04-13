using Animali;

Animale a1, a2;         //non so ancora cosa ci sarà in a1 e in a2

a1 = new Mucca();       //late binding (so che una mucca in fase dopo la chiarazione)

Console.WriteLine("Mucca: ");
a1.faiVerso(2);       //si sa cosa fare
a1.dormi();          //già implementato nella classe padre

a2 = new Gatto();
Console.WriteLine("\nGatto: ");
a2.faiVerso(3);       //sarà diverso da quello della mucca!
a2.dormi();


Gatto g;        //Early binding (E' un'istanza di tipo Gatto)
g= new Gatto();

List<Animale> elencoAnimali = new List<Animale>(); 

elencoAnimali.Add(new Mucca());
elencoAnimali.Add(new Gatto());
elencoAnimali.Add(new Mucca());

Console.WriteLine("LISTA ANIMALI:");
foreach (Animale a in elencoAnimali)
    if (a.GetType() == typeof(Mucca))
        a.faiVerso(1);


  