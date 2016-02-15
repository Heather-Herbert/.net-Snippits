using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// A class representing a whole RSS Feed.
/// </summary>
public class RSSFeed
{
    #region Required item elements
    public RSSChannel channel { get; set; }
    #endregion

    #region Constructor

    public RSSFeed()
    {
        channel = new RSSChannel();
    }

    #endregion


    #region Public Methords

    public string ToString()
    {
        StringBuilder outString = new StringBuilder();

        outString.AppendLine("<rss version=\"2.0\">");
        outString.Append(channel.ToString());
        outString.AppendLine("</rss>");
        return outString.ToString();

    }

    #endregion




}
