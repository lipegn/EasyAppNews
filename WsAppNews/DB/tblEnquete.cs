//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WsAppNews.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEnquete
    {
        public tblEnquete()
        {
            this.tblEnqueteResposta = new HashSet<tblEnqueteResposta>();
            this.tblEnqueteRespostaUsuario = new HashSet<tblEnqueteRespostaUsuario>();
        }
    
        public int CodEnquete { get; set; }
        public int CodEnqueteTipo { get; set; }
        public string DescEnquete { get; set; }
        public string PerguntaEnquete { get; set; }
        public bool FlagAtivo { get; set; }
    
        public virtual tblEnqueteTipo tblEnqueteTipo { get; set; }
        public virtual ICollection<tblEnqueteResposta> tblEnqueteResposta { get; set; }
        public virtual ICollection<tblEnqueteRespostaUsuario> tblEnqueteRespostaUsuario { get; set; }
    }
}
