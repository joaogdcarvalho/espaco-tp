using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace EspacoTP.MODEL
{
	[Serializable]
	[XmlRoot(ElementName = "Instrutores")]
	public class InstrutoresTO
	{
		#region Attributes

		private int _idInstrutor;
		private string _nome;
		private string _sobrenome;
		private string _cpf;
		private int _ativo;
        
		#endregion

		#region Properties

		[XmlElement(ElementName = "IdInstrutor")]
		public int IdInstrutor
		{
			get { return _idInstrutor; }
			set { _idInstrutor = value; }
		}

		[XmlElement(ElementName = "Nome")]
		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		[XmlElement(ElementName = "Sobrenome")]
		public string Sobrenome
		{
			get { return _sobrenome; }
			set { _sobrenome = value; }
		}

		[XmlElement(ElementName = "Cpf")]
		public string Cpf
		{
			get { return _cpf; }
			set { _cpf = value; }
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