using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for RSSItem
/// </summary>
public class RSSItem
{
#region Required item elements

#endregion

#region Optional item elements
    public string title { get; set; }
    public string link { get; set; }
    public string description { get; set; }
    public string author { get; set; }
    public string category { get; set; }
    public string comments { get; set; }
    public string enclosure { get; set; }
    public string guid { get; set; }
    public string pubDate { get; set; }
    public string source { get; set; }

#endregion

#region Constructors
    public RSSItem()
    {
        this.title = "";
        this.link = "";
        this.description = "";
        this.author = "";
        this.category = "";
        this.comments = "";
        this.enclosure = "";
        this.guid = "";
        this.pubDate = "";
        this.source = "";
    }
#endregion

#region Public Methords

    /// <summary>
    /// validate the current item
    /// </summary>
    /// <returns>TRUE : item is valid
    /// FALSE : item is invalid</returns>
    public bool isValid()
    {
        if ((title.Length == 0) && (description.Length == 0))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string ToString()
    {

        StringBuilder outString = new StringBuilder();

        if (isValid())
        {
            outString.AppendLine("<item>");
            if (title.Length != 0)
            {
                outString.Append("<title>");
                outString.Append(title);
                outString.AppendLine("</title>");
            }

            if (link.Length != 0)
            {
                outString.Append("<link>");
                outString.Append(link);
                outString.AppendLine("</link>");
            }

            if (description.Length != 0)
            {
                outString.Append("<description>");
                outString.Append(description);
                outString.AppendLine("</description>");
            }


            if (author.Length != 0)
            {
                outString.Append("<author>");
                outString.Append(author);
                outString.AppendLine("</author>");
            }


            if (category.Length != 0)
            {
                outString.Append("<category>");
                outString.Append(category);
                outString.AppendLine("</category>");
            }


            if (comments.Length != 0)
            {
                outString.Append("<comments>");
                outString.Append(comments);
                outString.AppendLine("</comments>");
            }

            if (enclosure.Length != 0)
            {
                outString.Append("<enclosure>");
                outString.Append(enclosure);
                outString.AppendLine("</enclosure>");
            }

            if (guid.Length != 0)
            {
                outString.Append("<guid>");
                outString.Append(guid);
                outString.AppendLine("</guid>");
            }


            if (pubDate.Length != 0)
            {
                outString.Append("<pubDate>");
                outString.Append(pubDate);
                outString.AppendLine("</pubDate>");
            }

            if (source.Length != 0)
            {
                outString.Append("<source>");
                outString.Append(source);
                outString.AppendLine("</source>");
            }

            outString.AppendLine("</item>");

        }
        else
        {
            // hide the broken items, this should help with debugging
            //   As long as we only hide the items.
            outString.Clear();
        }


        return outString.ToString();


    }

#endregion

#region Private Methords

#endregion
}
