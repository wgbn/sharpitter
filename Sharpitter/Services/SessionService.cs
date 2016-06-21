using System;
using Sharpitter.Models;
using System.Web.Script.Serialization;
using Sharpitter.Helpers;
using System.Web;

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

		public void SetUsuarioLogado(Usuario _usuario){
			HttpContext.Current.Session ["usuarioLogado"] = _usuario;
		}

		public Usuario GetUsuarioLogado(){
			var uSession = HttpContext.Current.Session ["usuarioLogado"];
			if (uSession != null){
				return (Usuario)uSession;
			}
			return null;
		}

		public void SetUsuarioLogout(){
			HttpContext.Current.Session.RemoveAll();
		}

		public bool IsLogado(){
			var uSession = HttpContext.Current.Session["usuarioLogado"];
			return uSession == null ? false : true;
		}

	}

}