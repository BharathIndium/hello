using System;
using System.Collections.Generic;

namespace STORY
{
    class search
    {


        public List<Story> findStory(List<Story> jobList, String authorname)
        {

            List<Story> result = new List<Story>();
            foreach (var item in jobList)
            {
                if (item.Authorname.Equals(authorname))
                {

                    result.Add(item);

                }
            }

            return result;

        }
        public List<Story> findStory(List<Story> jobList, int Likes)

        {
            List<Story> result = new List<Story>();
            foreach (var item in jobList)
            {
                if (item.Likes1 >= Likes)
                {
                    result.Add(item);
                }
            }
            return result;
        }


    }
}
