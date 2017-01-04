using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitterSearch.iOS
{
	public class EntryRepository : IEntryRepository
	{
		public async Task<IEnumerable<Entry>> TopEntriesAsync()
		{
			var client = new HttpClient();
			var result = await client.


	public interface IEntryRepository
	{
		Task<IEnumerable<Entry>> TopEntriesAsync();
	}
}

