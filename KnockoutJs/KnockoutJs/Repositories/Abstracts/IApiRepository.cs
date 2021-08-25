using Geotab.Checkmate;
using Geotab.Checkmate.ObjectModel;
using System.Collections.Generic;

namespace KnockoutJs.Repositories.Abstracts
{
    public interface IApiRepository
    {
        bool Aunthenticate(API api);
        User GetUserByName(string name);
        IEnumerable<Zone> GetZones();
        Zone GetZoneByName(string name);
    }
}
