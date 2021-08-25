using Geotab.Checkmate;
using Geotab.Checkmate.ObjectModel;
using KnockoutJs.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KnockoutJs.Repositories.Descretes
{
    public class ApiRepository : IApiRepository
    {
        private API _api;

        public bool Aunthenticate(API api)
        {
            try
            {
                _api = api;
                var user = GetUserByName(_api.UserName);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetUserByName(string name)
        {
            return _api.CallAsync<List<User>>("Get", typeof(User), new
            {
                search = new UserSearch
                {
                    Name = name
                }
            }).Result.FirstOrDefault();
        }

        public Zone GetZoneByName(string name)
        {
            return _api.CallAsync<List<Zone>>("Get", typeof(Zone), new
            {
                search = new ZoneSearch
                {
                    Name = name
                }
            }).Result.FirstOrDefault();
        }

        public IEnumerable<Zone> GetZones()
        {
            return _api.CallAsync<List<Zone>>("Get", typeof(Zone)).Result;

        }
    }
}
