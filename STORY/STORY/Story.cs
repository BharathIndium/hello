using System.Collections.Generic;

namespace STORY
{
    class Story
    {
        string name;
        string authorname;
        string gen;
        int Chapters;
        int Likes;
        int Reads;

        public Story(string name, string authorname, string gen, int chapters, int likes, int reads)
        {
            this.name = name;
            this.authorname = authorname;
            this.gen = gen;
            Chapters = chapters;
            Likes = likes;
            Reads = reads;
        }

        public string Name { get => name; set => name = value; }
        public string Authorname { get => authorname; set => authorname = value; }
        public string Gen { get => gen; set => gen = value; }
        public int Chapters1 { get => Chapters; set => Chapters = value; }
        public int Likes1 { get => Likes; set => Likes = value; }
        public int Reads1 { get => Reads; set => Reads = value; }

        public static void genreWiseCount(List<Story> list)
        {

        }
        public override string ToString()
        {
            return string.Format("{0,15}", Gen);

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}