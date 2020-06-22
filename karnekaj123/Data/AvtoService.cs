using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace karnekaj123.Data
{
    public class AvtoService
    {
        public ObservableCollection<Avto> seznam = new ObservableCollection<Avto>();

        public List<int> Stevilo()
        {
            List<int> ts = new List<int> { 1, 2, 3, 4, 5 }; 
            return ts;
        }
        public async Task<ObservableCollection<Avto>>GetAvto()
        {
            
            seznam.Add(new Avto { id = 1, znamka = "wv", model = "golf", cena = 12000 });
            return seznam;
        }
    }
}
