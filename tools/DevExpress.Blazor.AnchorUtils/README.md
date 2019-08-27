# DevExpress Blazor In-page Navigation Tool

The DevExpress Blazor In-page Navigation tool scrolls a Blazor page to an anchor. Use this tool in the following cases:

* To scroll a page after a user clicks a hyperlink with an anchor
* To scroll a page that is opened for the first time and contains an anchor in its URL (for example, https://demos.devexpress.com/blazor/SchedulerViewTypes#DayView)

The tool also includes the Blazor **AnchorLink** component. Use this component to create skip navigation links. For example:

```html
	<AnchorLink class="nav-link py-3 px-4" href="#MySection1">My Section 1</AnchorLink>
```
	
When a user clicks this link, the page is automatically scrolled to a corresponding anchor (_MySection1_).

## Add the tool to a project

Follow the steps below to add the tool to your Blazor application.

1. Download and add the **DevExpress.Blazor.AnchorUtils.csproj** project to your Blazor solution.

2. Register the **DevExpress.Blazor.AnchorUtils** namespace in the _\_Imports.razor_ file:

```
	@using DevExpress.Blazor.AnchorUtils
```
   
3. Add the non-visual **AnchorUtilsComponent** component to the _Shared/MainLayout.razor_ file:

```html
   <div class="main">
		...
		<div class="content px-4"> 
			@Body 
		</div> 
	</div>
	
	<AnchorUtilsComponent />
```
	
4. Copy `lib/anchor-utils.js` file from the navigation tool’s source code to your project’s `wwwroot` folder or its subfolder.

* For **server-side Blazor**, register the copied file in _Pages/\_Host.cshtml_ file.

* For **client-side Blazor**, register the copied file in _wwwroot/index.html_ file.

```html
	<script type="text/javascript" src="~/anchor-utils.js"></script>
```
	
**Note**: If your page contains a non-scrollable header (for example, like the standard Blazor project template), edit the _anchor-utils.js_ file to set a vertical scroll offset according to your application’s layout:

```javascript
	y -= document.querySelector(".main .top-row").offsetHeight;
```
	
