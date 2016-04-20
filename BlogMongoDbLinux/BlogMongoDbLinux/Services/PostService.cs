using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using BlogMongoDbLinux.Helpers;
using BlogMongoDbLinux.Models;
using System.Collections.ObjectModel;
using System.Web.Configuration;

namespace BlogMongoDbLinux.Services {
	public class PostService {
		private readonly MongoHelper<Post> _posts;

		public PostService () {
			_posts = new MongoHelper<Post> ();
		}

		public void Create (Post post) {
			_posts.collection.InsertOne (post);
		}

		public void Delete(string id){
			var colecao = _posts.db.GetCollection<Post> ("post");
			colecao.DeleteOne(p => p.PostId == new ObjectId(id));
		}

		public List<Post> GetPosts () {
			var colecao = _posts.collection;
			var postes = colecao.Find (new BsonDocument ());
			return postes.ToList<Post> ();
		}
	}
}