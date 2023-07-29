using UnityEditor;

using static UnityEditor.AssetDatabase;
using static UnityEngine.Application;
using static System.IO.Directory;
using static System.IO.Path;

namespace Mato
{
   public static class ToolsMenu
   {
	   [MenuItem("Tools/Setup/Setup Folders")]
	   public static void CreateDefaultFolders()
	   {
		   Dir("_Project", "Scripts", "Prefabs", "Thirdparty");
		   Refresh();
	   }

	   private static void Dir(string root, params string[] dir)
	   {
		   var fullPath = Combine(dataPath, root);
		   
		   foreach (var directory in dir)
			   CreateDirectory(Combine(fullPath, directory));
	   }
   }
}