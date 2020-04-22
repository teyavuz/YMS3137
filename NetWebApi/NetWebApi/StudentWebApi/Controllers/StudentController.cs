using StudentWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentWebApi.Controllers
{
    public class StudentController : ApiController
    {
        StudentDBEntities db = new StudentDBEntities();

        //Get
        public IEnumerable<Student> Get()
        {
            return db.Students.ToList();
        }

        //public Student Get(int id)
        //{
        //    return db.Students.FirstOrDefault(x => x.ID == id);
        //}

        /*
         HttpResponseMessage Kullanımı
          HttpResponseMessage döndüren metotlar gelen isteğin fiiline göre Get, Post,Put Delete ile kullanılırlar. Kaynağa ulaşıldığında HttpStatus Code ve HttpResponse Message olarak xml ve json formatlarından biri halinde veri istemciye gönderilir.
          Returntype metotlardan farkı erişilen kaynakları işleme göre HttpStatusCode döndürebilir veya response olarak taşınacak verinin medya tipini belirleyebilirsiniz.
            */

            //Get
        public HttpResponseMessage Get(int id)
        {
            Student student = db.Students.FirstOrDefault(x => x.ID == id);
            if (student != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, student);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı bir öğrenci bulunamadı");
            }
        }

        //Post
        public HttpResponseMessage Post(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, student);
            return response;
        }

        //Put
        public HttpResponseMessage Put(int id,Student student)
        {
            Student updated = db.Students.FirstOrDefault(x => x.ID == id);
            if (updated != null)
            {
                updated.FirstName = student.FirstName;
                updated.LastName = student.LastName;
                updated.Gender = student.Gender;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, $"{id} numaralı öğrenci güncellendi");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı öğrenci bulunamadı");
            }
        }

        //Delete

        public HttpResponseMessage Delete(int id)
        {
            Student deleted = db.Students.FirstOrDefault(x => x.ID == id);
            if (deleted != null)
            {
                db.Students.Remove(deleted);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} nolu öğrenci bulunamadı");
            }
        }

    }
}
