$(document).ready(function(){
  $("#focusedInput").on("keyup", function() {
    var value = $(this).val().toLowerCase();
    $("#notSoldPackages #packageCard h3").filter(function() {
        $(this).parentsUntil("#packageRow").toggle($(this).text().toLowerCase().indexOf(value) > -1)
      });
    $("#soldPackages #soldPackageCard h3").filter(function () {
        $(this).parentsUntil("#soldPackageRow").toggle($(this).text().toLowerCase().indexOf(value) > -1)
    });
  });





/****************************************************Initialize variables for unpackaged pagination***********************************************/
    var numberOfItems = $("#packageRow .page").length;
    var limitPerPage = 9;

    //Limit number of items to page
    $("#packageRow .page:gt(" + (limitPerPage - 1) + ")").hide();
    var totalPages = Math.round(numberOfItems / limitPerPage);

    //Append html elements to pagination class block
    $(".notsold").append("<li class='current-page active'><a href='javascript:void(0)'>" + 1 + "</a></li>");
    //Create appropriate number of pages
    for (var i = 2; i <= totalPages; i++) {
        $(".notsold").append("<li class='current-page'><a href='javascript:void(0)'>" + i + "</a></li>");
    }
    $(".notsold").append("<li id='next-page'><a href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span></a></li>");

    
    $(".notsold li.current-page").on("click", function () {
        if($(this).hasClass("active")) {
            return false;
        } 
        else {
            var currentPage = $(this).index();
            $(".notsold li").removeClass("active");
            $(this).addClass("active");
            $("#packageRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#packageRow .page:eq(" + i + ")").show();
            }
        }
    });

    $("#next-page").on("click", function () {
        var currentPage = $(".notsold li.active").index();
        if (currentPage === totalPages) {
            return false;
        } else {
            currentPage++;
            $(".notsold li").removeClass("active");
            $("#packageRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#packageRow .page:eq(" + i + ")").show();
            }

            $(".notsold li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });

    $("#previous-page").on("click", function () {
        var currentPage = $(".notsold li.active").index();
        if (currentPage === 1) {
            return false;
        } else {
            currentPage--;
            $(".notsold li").removeClass("active");
            $("#packageRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#packageRow .page:eq(" + i + ")").show();
            }

            $(".notsold li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });


/****************************************************Initialize variables for unpackaged pagination***********************************************/
    var numberOfSoldItems = $("#soldPackageRow .page").length;
    var limitPerPage = 9;

    //Limit number of items to page
    $("#soldPackageRow .page:gt(" + (limitPerPage - 1) + ")").hide();
    var totalSoldPages = Math.round(numberOfSoldItems / limitPerPage);

    //Append html elements to pagination class block
    $(".sold").append("<li class='current-page active'><a href='javascript:void(0)'>" + 1 + "</a></li>");
    //Create appropriate number of pages
    for (var i = 2; i <= totalSoldPages; i++) {
        $(".sold").append("<li class='current-page'><a href='javascript:void(0)'>" + i + "</a></li>");
    }
    $(".sold").append("<li id='next-page'><a href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span></a></li>");


    $(".sold li.current-page").on("click", function () {
        if ($(this).hasClass("active")) {
            return false;
        }
        else {
            var currentPage = $(this).index();
            $(".sold li").removeClass("active");
            $(this).addClass("active");
            $("#soldPackageRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#soldPackageRow .page:eq(" + i + ")").show();
            }
        }
    });

    $("#next-page").on("click", function () {
        var currentPage = $(".sold li.active").index();
        if (currentPage === totalSoldPages) {
            return false;
        } else {
            currentPage++;
            $(".sold li").removeClass("active");
            $("#soldPackageRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#soldPackageRow .page:eq(" + i + ")").show();
            }

            $(".sold li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });

    $("#previous-page").on("click", function () {
        var currentPage = $(".sold li.active").index();
        if (currentPage === 1) {
            return false;
        } else {
            currentPage--;
            $(".sold li").removeClass("active");
            $("#soldPackageRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#soldPackageRow .page:eq(" + i + ")").show();
            }

            $(".sold li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });
});