//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DogProjectMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medical
    {
        public int userID { get; set; }
        public string dogName { get; set; }
        public string medName { get; set; }
        public System.DateTime lastDate { get; set; }
        public int dogWeight { get; set; }
        public int dogHeight { get; set; }
    
        public virtual User User { get; set; }
    }
}
