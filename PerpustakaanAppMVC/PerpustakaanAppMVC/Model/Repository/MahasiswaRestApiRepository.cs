using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using PerpustakaanAppMVC.Model.Entity;

namespace PerpustakaanAppMVC.Model.Repository
{
    public class MahasiswaRestApiRepository
    {
		public int Create(Mahasiswa mhs)
		{
			string baseUrl = "http://latihan.coding4ever.net:5555/";
			string endpoint = "api/mahasiswa";

			// membuat objek rest client
			var client = new RestClient(baseUrl);

			// membuat objek request
			var request = new RestRequest(endpoint, Method.POST);

			request.AddJsonBody(mhs);

			// kirim request ke server
			var response = client.Execute(request);
			var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

			return result;
		}

		public int Update(Mahasiswa mhs)
		{
			throw new NotImplementedException();
		}

		public int Delete(Mahasiswa mhs)
		{
			throw new NotImplementedException();
		}

		public List<Mahasiswa> ReadAll()
		{
			string baseUrl = "http://latihan.coding4ever.net:5555/";
			string endpoint = "api/mahasiswa";

			// membuat objek rest client
			var client = new RestClient(baseUrl);

			// membuat objek request
			var request = new RestRequest(endpoint, Method.GET);

			// kirim request ke server
			var response = client.Execute<List<Mahasiswa>>(request);

			return response.Data;
		}

		public List<Mahasiswa> ReadByNama(string nama)
		{
			string baseUrl = "http://latihan.coding4ever.net:5555/";
			string endpoint = "api/mahasiswa?nama="+nama;

			// membuat objek rest client
			var client = new RestClient(baseUrl);

			// membuat objek request
			var request = new RestRequest(endpoint, Method.GET);

			// kirim request ke server
			var response = client.Execute<List<Mahasiswa>>(request);

			return response.Data;
		}

		public Mahasiswa ReadByNpm(string npm)
		{
			throw new NotImplementedException();
		}
	}
}
