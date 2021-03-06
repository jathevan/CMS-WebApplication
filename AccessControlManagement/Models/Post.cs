//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessControlManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public int post_id { get; set; }
        public System.DateTime post_date { get; set; }
        public int user_id { get; set; }
        public Nullable<int> category_id { get; set; }
        public string picture { get; set; }
        public string post_description { get; set; }
        public string activity_log { get; set; }
        public string title { get; set; }
    
        public virtual Advertisement Advertisement { get; set; }
        public virtual Article Article { get; set; }
        public virtual ArticleHasAd ArticleHasAd { get; set; }
        public virtual Category Category { get; set; }
        public virtual user user { get; set; }
    }
}
