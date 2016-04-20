using System;
using MongoDB.Driver;
using System.Collections.Generic;

namespace BlogMongoDbLinux
{
	public class PostService
	{
		private readonly MongoHelper<Post> _posts;

		public PostService ()
		{
			_posts = new MongoHelper<Post> ();
		}

		public void Create (Post post)
		{
			//post.Comments = new List<Comment> ();
			_posts.collection.InsertOne (post);
		}
	}
}