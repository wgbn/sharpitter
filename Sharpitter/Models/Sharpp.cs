using System;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Win32;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Sharpitter.Services;

namespace Sharpitter.Models {
	
	public class Sharpp : IModel {

		[NotMapped]
		public ObjectId _id { get; set; }

		[Required, DataType(DataType.Text)]
		public string Autor { get; set; }

		[Required, DataType(DataType.MultilineText)]
		public string Texto { get; set; }

		[Required, DataType(DataType.DateTime)]
		public DateTime Registro { get; set; }

		public int Like { get; set; }

		public ObjectId Resposta { get; set; }

		public bool Save(){
			SharppService ss = new SharppService ();
			ss.PostSharpp (this);
			return true;
		}

		public bool Delete(){

			return true;
		}

	}

}