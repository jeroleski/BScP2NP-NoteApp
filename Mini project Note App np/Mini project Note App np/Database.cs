using Microsoft.Maui.Devices.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Mini_project_Note_App_np
{
    public class Database
        {
            public static Database Instance { set; get; } = new Database();
            public Dictionary<string, Category> Categories { set; get; } = new Dictionary<string, Category>();

            private Database()
            {
                Categories.Add("School", new Category("School",
                    new Node("BDSA", "Helge er cool")));
                Categories.Add("hmm", new Category("hmm",
                    new Node("Navy Seals", "What the fuck"),
                    new Node("Memes", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."),
                    new Node("top 5 porn sites", "XVideos, PornHub, MILFs.dk, AlexErHot.us, Reddit"),
                    new Node("buddy application", "hej hej du")));
                Categories.Add("(*_*)", new Category("(*_*)",
                    new Node(";)", ";);););)"),
                    new Node(":-D", ":-D :-D :-D :-D")));
                Categories.Add("Stuff i should remember", new Category("Stuff i should remember",
                    new Node("nothing", "")));
                Categories.Add("Workouts", new Category("Workouts",
                    new Node("pull", "remember to do pullups")));
            }

            public void DeleteCategory(string name)
            {
                Categories.Remove(name);
            }

            public void NewCategory(string name)
            {
                Categories.Add(name, new Category(name));
            }

        }

        public class Category
        {
            public string Name { set; get; }
            public Dictionary<string, Node> Nodes { set; get; } = new Dictionary<string, Node>();

            public Category(string name, params Node[] nodes)
            {
                Name = name;
                foreach (var n in nodes)
                {
                    Nodes.Add(n.Name, n);
                }
            }

            public void DeleteNode(string name)
            {
                Nodes.Remove(name);
            }

            public void NewNode(string name)
            {
                Nodes.Add(name, new Node(name, ""));
            }
        }

        public class Node
        {
            public string Name { set; get;}
            public string Text { set; get; }

            public Node(string name, string text)
            {
                Name = name;
                Text = text;
            }
    }
}
