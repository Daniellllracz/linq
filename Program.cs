using linq;
#region DOGS

List<Dog> dogs = new()
{
    new()
    {
        Name = "Kira",
        Birth = DateTime.Parse("2019-05-20"),
        Sex = false,
        Breed = "Tacskó",
        Weight = 5.5F,
    },
    new()
    {
        Name = "Rex",
        Birth = DateTime.Parse("2014-05-14"),
        Sex = true,
        Breed = "Németjuhász",
        Weight = 35F,
    },
    new()
    {
        Name = "Igor",
        Birth = DateTime.Parse("2017-05-20"),
        Sex = true,
        Breed = "Kaukázosifarkas ölő",
        Weight = 95F,

    }, new()
    {
        Name = "Thomas Edison",
        Birth = DateTime.Parse("2001-02-07"),
        Sex = true,
        Breed = "Németjuhász",
        Weight = 40.3F,
    },
    new() //05
    {
        Name = "Princess",
        Birth = DateTime.Parse("2022-12-24"),
        Sex = false,
        Breed = "palotapincsi",
        Weight = 4.2F,
    },
};
#endregion

//Milyen programozási tételeket ismerünk?
/*megszámolás tétele
 * rendezések
 * sorozatszámitás (összegzés) -> átlagszámitás
 * szélsőérték meghatározása (min, max)(hely és érték)
 * eldöntés
 * kiválasztás
 * lineáris keresés 
 * szétválogatás (csoportosítás)
 * kiválogatás
 * "halmaztételek"
 *  
 *///
#region MEGSZÁMLÁLÁS
//megszámlálás
// adott tulajdonságú elemek száma a kollekcióban
// 3 évnél öregebb kutyák száma
int haromEvnelIdosebb = 0;
foreach (var dog in dogs)
{
    if (dog.Age >= 3) haromEvnelIdosebb++;
}
Console.WriteLine($"3évnél idősebb kutyák száma: {haromEvnelIdosebb} db");
int linqHaromEvnelIdosebb = dogs.Count(d => d.Age >= 3);
Console.WriteLine($" age{linqHaromEvnelIdosebb}");
//szukák száma
int szukakSzama = 0;
for (int i = 0; i < dogs.Count; i++)
{
    if (!dogs[i].Sex) szukakSzama++;
    
    
}
        Console.WriteLine($"szukák száma {szukakSzama}");
int linqSzukakSzama = dogs.Count(d => !d.Sex);
Console.WriteLine($"eredmény count LINQ-val{linqSzukakSzama}");
int linqEbhk = dogs.Count(dogs => dogs.Sex && dogs.Name.ToLower().Contains("e"));
Console.WriteLine(  $"azon híkutyák száma, akik nevében van 'e betű: {linqEbhk}'");
Console.WriteLine("-----------------------------------------------------------------");
#endregion
#region Összegzes
int kutyakOsszEletkora = 0;
foreach (var dog in dogs)
{
    kutyakOsszEletkora += dog.Age;
}
Console.WriteLine($"kutyák életkora {kutyakOsszEletkora}");
int linqKutyakOsszEletkora = dogs.Sum(d => d.Age);
Console.WriteLine($"eredmeny Summal {linqKutyakOsszEletkora}");
#endregion
//ToDo átlag
#region ToDo Átlag

float kutyakAtlagEletkora = kutyakOsszEletkora / (float)dogs.Count();
Console.WriteLine($"kutyak átlagéletkora {kutyakAtlagEletkora}év");
double linqKutyakAtlagEletkora = dogs.Average(d => d.Age);
Console.WriteLine($"linqval kutyak átlag életkora {linqKutyakAtlagEletkora}");
#endregion
#region Szélsőérték meghatározás
//legnagyobb kutya súlya
//legnagyobb kutya neve
//legnagyobb kutya indexe a listában
int lnski = 0;
for (int i = 1; i < dogs.Count; i++)
{
    if (dogs[i].Weight > dogs[lnski].Weight)
    {
        lnski = i;
    }
}

Console.WriteLine($"legnagyobb súlyú kutya kutya súlya: {dogs[lnski].Weight}kg");
Console.WriteLine($"legnagyobb súlyú kutya neve: {dogs[lnski].Name}");
Console.WriteLine($"legnagyobb súlyú kutya sorszáma: {lnski}");

float linqLnsks = dogs.Max(d => d.Weight);
Console.WriteLine($"linqval kutya legnagyobb súlyú {linqLnsks}");
Dog linqLnsk = dogs.MaxBy(d => d.Weight);
Console.WriteLine($"eredmény maxBy LINQval {linqLnsk.Name}");

DateTime linqLLfkSzd = dogs.Min(d => d.Birth);
Console.WriteLine(  $"eredmény min Linqval: {linqLLfkSzd}yyyy-MM-dd");
Dog linqLfk = dogs.MinBy(d => d.Birth);
Console.WriteLine($"eremnény minBy Linqval: {linqLfk.Name}");

Console.WriteLine("--------------------------------------------------------------");
#endregion
#region Szélső érték meghatározása
dogs.First();
dogs.FirstOrDefault();

dogs.Last();
dogs.LastOrDefault();

dogs.Single();
dogs.SingleOrDefault();

dogs.Any();

//dogs.Find();<--- NEM LINQ

//dogs.FindAll();<--- NEM LINQ

//dogs.Contains(); <--- NEM LINQ

#endregion

//

