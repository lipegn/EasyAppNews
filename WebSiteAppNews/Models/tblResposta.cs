//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteAppNews.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblResposta
    {
        public tblResposta()
        {
            this.tblEnqueteResposta = new HashSet<tblEnqueteResposta>();
            this.tblEnqueteRespostaUsuario = new HashSet<tblEnqueteRespostaUsuario>();
        }
    
        public int CodResposta { get; set; }
        public string DescResposta { get; set; }
    
        public virtual ICollection<tblEnqueteResposta> tblEnqueteResposta { get; set; }
        public virtual ICollection<tblEnqueteRespostaUsuario> tblEnqueteRespostaUsuario { get; set; }
    }
}
