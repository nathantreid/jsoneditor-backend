﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JsonEditor_Backend.API.Models;
using JsonEditor_Backend.API.Repositories;

namespace JsonEditor_Backend.API.Controllers
{
    public class DocumentsController : ApiController
    {
        private readonly IDocumentsRepository documentsRepository;

        public DocumentsController(IDocumentsRepository documentsRepository)
        {
            this.documentsRepository = documentsRepository;
        }

        // GET api/documents
        public List<Document> Get()
        {
            return documentsRepository.GetAll();
        }

        // GET api/documents/5
        public Document Get(int id)
        {
            return documentsRepository.Get(id);
        }

        // POST api/documents
        public int Post(Document document)
        {
            return documentsRepository.Add(document);
        }

        // PUT api/documents/5
        public void Put(int id, Document document)
        {
            document.Id = id;
            documentsRepository.Update(document);
        }

        // DELETE api/documents/5
        public void Delete(int id)
        {
            documentsRepository.Delete(id);
        }
    }
}
