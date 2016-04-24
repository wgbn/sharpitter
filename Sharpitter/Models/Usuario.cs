using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Sharpitter.Services;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI.WebControls;

namespace Sharpitter.Models {
	
	public class Usuario : IModel {
		
		[NotMapped]
		public ObjectId _id { get; set; }

		[Required, DataType(DataType.Text)]
		public string Nome { get; set; }

		[Required, DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required, DataType(DataType.Text)]
		public string Username { get; set; }

		[Required, DataType(DataType.Password)]
		public string Senha { get; set; }

		[Required, DataType(DataType.DateTime)]
		public DateTime Registro { get; set; }

		public List<Usuario> Seguindo { get; set; }

		public bool Save(){
			UsuarioService us = new UsuarioService ();
			if (this._id.Increment == 0 && this._id.Machine == 0 && this._id.Pid == 0 && this._id.Timestamp == 0)
				us.CadastraUsuario (this);
			else
				us.EditaUsuario (this);

			return true;
		}
			
		public bool Delete(){
			UsuarioService us = new UsuarioService ();
			us.ExcluiUsuario (this);
			return true;
		}

		public void HashSenha(){
			HashAlgorithm algorithm = SHA1.Create();
			var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(this.Senha));

			StringBuilder sb = new StringBuilder();
			foreach (byte b in hash)
				sb.Append(b.ToString("X2"));

			this.Senha = sb.ToString();
		}

	}

}