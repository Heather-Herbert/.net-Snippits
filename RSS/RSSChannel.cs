using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for RSSChannel
/// </summary>
public class RSSChannel
{

#region Required channel elements
	public string title { get; set; }
    public string link { get; set; }
    public string description { get; set; }
#endregion

#region Optional channel elements
    public string language { get; set; }
    public string copyright { get; set; }
    public string managingEditor { get; set; }
    public string webMaster { get; set; }
    public string pubDate { get; set; }
    public string lastBuildDate { get; set; }
    public string category { get; set; }
    public string generator { get; set; }
    public string docs { get; set; }
    public string cloud { get; set; }
    public string ttl { get; set; }
    public string image { get; set; }
    public string rating { get; set; }
    public string textinput { get; set; }
    public string skipHours { get; set; }
    public string skipDays { get; set; }
    public List<RSSItem> items { get; set; }
#endregion

#region Constructors
    /// <summary>
    /// Just creates the relivent internal data strutures.
    /// </summary>
    public RSSChannel()
    {
        this.language = "";
    this.copyright = "";
    this.managingEditor = "";
    this.webMaster = "";
    this.pubDate = "";
    this.lastBuildDate = "";
    this.category = "";
    this.generator = "";
    this.docs = "";
    this.cloud = "";
    this.ttl = "";
    this.image = "";
    this.rating = "";
    this.textinput = "";
    this.skipHours = "";
    this.skipDays = "";

        items = new List<RSSItem>();
    }
#endregion

#region Public Methords
    /// <summary>
    /// Adds a new item to the channel
    /// </summary>
    /// <param name="newItem">an RSSItem to be added to the Channel</param>
    public void addItem(ref RSSItem newItem)
    {
        items.Add(newItem);
    }

    /// <summary>
    /// Validates the channel to ensure 
    /// </summary>
    /// <returns>TRUE : channel is valid
    /// FALSE : channel is invalid</returns>
    public bool isValid()
    {
        // TODO Think about how we can let the user know where the error is

        bool validFlag = true;

        if (title.Length == 0)
        {
            validFlag = false;
        }

        if (link.Length == 0)
        {
            validFlag = false;
        }

        if (description.Length == 0)
        {
            validFlag = false;
        }

        foreach (RSSItem item in items)
        {
            if (!item.isValid())
            {
                validFlag = false;
            }
        }

        return validFlag;

    }

    public string ToString()
    {
        StringBuilder outString = new StringBuilder();

        outString.AppendLine("<channel>");

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

        if (language.Length != 0)
        {
            outString.Append("<language>");
            outString.Append(language);
            outString.AppendLine("</language>");
        }

        if (copyright.Length != 0)
        {
            outString.Append("<copyright>");
            outString.Append(copyright);
            outString.AppendLine("</copyright>");
        }

        if (managingEditor.Length != 0)
        {
            outString.Append("<managingEditor>");
            outString.Append(managingEditor);
            outString.AppendLine("</managingEditor>");
        }

        if (webMaster.Length != 0)
        {
            outString.Append("<webMaster>");
            outString.Append(webMaster);
            outString.AppendLine("</webMaster>");
        }

        if (pubDate.Length != 0)
        {
            outString.Append("<pubDate>");
            outString.Append(pubDate);
            outString.AppendLine("</pubDate>");
        }

        if (lastBuildDate.Length != 0)
        {
            outString.Append("<lastBuildDate>");
            outString.Append(lastBuildDate);
            outString.AppendLine("</lastBuildDate>");
        }

        if (category.Length != 0)
        {
            outString.Append("<category>");
            outString.Append(category);
            outString.AppendLine("</category>");
        }

        if (generator.Length != 0)
        {
            outString.Append("<generator>");
            outString.Append(generator);
            outString.AppendLine("</generator>");
        }

        if (docs.Length != 0)
        {
            outString.Append("<docs>");
            outString.Append(docs);
            outString.AppendLine("</docs>");
        }

        if (cloud.Length != 0)
        {
            outString.Append("<cloud>");
            outString.Append(cloud);
            outString.AppendLine("</cloud>");
        }

        if (ttl.Length != 0)
        {
            outString.Append("<ttl>");
            outString.Append(ttl);
            outString.AppendLine("</ttl>");
        }

        if (image.Length != 0)
        {
            outString.Append("<image>");
            outString.Append(image);
            outString.AppendLine("</image>");
        }
        if (rating.Length != 0)
        {
            outString.Append("<rating>");
            outString.Append(rating);
            outString.AppendLine("</rating>");
        }

        if (textinput.Length != 0)
        {
            outString.Append("<textinput>");
            outString.Append(textinput);
            outString.AppendLine("</textinput>");
        }

        if (skipHours.Length != 0)
        {
            outString.Append("<skipHours>");
            outString.Append(skipHours);
            outString.AppendLine("</skipHours>");
        }

        if (skipDays.Length != 0)
        {
            outString.Append("<skipDays>");
            outString.Append(skipDays);
            outString.AppendLine("</skipDays>");
        }

        foreach (RSSItem item in items)
        {
            outString.Append(item.ToString());
        }

        outString.AppendLine("</channel>");

        return outString.ToString();

    }


#endregion

#region Private Methords

#endregion

}
