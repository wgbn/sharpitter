using System;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BlogMongoDbLinux.Helpers {
	public class MongoHelper<T> where T : class {
		
		protected static MongoClient _client;
		public IMongoDatabase db;

		public IMongoCollection<T> collection { get; private set; }

		public MongoHelper (){
			_client = new MongoClient ();
			db = _client.GetDatabase ("blog");
			collection = db.GetCollection<T> (typeof(T).Name.ToLower ());
		}
	}
}

