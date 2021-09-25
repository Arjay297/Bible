using Bible.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Bible.Services.Contracts
{
    public interface IPastorService
    {
        ObservableCollection<Pastor> GetPastors();
        Pastor GetPastorById(string id);
    }
}
