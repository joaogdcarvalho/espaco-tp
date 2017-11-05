using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace estudio_tp.Model
{
	[Serializable]
	[XmlRoot(ElementName = "Agendamentos")]
	public class AgendamentosTO
	{
		#region Attributes

		private int _idAgendamento;
		private int _idInstrutor;
		private int _idAluno;
        private DateTime _dataAgendamento;
        private int _idHorarioAgendamento;
		private int _ativo;

		#endregion

		#region Properties

		[XmlElement(ElementName = "IdAgendamento")]
		public int IdAgendamento
		{
			get { return _idAgendamento; }
			set { _idAgendamento = value; }
		}
		
		[XmlElement(ElementName = "IdInstrutor")]
		public int IdInstrutor
		{
			get { return _idInstrutor; }
			set { _idInstrutor = value; }
		}

		[XmlElement(ElementName = "IdAluno")]
		public int IdAluno
		{
			get { return _idAluno; }
			set { _idAluno = value; }
		}

		[XmlElement(ElementName = "DataAgendamento")]
		public DateTime DataAgendamento
		{
			get { return _dataAgendamento; }
			set { _dataAgendamento = value; }
		}

		[XmlElement(ElementName = "IdHorarioAgendamento")]
		public int IdHorarioAgendamento
        {
			get { return _idHorarioAgendamento; }
			set { _idHorarioAgendamento = value; }
		}

		[XmlElement(ElementName = "Ativo")]
		public int Ativo
		{
			get { return _ativo; }
			set { _ativo = value; }
		}               

		#endregion

		#region Constructors

		public AgendamentosTO()
		{
		}

		#endregion

		#region Methods

		#endregion

	}
}