using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;


namespace TestConnectDB
{
	class Operate
	{
		public void Add(DataContext db, string fio, DateTime dateroj, int age, bool pol)
				{
					SotrudnikLite sotr = new SotrudnikLite() { Fio = fio, Age = age, Dater = dateroj, Pol = pol};
					db.Sotrudnik.Add(sotr);
					db.SaveChanges();
				}
	}
	class Program
	{
		
		static void Main(string[] args)
		{
			Operate act = new Operate();

			// Добавление
			using (DataContext db = new DataContext())
			{
				act.Add(db, "Semenov1", DateTime.Now, 34, true);
				SotrudnikLite sotrudnik1 = new SotrudnikLite();
				sotrudnik1.Fio = "Sidorov5";
			    sotrudnik1.Age = 38;
				sotrudnik1.Dater = DateTime.Now;
				sotrudnik1.Pol = true;
				db.Sotrudnik.Add(sotrudnik1);
				db.SaveChanges();



				SotrudnikLite sotrudnik2 = new SotrudnikLite();
				sotrudnik2.Fio = "Sidorov";
				sotrudnik2.Age = 38;
				sotrudnik2.Dater = DateTime.Now;
				db.Sotrudnik.Add(sotrudnik2);
				db.SaveChanges();

				SotrudnikLite sotrudnik3 = new SotrudnikLite() { Fio = "Petrov", Age = 33, Dater = DateTime.Now, Pol = true};
				db.Add(sotrudnik3); 
				db.SaveChanges();

				//Удаление сотрудника по коду PK, например 9
				SotrudnikLite s1 = db.Sotrudnik.SingleOrDefault(s => s.Id == 9);
				if (s1 != null)
				{
					//удаляем объект
					db.Sotrudnik.Remove(s1);
					db.SaveChanges();
				}

				SotrudnikLite s2 = db.Sotrudnik.SingleOrDefault(s => s.Id == 3);
				if (s2 != null)
				{
					s2.Fio = "LavrovUpdate";
					db.SaveChanges();
				}

				//выводим данные после обновления
				var sall = db.Sotrudnik.Where(p => p.Fio == "Lavrov");
				foreach (var s in sall)
				{
					Console.WriteLine($"{s.Id}.{s.Fio} - {s.Age}");
				}
				sall = db.Sotrudnik.Where(p => EF.Functions.Like(p.Fio.ToLower(), "%id%"));
				foreach (var s in sall)
				{
					Console.WriteLine($"{s.Id}.{s.Fio} - {s.Age}");
				}
				Console.WriteLine("HW");
            }
		}
	}
}