using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	List<Avto> GetData();
	[OperationContract]
	void DodajAvto(string znamka, string model, int cena);
	[OperationContract]
	void OdstraniAvto(int id);
	[OperationContract]
	void PoosodobiAvto(int id, string Znamka, string model, int cena);

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class Avto
{
	[DataMember]
	public int id { get; set;}
	[DataMember]
	public string znamka { get; set; }
	[DataMember]
	public string model { get; set; }
	[DataMember]
	public int cena { get; set; }

}


class AvtoSalonContext: DbContext
{
	[DataMember]
	public DbSet<Avto> avti{ get; set; }

}