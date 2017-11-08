using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace estudio_tp.Model
{
	[Serializable]
	[XmlRoot(ElementName = "Periodos")]
	public class PeriodosTO
	{
		#region Attributes

		private int _idPeriodo;
		private int _idAluno;
		private int _idDiaAgendamento;
        private int _idHoraAgendamento;
        private int _ativo;

		#endregion

		#region Properties

		[XmlElement(ElementName = "IdPeriodo")]
		public int IdPeriodo
        {
			get { return _idPeriodo; }
			set { _idPeriodo = value; }
		}

		[XmlElement(ElementName = "IdAluno")]
		public int IdAluno
        {
			get { return _idAluno; }
			set { _idAluno = value; }
		}

		[XmlElement(ElementName = "IdDiaAgendamento")]
		public int IdDiaAgendamento
        {
			get { return _idDiaAgendamento; }
			set { _idDiaAgendamento = value; }
		}

		[XmlElement(ElementName = "IdHoraAgendamento")]
		public int IdHoraAgendamento
        {
			get { return _idHoraAgendamento; }
			set { _idHoraAgendamento = value; }
		}

        [XmlElement(ElementName = "Ativo")]
        public int Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        #endregion

        #region Constructors

        public PeriodosTO()
		{
		}

		#endregion

		#region Methods

		#endregion

	}
}