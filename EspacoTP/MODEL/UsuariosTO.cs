using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace EspacoTP.MODEL
{
	[Serializable]
	[XmlRoot(ElementName = "Usuarios")]
	public class UsuariosTO
	{
		#region Attributes

		private int _idUsuario;
        private string _nome;
        private string _usuario;
		private string _senha;
		private int _idTipoUsuario;
		private int _ativo;

		#endregion

		#region Properties

		[XmlElement(ElementName = "IdUsuario")]
		public int IdUsuario
		{
			get { return _idUsuario; }
			set { _idUsuario = value; }
		}

        [XmlElement(ElementName = "Nome")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        [XmlElement(ElementName = "Usuario")]
		public string Usuario
		{
			get { return _usuario; }
			set { _usuario = value; }
		}

		[XmlElement(ElementName = "Senha")]
		public string Senha
		{
			get { return _senha; }
			set { _senha = value; }
		}

		[XmlElement(ElementName = "IdTipoUsuario")]
		public int IdTipoUsuario
		{
			get { return _idTipoUsuario; }
			set { _idTipoUsuario = value; }
		}

		[XmlElement(ElementName = "Ativo")]
		public int Ativo
		{
			get { return _ativo; }
			set { _ativo = value; }
		}
        
		#endregion

		#region Constructors
        
		#endregion

		#region Methods

		#endregion

	}
}