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

		//private Usuario usuarioLogado = null;

		public void SetUsuarioLogado(Usuario _usuario){
			//this.usuarioLogado = _usuario;

			/*JavaScriptSerializer jss = new JavaScriptSerializer();
			String res = jss.Serialize(_usuario);
			res = CriptoHelper.Criptografar (res);*/
			HttpContext.Current.Session ["usuarioLogado"] = _usuario;
		}

		public Usuario GetUsuarioLogado(){
			//return this.usuarioLogado;
			var uSession = HttpContext.Current.Session ["usuarioLogado"];
			if (uSession != null){
				/*JavaScriptSerializer jss = new JavaScriptSerializer();
				string uJson = CriptoHelper.Descriptografar (uSession.ToString());
				Usuario usuario = (Usuario)jss.DeserializeObject (uJson);
				return usuario;*/
				return (Usuario)uSession;
			}
			return null;
		}

		public void SetUsuarioLogout(){
			//this.usuarioLogado = null;
			HttpContext.Current.Session.RemoveAll();
		}

		public bool IsLogado(){
			var uSession = HttpContext.Current.Session["usuarioLogado"];
			return uSession == null ? false : true;
		}

	}

}