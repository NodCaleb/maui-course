using System.Diagnostics;
using System.Text;

namespace NavigationDemo.Utilities;

public static class NavUtilities
{
    public static void Examine(INavigation navigation)
    {
        var sb = new StringBuilder();

        foreach (var page in navigation.NavigationStack)
        {
            if (page is null)
            {
                sb.AppendLine("Null page");
                continue;
            }
            sb.AppendLine(page.GetType().Name);
        }
        sb.AppendLine("------------------");
        Debug.WriteLine(sb.ToString());
    }
}
