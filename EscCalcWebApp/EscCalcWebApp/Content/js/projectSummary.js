var currentView = "A"; // allporjects view

 var currentSortOn = "pn"; // on prject name

 var currentSort = "a"; // ascending or descending

 var BuildingsList = [];

 BuildingsList.push("Building name 1");
 BuildingsList.push("Building name 2");
 BuildingsList.push("Building name 3");
 BuildingsList.push("Building name 4");
 BuildingsList.push("Building name 5");
 BuildingsList.push("Building name 6");

 //setBuildingsListSection();

 $(document).ready(function() {
	//$(".datacol1Header")[0].width = $(".datacol1Header")[0].clientWidth + ($(window).width() - 190 - $(".datacol1Header")[0].clientWidth - $(".datacol2Header")[0].clientWidth - $(".datacol3Header")[0].clientWidth  );
	if($(window).width() > 1200 )
	{
		//$(".datacol1Header").css("width", ($(".datacol1Header")[0].clientWidth + (1200 - 184 - $(".datacol1Header")[0].clientWidth - $(".datacol2Header")[0].clientWidth - $(".datacol3Header")[0].clientWidth)));
	}else
	{
		//$(".datacol1Header").css("width", ($(".datacol1Header")[0].clientWidth + ($(window).width() - 184 - $(".datacol1Header")[0].clientWidth - $(".datacol2Header")[0].clientWidth - $(".datacol3Header")[0].clientWidth)));
	}

	//$(".datacol1").css("width" , $(".datacol1Header").width());
	
	
 });

 function setBuildingsListSection()
 {
    var extraHtml = "";

    for(var i=0; i<BuildingsList.length; i++)
    {

        var ind = i+1;

        extraHtml += '<div data-pos="'+ ind +'" onclick="changeBuildingData(this)" class="BuildingsListItem">' + BuildingsList[i] + '</div>';
   
    }

    $("#BLContainer").width( BuildingsList.length * 180 );

    $("#BLContainer").html(extraHtml);
 }

 function changeBuildingData(val)
 {
    var value = $(val).attr("data-pos");

    if(value == 1)
    {
        $(".triangle").addClass("firstBuilding");
        $(".triangle").removeClass("secondBuilding");
        $(".triangle").removeClass("thirdBuilding");
    }else if(value == 2)
    {
        $(".triangle").removeClass("firstBuilding");
        $(".triangle").addClass("secondBuilding");
        $(".triangle").removeClass("thirdBuilding");
    }else if(value == 3)
    {
        $(".triangle").removeClass("firstBuilding");
        $(".triangle").removeClass("secondBuilding");
        $(".triangle").addClass("thirdBuilding");
    }
 }

//function changeCurrentView(val)
// {
//    if(currentView == val) return;

//    if(val == 'M') showMyProjectsView();
//    else showAllProjectsView();
    
// }

//function showMyProjectsView()
//{
//    currentView = 'M';
//    $(".triangle").removeClass("allprjs");
//    //$("#BuildingSection1").toggleClass("hide", "show");
//    //$("#floorSection").toggleClass("hide", "show");
//    $("#myPrjsLink > p").addClass("activeLink");
//    $("#allPrjsLink > p").removeClass("activeLink");
//}

//function showAllProjectsView()
//{
//    currentView = 'A';
//    $(".triangle").addClass("allprjs");
    
//    $("#myPrjsLink > p").removeClass("activeLink");
//    $("#allPrjsLink > p").addClass("activeLink");
    
//}

 function openSideMenu(evt)
 {
 	document.getElementById("fullMask").style.height = "100%";
 	document.getElementById("fullMask").style.opacity = 1;

 	document.getElementById("sideMenu").style.width = "300px";
 	
 }

 function closeSideMenu(evt)
 {
 	
 	document.getElementById("fullMask").style.opacity = 0;

 	document.getElementById("sideMenu").style.width = "0px";

 	window.setTimeout(removeMask, 400);
 }
 function removeMask()
 {
 	document.getElementById("fullMask").style.height = "0%";
 	
 }


function dosomething(ind)
{
    alert("dosomethingelse with list item: "+ ind);
    event.stopPropagation();

}


//$(".dropdownheader").click(function(){
//    var targetelement = $(this).attr("data-target");
//    $("#"+targetelement).slideToggle(500);

//    $(this).find(".rotatingArrowImage").toggleClass("rotatedImg");

//});

$(".NavigationTo").click(function(){
    event.stopPropagation();
    //alert("stops dropdown");
});

function ShowHideSection(val) { 
    var targetelement = val;
    $("#" + targetelement).slideToggle(500);

    $(this).find(".rotatingArrowImage").toggleClass("rotatedImg");
}
