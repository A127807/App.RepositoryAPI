using App.Repository.ApiClient;
using MilSiteCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
	public class LocationRepository
	{
		private readonly IWebApiExecuter _webApiExectuter;

		public LocationRepository(IWebApiExecuter webApiExectuter)
		{
			this._webApiExectuter = webApiExectuter;
		}

		public async Task<IEnumerable<Location>> Get()
		{
			return await _webApiExectuter.InvokeGet<IEnumerable<Location>>("api/locations");
		}
		public async Task<IEnumerable<Location>> GetLocationById(int id)
		{
			return await _webApiExectuter.InvokeGet<IEnumerable<Location>>("api/locations/{id}");
		}

	}
}
