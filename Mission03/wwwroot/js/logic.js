// JavaScript source code
//document.getElementById("calc").addEventListener("click", function () {
//    alert("From: " + document.getElementById("txtFrom").value + ", Subject: " + document.getElementById("txtSubject").value + ", Message: " + document.getElementById("txtMessage"));
//})

$("#calc").click(function () {
    //Calculate the final grade 
    var grade = (($('#asgmts').val() / 100) * .55) + (($('#gp').val() / 100) * .05) + (($('#qz').val() / 100) * .1) + (($('#exm').val() / 100) * .2) + (($('#ix').val() / 100) * .1);
    
    //Determine the letter grade
    var letterGrade = ""
    if (grade >= .94) {
        letterGrade = "an A!"
    } else if (grade >= .9) {
        letterGrade = "an A-"
    } else if (grade >= .87) {
        letterGrade = "a B+"
    } else if (grade >= .84) {
        letterGrade = "a B"
    } else if (grade >= .80) {
        letterGrade = "a B-"
    } else if (grade >= .77) {
        letterGrade = "a C+"
    } else if (grade >= .74) {
        letterGrade = "a C"
    } else if (grade >= .70) {
        letterGrade = "a C-"
    } else if (grade >= .67) {
        letterGrade = "a D+"
    } else if (grade >= .64) {
        letterGrade = "a D"
    } else if (grade >= .60) {
        letterGrade = "a D-"
    } else {
        letterGrade = "an E"
    }

    //Output the results to the tag at the bottom
    alert("My Final Grade is: " + (grade * 100).toFixed(2) + "%. That's " + letterGrade);
    $('#fg').html("My Final Grade is: " + (grade * 100).toFixed(2) + "%. That's " + letterGrade);

    
})
/*$("#picGanderson").fadeOut("slow");*/
    /*$("#picGanderson").fadeToggle();*/



