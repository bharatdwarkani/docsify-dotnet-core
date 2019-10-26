# docsify-dotnet-core
**Docsify** is a magical documentation site generator - https://docsify.js.org. Docsify converts markdown files to static SEO friendly html pages.

This project demonstrates how we can add docisfy in a ASP.NET Core 3.0 application and serve documentation site.

# Requirements

Visual Studio 2019		
ASP.NET Core 3.0 SDK

# How to run?
Just open Visual studio and run project, documentation site will be up and running.	

# How to host?	
You can host this site any where in Linux/Windows/Azure/AWS server.

# How to add documentation
Open this folder wwwroot and add your documentation files in .md(markdown) format.    
https://github.com/bharatdwarkani/docsify-dotnet-core/tree/develop/src/DocsWebSite/wwwroot/docs   
_sidebar.md file contains the master index of your navigation menu.

# Screenshot

![Docs Site](https://raw.githubusercontent.com/bharatdwarkani/docsify-dotnet-core/develop/screenshot.png)


# How to customize
You can customize layout of your site by altering this file https://github.com/bharatdwarkani/docsify-dotnet-core/blob/develop/src/DocsWebSite/Views/Home/Index.cshtml    
You can find more documentation on customization here - https://docsify.js.org/#/configuration    
You can also directly link your docs from git repo - check out this guide - https://docsify.js.org/#/configuration?id=repo
