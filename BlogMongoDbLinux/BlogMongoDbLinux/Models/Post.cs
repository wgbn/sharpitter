using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace BlogMongoDbLinux.Models {
	public class Post {
		[ScaffoldColumn (false)]
		[BsonId]
		public ObjectId PostId { get; set; }

		[ScaffoldColumn (false)]
		public DateTime Date { get; set; }

		[Required, DisplayName ("Título")]
		public string Title { get; set; }

		[ScaffoldColumn (false)]
		public string Url { get; set; }

		[Required, DisplayName ("Resumo")]
		public string Summary { get; set; }

		[UIHint ("WYSIWYG")]
		[AllowHtml, DisplayName ("Texto")]
		public string Details { get; set; }

		[DisplayName ("Autor")]
		public string Author { get; set; }

		[ScaffoldColumn (false)]
		public int TotalComments { get; set; }

		/*[ScaffoldColumn (false)]
		public IList<Comment> Comments { get; set; }*/
	}
}

