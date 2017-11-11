using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace EspacoTP.MODEL
{
    [Serializable]
    [XmlRoot(ElementName = "Alunos")]
    public class AlunosTO
    {
        #region Attributes

        private int _idAluno;
        private string _nome;
        private string _sobrenome;
        private string _cpf;
        private int _idTipoTelefone;

        private string _numeroTelefone;
        private string _email;
        private DateTime _dataInicioContrato;
        private DateTime _dataTerminoContrato;
        private DateTime _dataTerminoContratoAnterior;
        private string _cep;

        private string _logradouro;
        private string _numeroResidencial;
        private string _bairro;
        private string _estado;
        private string _municipio;

        private decimal _valorAula;

        //private List<AgendamentosTO> _Agendamentos;

        #endregion

        #region Properties

        [XmlElement(ElementName = "IdAluno")]
        public int IdAluno
        {
            get { return _idAluno; }
            set { _idAluno = value; }
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

        [XmlElement(ElementName = "IdTipoTelefone")]
        public int IdTipoTelefone
        {
            get { return _idTipoTelefone; }
            set { _idTipoTelefone = value; }
        }

        [XmlElement(ElementName = "NumeroTelefone")]
        public string NumeroTelefone
        {
            get { return _numeroTelefone; }
            set { _numeroTelefone = value; }
        }

        [XmlElement(ElementName = "Email")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [XmlElement(ElementName = "DataInicioContrato")]
        public DateTime DataInicioContrato
        {
            get { return _dataInicioContrato; }
            set { _dataInicioContrato = value; }
        }

        [XmlElement(ElementName = "DataTerminoContrato")]
        public DateTime DataTerminoContrato
        {
            get { return _dataTerminoContrato; }
            set { _dataTerminoContrato = value; }
        }

        [XmlElement(ElementName = "DataTerminoContratoAnterior")]
        public DateTime DataTerminoContratoAnterior
        {
            get { return _dataTerminoContratoAnterior; }
            set { _dataTerminoContratoAnterior = value; }
        }

        [XmlElement(ElementName = "Cep")]
        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        [XmlElement(ElementName = "Logradouro")]
        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        [XmlElement(ElementName = "NumeroResidencial")]
        public string NumeroResidencial
        {
            get { return _numeroResidencial; }
            set { _numeroResidencial = value; }
        }

        [XmlElement(ElementName = "Bairro")]
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        [XmlElement(ElementName = "Estado")]
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        [XmlElement(ElementName = "Municipio")]
        public string Municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }

        [XmlElement(ElementName = "ValorAula")]
        public decimal ValorAula
        {
            get { return _valorAula; }
            set { _valorAula = value; }
        }

        /*
		[XmlElement(ElementName = "Agendamentos")]
		public List<AgendamentosTO> Agendamentos
		{
			get { return _Agendamentos; }
			set { _Agendamentos = value; }
		}	
        */

        #endregion

        #region Constructors
        /*
         public AlunosTO()
         {
        this.Agendamentos = new List<AgendamentosTO>();
        }
        */
        #endregion

        #region Methods

        #endregion

    }
}