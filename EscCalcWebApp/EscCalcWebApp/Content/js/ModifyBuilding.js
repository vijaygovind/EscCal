 

 var isPortrait=true;

 var currentView = "B";

 window.onresize = function () {
     //location.reload();
     showBuildingView();
     refresh();
     
 }

 

 function refresh()
 {
     $('.customDropdown li').click(function () {

         $(this).parent().siblings('.inner-addon').find("input")[0].value = $(this).html();
         //console.log( $(".customDropdown")[0] );
         var event = jQuery.Event("cusotmevent")
         $($(this).parent().parent()[0]).trigger(event);
     });

     $('.styled-select').find('option').css("height", "36px");

     $(".customDropdown").on("cusotmevent", function (event) {


     });

     //$("#extendHeader1").click(function () {
     //    $("#extendContent1").slideToggle();
     //    $("#extendHeader1 > img").toggleClass("rotatedImg");
     //});

     if (window.innerWidth > 1000) {
         isPortrait = false;

         currentView = "NA";

         $("#BuildingSection1").removeClass("hide");
         $("#floorSection").removeClass("hide");

         $("#BuildingSection1").addClass("show");
         $("#floorSection").addClass("show");

         $(".hideInLandscapeView").css("display", "none");

         $(".secondGlyphicon").css("right", "0px");
         $(".secondGlyphicon").css("left", "auto");
     }

    
 }


 $(document).ready(function() {
     $('[data-toggle="tooltip"]').tooltip();
     refresh();

     $("#extendHeader1").click(function () {
         $("#extendContent1").slideToggle();
         $("#extendHeader1 > img").toggleClass("rotatedImg");
     });   
 });

 function changeCurrentView(val) {
     if (currentView == val) return;

     if (val == 'B') showBuildingView();
     else showFloorsView();

     customHeight = $('.htCore').outerHeight();
     $('.htContainer').css('height', customHeight + 'px');
 }

function showBuildingView()
{
	currentView = 'B';
	$(".triangle").removeClass("floor");

	$("#BuildingSection1").addClass( "show");
	$("#BuildingSection1").removeClass("hide");

	$("#floorSection").addClass("hide");
	$("#floorSection").removeClass("show");

	//$("#floorSection").toggleClass("hide", "show");
	$("#BuildingsLink > p").addClass("activeLink");
	$("#FloorsLink > p").removeClass("activeLink");
}

function showFloorsView()
{
	currentView = 'F';
	$(".triangle").addClass("floor");
	//$("#BuildingSection1").toggleClass("hide", "show");
    //$("#floorSection").toggleClass("hide", "show");

	$("#BuildingSection1").addClass("hide");
	$("#BuildingSection1").removeClass("show");

	$("#floorSection").addClass("show");
	$("#floorSection").removeClass("hide");


	$("#BuildingsLink > p").removeClass("activeLink");
	$("#FloorsLink > p").addClass("activeLink");

	
}

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


