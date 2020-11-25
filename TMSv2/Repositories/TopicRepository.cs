using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMSv2.Models;
using TMSv2.Repositories.Interface;

namespace TMSv2.Repositories
{
	public class TopicRepository : ITopicRepository 
	{
		private ApplicationDbContext _context;

		public TopicRepository()
		{
			_context = new ApplicationDbContext();
		}

		public IEnumerable<Topic> GetAllTopics()
		{
			return _context.Topics; //Get all topic in database
		}
		public IEnumerable<Topic> GetAllTopicsWithSearch(string search)
		{
			IEnumerable<Topic> topics = GetAllTopics(); //Topic == 
			return topics.Where(t => t.Name.Contains(search)); //Get all topic which has name (database) == search name
		}
		public void CreateTopic(Topic topic)
		{
			var newTopic = new Topic //newTopic = Topic Object in Topic model
			{
				Name = topic.Name,
				Description = topic.Description
			};
			_context.Topics.Add(newTopic); //Add new topic 
			_context.SaveChanges(); //Save
		}

		public bool CheckExistTopicName(string name)
		{
			return _context.Topics.Any(p => p.Name.Contains(name)); //return True if name is Existed
		}


	}
}