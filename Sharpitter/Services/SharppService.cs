using System;
using System.Linq;
using Sharpitter.Models;
using Sharpitter.Helpers;
using MongoDB.Bson;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Sharpitter.Services {
	
	public class SharppService {

		private readonly MongoDbHelper<Sharpp> _sharpps;
		
		public SharppService () {
			this._sharpps = new MongoDbHelper<Sharpp> ();
		}

		public bool PostSharpp(Sharpp _sharpp){
			this._sharpps.collection.InsertOne (_sharpp);
			return true;
		}

		public bool ExcluiSharpp(Sharpp _sharpp){
			var sharpps = _sharpps.db.GetCollection<Sharpp> ("sharpps");
			sharpps.DeleteOne (new BsonDocument("_id", _sharpp._id));
			return true;
		}

		/*public async Task<List<Sharpp>> GetRecentesAsync(){
			var colecao = _sharpps.db.GetCollection<Sharpp> ("sharpps");
			var filtro = new BsonDocument ();
			var ordem = Builders<Sharpp>.Sort.Descending("Registro");
			var result = await colecao.Find(filtro).Sort(ordem).ToListAsync();

			return result;
		}*/

		public List<Sharpp> GetRecentes(){
			var colecao = _sharpps.collection;
			var ordem = Builders<Sharpp>.Sort.Descending("Registro");
			var sharpps = colecao.Find(new BsonDocument()).Sort(ordem);
			return sharpps.ToList<Sharpp> ();
		}

	}

}