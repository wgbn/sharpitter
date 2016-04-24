using System;
using System.Linq;
using Sharpitter.Models;
using Sharpitter.Helpers;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.IO;

namespace Sharpitter.Services {
	
	public class UsuarioService {

		private readonly MongoDbHelper<Usuario> _users;

		public UsuarioService () {
			_users = new MongoDbHelper<Usuario> ();
		}

		public bool CadastraUsuario(Usuario _usuario){
			_usuario.HashSenha ();
			_users.collection.InsertOne (_usuario);
			return true;
		}

		public bool EditaUsuario(Usuario _usuario){
			var usuarios = _users.db.GetCollection<Usuario> ("usuario");
			usuarios.ReplaceOne (user => user._id == _usuario._id, _usuario);
			return true;
		}

		public bool ExcluiUsuario(Usuario _usuario){
			var usuarios = _users.db.GetCollection<Usuario> ("usuario");
			usuarios.DeleteOne(new BsonDocument ("_id", _usuario._id));
			return true;
		}

		public Usuario GetByUsername(string _username){
			/*var colecao = _users.db.GetCollection<Usuario> ("usuario");
			var query = from usuario in colecao.AsQueryable() where usuario.Username.Equals (_username) select usuario;*/
			return null;
		}

		public Usuario LoginUsuario(Usuario _usuario){
			_usuario.HashSenha();

			try {
				Usuario usuario = _users.collection.Find(new BsonDocument("Username", _usuario.Username)).First<Usuario>();
				if (usuario != null && usuario.Senha.Equals (_usuario.Senha))
					return usuario;
			} catch (Exception e){
				System.Console.WriteLine (e.StackTrace);
			}

			return null;
		}

		public bool VerificaUsuarioExistente(Usuario _usuario){
			try {
				/*var colecao = _users.db.GetCollection<Usuario>("usuario");
				var builder = Builders<Usuario>.Filter;
				var filter = builder.Eq("Username", _usuario.Username) | builder.Eq("Email", _usuario.Email);
				var existente = colecao.Find(filter).ToCursor();*/
				Usuario existeUsername = _users.collection.Find(new BsonDocument("Username", _usuario.Username)).First<Usuario>();
				Usuario existeEmail = _users.collection.Find(new BsonDocument("Email", _usuario.Email)).First<Usuario>();
				if (existeUsername != null || existeEmail != null)
					return true;
			} catch (Exception e){
				System.Console.WriteLine (e.StackTrace);
			}

			return false;
		}

	}

}

