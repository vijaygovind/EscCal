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

 function ConvertToImperial(meters) {
     var totalInches = meters * 39.3701;
     var feets = parseInt(totalInches / 12);
     var inches = Math.round(totalInches - (feets * 12), 2);

     var imperialUnit = new Array();
     imperialUnit.push(feets);
     imperialUnit.push(inches);

     return imperialUnit;
 }

 function ConvertToMetric(feet, inch) {
     inch = parseFloat(feet * 12) + parseFloat(inch);
     return Math.round(inch * 0.0254, 6);
 }


 $(document).ready(function () {
     //validate for integer
     $("body").on("keypress", ".int_only", function (evt) {
         var charCode = (evt.which) ? evt.which : evt.keyCode;
         if ((charCode >= 48 && charCode <= 57) || (charCode == 9) || (charCode == 127) || (charCode == 8) || (charCode == 37) || (charCode == 39) || (charCode == 127))
             return true;

         return false;
     });

     $("body").on("keypress", ".signed_int_only", function (evt) {
         var charCode = (evt.which) ? evt.which : evt.keyCode;
         if ((charCode >= 48 && charCode <= 57) || (charCode == 9) || (charCode == 127) || (charCode == 8) || (charCode == 45) || (charCode == 37) || (charCode == 39))
             return true;

         return false;
     });

     //validate for float
     $("body").on("keypress", ".float_only", function (evt) {
         var charCode = (evt.which) ? evt.which : evt.keyCode;
         if ((charCode >= 48 && charCode <= 57) || (charCode == 9) || (charCode == 127) || (charCode == 8) || (charCode == 46) || (charCode == 37) || (charCode == 39))
             return true;

         return false;
     });

     $("body").on("keypress", ".signed_float_only", function (evt) {
         var charCode = (evt.which) ? evt.which : evt.keyCode;
         if ((charCode >= 48 && charCode <= 57) || (charCode == 9) || (charCode == 127) || (charCode == 8) || (charCode == 45) || (charCode == 46) || (charCode == 37) || (charCode == 39))
             return true;

         return false;
     });
 });


