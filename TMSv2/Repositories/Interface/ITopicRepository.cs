using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSv2.Models;

namespace TMSv2.Repositories.Interface
{
	public interface ITopicRepository
	{
		IEnumerable<Topic> GetAllTopics(); //Get: Topic [TopicsController]
		IEnumerable<Topic> GetAllTopicsWithSearch(string search); //Get: Topic [TopicsController]
		void CreateTopic(Topic topic);//use to Create topic
		bool CheckExistTopicName(string name);// use to check name is Exits
		/*void EditTopic(Topic topic);//use to Edit topic 
		void  */
	}
}
