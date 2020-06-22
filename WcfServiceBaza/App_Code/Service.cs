using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Collections.ObjectModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public void DodajAvto(string znamka, string model, int cena)
	{
		using (var db = new AvtoSalonContext())
		{
			db.Configuration.ProxyCreationEnabled = false;
			db.avti.Add(new Avto { znamka = znamka, model = model, cena = cena });
			db.SaveChanges();
		}
	}

	public List<Avto> GetData()
	{
		using (var db = new AvtoSalonContext())
		{
			db.Configuration.ProxyCreationEnabled = false;
			return db.avti.ToList<Avto>();
		}
	}

	public void OdstraniAvto(int id)
	{
		using (var db = new AvtoSalonContext())
		{
			db.Configuration.ProxyCreationEnabled = false;
			foreach (var item in db.avti.ToList())
			{
				if (item.id == id)
				{
					db.avti.Remove(item);
					break;
				}
			}

			db.SaveChanges();
		}
	}

	public void PoosodobiAvto(int id, string Znamka, string model, int cena)
	{
		using (var db = new AvtoSalonContext())
		{
			db.Configuration.ProxyCreationEnabled = false;

			foreach (var item in db.avti.ToList())
			{
				if (item.id == id)
				{
					item.znamka = Znamka;
					item.model = model;
					item.cena = cena;
					break;
				}
			}

			db.SaveChanges();
		}
	}
}
