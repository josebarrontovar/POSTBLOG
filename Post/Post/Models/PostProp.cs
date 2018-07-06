using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Post.Models
{
    public class PostProp
    {
        public int ID { get;set;
            //get
            //{
            //    Random x = new Random();
               
            //    bool operation = true;
            //    if (operation)
            //    {
            //        DateTime date = DateTime.Now;
            //        string dateFormat = String.Format("{0:MM/dd/yyyy}", date);
            //        return x.Next(0, 1000000); ;
            //    }
            //    return 0;
           // }
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public string UserName { get; set; }
        public string CommentByUser { get; set; }
        public string UserID { get; set; }




        public string CustomLoanStarDateTwo
        {
            get
            {
                bool operation=true;
                if (operation)
                {
                    DateTime date = DateTime.Now;
                   string dateFormat= String.Format("{0:MM/dd/yyyy}", date);
                    return dateFormat;
                }
                return null;
            }
            set { }
        }



    }
}