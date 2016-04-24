using System;
using Sharpitter.Models;
using System.Web.Script.Serialization;

namespace Sharpitter.Services {
	
	public sealed class SessionService {

		/* SIGLETON */
		private static SessionService instance = null;
		
		private SessionService () { }

		public static SessionService Instance {
			get {
				if (instance == null)
					instance = new SessionService();
				return instance;
			}
		}
		/* SINGLETON */

		private Usuario usuarioLogado = null;

		public void SetUsuarioLogado(Usuario _usuario){
			this.usuarioLogado = _usuario;

			JavaScriptSerializer jss = new JavaScriptSerializer();
			String res = jss.Serialize(this.usuarioLogado);
			res = CriptoHelper.Criptografar (res);
			System.Console.WriteLine (res);
		}

		public Usuario GetUsuarioLogado(){
			return this.usuarioLogado;
		}

		public void SetUsuarioLogout(){
			this.usuarioLogado = null;
		}

		public bool IsLogado(){
			return this.usuarioLogado == null ? false : true;
		}

	}

}