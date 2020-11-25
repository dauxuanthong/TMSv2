using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMSv2.Models;
using TMSv2.Repositories.Interface;

namespace TMSv2.Controllers
{
    public class TopicsController : Controller
    {
        private ITopicRepository _topicRepos;

        public TopicsController(ITopicRepository topicRepos)
        {
            _topicRepos = topicRepos;
        }

        //Get: Topic
        [HttpGet]
        public ActionResult Index(string search)
        {
            //if it not nullOrEmpty
            if (!String.IsNullOrEmpty(search))
            {
                return View(_topicRepos.GetAllTopicsWithSearch(search).ToList());
            }
            return View(_topicRepos.GetAllTopics().ToList());
        }

        //Create: Topic
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Topic topic)
		{

            if (!ModelState.IsValid)
			{
                return View();
			}
            //Check is exist name and show error
            if (_topicRepos.CheckExistTopicName(topic.Name))
			{
                ModelState.AddModelError("Name", "Topic Name Already Exist");
			}
            //create new topic 
            _topicRepos.CreateTopic(topic);
            return RedirectToAction("Index");
		}
    }
}