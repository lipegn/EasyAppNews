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
    
    public partial class tblEnqueteResposta
    {
        public int CodEnqueteResposta { get; set; }
        public int CodEnquete { get; set; }
        public int CodResposta { get; set; }
    
        public virtual tblEnquete tblEnquete { get; set; }
        public virtual tblResposta tblResposta { get; set; }
    }
}
