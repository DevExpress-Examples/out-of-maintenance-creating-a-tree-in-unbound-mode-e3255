using System;
using System.Windows;
using DevExpress.Xpf.Grid;

namespace DXTreeList_UnboundMode {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            BuildTree();
            treeListView1.ExpandAllNodes();
        }

        private void BuildTree() {
            TreeListNode rootNode = CreateRootNode(new ProjectObject() { Name = "Project: Stanton", Executor = "Nicholas Llams" });
            TreeListNode childNode = CreateChildNode(rootNode, new StageObject() { Name = "Information Gathering", Executor = "Ankie Galva" });
            CreateChildNode(childNode, new TaskObject() { Name = "Design", Executor = "Reardon Felton", State = "In progress" });
        }

        private TreeListNode CreateRootNode(object dataObject) {
            TreeListNode rootNode = new TreeListNode(dataObject);
            treeListView1.Nodes.Add(rootNode);
            return rootNode;
        }

        private TreeListNode CreateChildNode(TreeListNode parentNode, object dataObject) {
            TreeListNode childNode = new TreeListNode(dataObject);
            parentNode.Nodes.Add(childNode);
            return childNode;
        }
    }

    public class StageObject {
        public String Name { get; set; }
        public string Executor { get; set; }
    }

    public class ProjectObject {
        public String Name { get; set; }
        public string Executor { get; set; }
    }

    public class TaskObject {
        public String Name { get; set; }
        public string Executor { get; set; }
        public string State { get; set; }
    }
}
