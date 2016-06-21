using System;
using MongoDB.Driver;

namespace Sharpitter.Helpers {
	
	public class MongoDbHelper<T> where T : class {

		protected static MongoClient _client;
		public IMongoDatabase db;

		public IMongoCollection<T> collection { get; private set; }

		public MongoDbHelper (){
			_client = new MongoClient ();
			db = _client.GetDatabase ("sharpitter");
			collection = db.GetCollection<T> (typeof(T).Name.ToLower ());
		}
	}

}