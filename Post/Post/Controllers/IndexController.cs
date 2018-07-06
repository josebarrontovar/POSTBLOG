using Post.DBCache;
using Post.Models;
using Post.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Post.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Home()
        {
            List<PostProp> data;
            using (var db = new DBContext())
            {
               // var x = db.Database.Delete();
                data = db.DBContextSet.ToList();
            }
            return View(data);
        }

        public ActionResult Delete(int ID)
        {
            PostProp response;
            List<PostProp> data;
            using (var db = new DBContext())
            {
                data = db.DBContextSet.ToList();
                response =data.First(s => s.ID == ID);
            }
            return View(response);
        }

        [HttpPost]
        public ActionResult Delete(PostProp obj)
        {
            //DataCache.ListPost.RemoveAll(s => s.ID == obj.ID);
            //return RedirectToAction("Home");
            using (var db = new DBContext())
            {
                var blog = db.DBContextSet.First(p => p.ID == obj.ID);
                db.DBContextSet.Remove(blog);
                db.SaveChanges();
            }
            return RedirectToAction("Home");
        }



        public ActionResult Create()
        {
            return View(new IndexViewModel());
        }

        [HttpPost]
        public ActionResult Create(IndexViewModel obj)
        {
            if (ModelState.IsValid)
            {
                DataCache.ListPost.Add(obj.PostPropVM);
                using (var db = new DBContext())
                {
                    PostProp p = new PostProp
                    {
                        ID = obj.PostPropVM.ID,
                        CustomLoanStarDateTwo=obj.PostPropVM.CustomLoanStarDateTwo,
                        Title = obj.PostPropVM.Title,
                        Description = obj.PostPropVM.Description,
                        CategoryId=obj.PostPropVM.CategoryId
                        

                    };
                    db.DBContextSet.Add(p);
                    db.SaveChanges();
                    
                }
                return RedirectToAction("Home");
            }

            return View(obj);
        }

        public ActionResult Edit(int ID)
        {
            List<PostProp> data;
            PostProp itemPost;
            using (var db = new DBContext())
            {
                // var x = db.Database.Delete();
                data = db.DBContextSet.ToList();
                itemPost = data.First(s => s.ID == ID);
            }
            return View(itemPost);
            //List<PostProp> items = DataCache.ListPost;
            //PostProp itemPost = items.First(s => s.ID == ID);
            //return View(itemPost);
        }

        [HttpPost]
        public ActionResult Edit(PostProp obj)
        {
            List<PostProp> data;
            using (var db = new DBContext())
            {
                data = db.DBContextSet.ToList();
                int index = data.FindIndex(s => s.ID == obj.ID);
                data[index].Title = obj.Title;
                data[index].Description = obj.Description;
                db.SaveChanges();
            }

            return RedirectToAction("Home");
        }
        public ActionResult ContentofPost(PostProp obj)
        {

            List<PostProp> data;
            PostProp itemPost;
            using (var db = new DBContext())
            {
                // var x = db.Database.Delete();
                 data = db.DBContextSet.ToList();
                 itemPost = data.First(s => s.ID == obj.ID);
               
            }
            return View(itemPost);
            //List<PostProp> items = DataCache.ListPost;

            //PostProp itemPost = items.First(s => s.ID == obj.ID);

            //return View(itemPost);
        }

        public ActionResult AddComments(PostProp obj)
        {
            var model = Get();
            return RedirectToAction("ContentofPost",obj);

            

        }
        public List<PostProp> Get()
        {

            return new List<PostProp>
            {
                new PostProp{UserName="JOSE",CommentByUser="1231231"},
                new PostProp{UserName="BARRON",CommentByUser="1231231"}
            };
        }

    }
}