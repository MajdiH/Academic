<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="SearchContent" runat="server">
              <% using (Html.BeginForm("Search", "Series", FormMethod.Get, new { @class = "navbar-search pull-right" }))
                 { %>
                <input type="text" name='q' class="search-query" placeholder="Recherche" onchange="this.form.submit()">
              <% } %>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Séries
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <div class="row">
        <div class="span12">
            <h1>Résultats</h1>
        </div>
        <div id="thumbnails">
        <% foreach (var serie in (IEnumerable<TueursEnSeries.Models.Serie>)ViewData["series"])
           { %>
           <div class="item well">
           <% if (serie.Banner.Length>0)
              { %>
             <a href="http://www.imdb.com/title/<%= HttpUtility.UrlEncode(serie.Imdb) %>"><img 
                src="http://thetvdb.com/banners/_cache/<%= serie.Banner %>" 
                title="<%= HttpUtility.HtmlAttributeEncode(serie.Name) %>" 
                alt="<%= HttpUtility.HtmlAttributeEncode(serie.Name) %>"/></a>
           <% } %>
             <div>
                <h4><%: serie.Name %></h4>
                <p><%: serie.Overview %></p>
                <h6><a href="http://www.imdb.com/title/<%= HttpUtility.UrlEncode(serie.Imdb) %>" class="btn">Fiche Imdb</a></h6>
                <!-- <%: serie.Id %> -->
             </div>
           </div>
        <% } %>
        </div>
      </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="ScriptContent" runat="server">
    <script src="../../Scripts/jquery.grid-a-licious.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#thumbnails").gridalicious({ width: 225 });
        });
    </script>
</asp:Content>
