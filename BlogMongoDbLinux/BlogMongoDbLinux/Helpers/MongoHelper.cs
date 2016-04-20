using System;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BlogMongoDbLinux
{
	public class MongoHelper<T> where T : class
	{
		/*private MongoServer server;
		private MongoDatabase db;*/

		protected static IMongoClient _client;
		protected static IMongoDatabase _database;

		public IMongoCollection<T> collection { get; private set; }

		public MongoHelper ()
		{
			/*MongoServerSettings settings = new MongoServerSettings ();
			settings.Server = new MongoServerAddress ("mongodb://localhost/");
			server = new MongoServer (settings); //.Create("mongodb://127.0.0.1");
			db = server.GetDatabase ("blog");
			collection = db.GetCollection<T> (typeof(T).Name.ToLower ());*/

			_client = new MongoClient ();
			_database = _client.GetDatabase ("blog");
			collection = _database.GetCollection<T> (typeof(T).Name.ToLower ());
		}
	}
}

