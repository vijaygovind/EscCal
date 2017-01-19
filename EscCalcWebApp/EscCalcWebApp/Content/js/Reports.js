
var isPortrait = true;
window.onresize = function(){ location.reload(); }

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
	refresh();
	
});

 

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

function refresh() {
    
    if (window.innerWidth > 1000) {
        isPortrait = false;
        $('#divUpPeak').css('height', '170px');

        var divInterval = $('#divInterval').html();
        var divHandlingCapacity = $('#divHandlingCapacity').html();
        var divCarLoad = $('#divCarLoad').html();
        var divRoundTripTime = $('#divRoundTripTime').html();

        $('#divInterval').html(divHandlingCapacity);
        $('#divHandlingCapacity').html(divInterval);
        $('#divRoundTripTime').html(divCarLoad);
        $('#divCarLoad').html(divRoundTripTime);


        var divLongWaits = $('#divLongWaits').html();
        var divLongJourney = $('#divLongJourney').html();
        var divWaitingTime = $('#divWaitingTime').html();
        var divJourneyTime = $('#divJourneyTime').html();
        var divCarLoadFactor = $('#divCarLoadFactor').html();

        $('#divLongJourney').html(divLongWaits);
        $('#divLongWaits').html(divWaitingTime);
        $('#divCarLoadFactor').html(divLongJourney);

        $('#divWaitingTime').html(divJourneyTime);
        $('#divJourneyTime').html(divCarLoadFactor);

        var divAllElevator = $('#divAllElevator').html();
        var divDesignCriteria = $('#divDesignCriteria').html();
        $('#divDesignCriteria').html(divAllElevator);
        $('#divAllElevator').html(divDesignCriteria);
    }

    else {
        $(".hideInLandscapeDivLeft").css("width", "700px");
        $(".hideInLandscapeDivRight").css("width", "700px");
        
    }
}