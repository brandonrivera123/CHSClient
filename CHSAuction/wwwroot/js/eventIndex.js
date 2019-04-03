$(document).ready(function(){
  $("#focusedInput").on("keyup", function() {
    var value = $(this).val().toLowerCase();
    $("#eventCard .caption").filter(function() {
        $(this).parentsUntil("#eventRow").toggle($(this).text().toLowerCase().indexOf(value) > -1)
    });
  });





/****************************************************Initialize variables for unpackaged pagination***********************************************/
    var numberOfItems = $(".futureEvent .page").length;
    var limitPerPage = 3;

    //Limit number of items to page
    $(".futureEvent .page:gt(" + (limitPerPage - 1) + ")").hide();
    var totalPages = Math.round(numberOfItems / limitPerPage);

    //Append html elements to pagination class block
    $(".future").append("<li class='current-page active'><a href='javascript:void(0)'>" + 1 + "</a></li>");
    //Create appropriate number of pages
    for (var i = 2; i <= totalPages; i++) {
        $(".future").append("<li class='current-page'><a href='javascript:void(0)'>" + i + "</a></li>");
    }
    $(".future").append("<li id='next-page'><a href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span></a></li>");

    
    $(".future li.current-page").on("click", function () {
        if($(this).hasClass("active")) {
            return false;
        } 
        else {
            var currentPage = $(this).index();
            $(".future li").removeClass("active");
            $(this).addClass("active");
            $(".futureEvent .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $(".futureEvent .page:eq(" + i + ")").show();
            }
        }
    });

    $("#next-page").on("click", function () {
        var currentPage = $(".future li.active").index();
        if (currentPage === totalPages) {
            return false;
        } else {
            currentPage++;
            $(".future li").removeClass("active");
            $(".futureEvent .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $(".futureEvent .page:eq(" + i + ")").show();
            }

            $(".future li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });

    $("#previous-page").on("click", function () {
        var currentPage = $(".future li.active").index();
        if (currentPage === 1) {
            return false;
        } else {
            currentPage--;
            $(".future li").removeClass("active");
            $(".futureEvent .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $(".futureEvent .page:eq(" + i + ")").show();
            }

            $(".future li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });




//Initialize variables for packaged pagination
    var numberOfPreviousItems = $(".previousEvent .page").length;
    var limitPerPreviousPage = 3;

    //Limit number of items to page
    $(".previousEvent .page:gt(" + (limitPerPreviousPage - 1) + ")").hide();
    var totalPreviousPages = Math.round(numberOfPreviousItems / limitPerPreviousPage);

    //Append html elements to pagination class block
    $(".previous").append("<li class='current-page active'><a href='javascript:void(0)'>" + 1 + "</a></li>");
    //Create appropriate number of pages
    for (var i = 2; i <= totalPreviousPages; i++) {
        $(".previous").append("<li class='current-page'><a href='javascript:void(0)'>" + i + "</a></li>");
    }
    $(".previous").append("<li id='next-pages'><a href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span></a></li>");

    
    $(".previous li.current-page").on("click", function () {
        if($(this).hasClass("active")) {
            return false;
        } 
        else {
            var currentPage = $(this).index();
            $(".previous li").removeClass("active");
            $(this).addClass("active");
            $(".previousEvent .page").hide();

            var grandPreviousTotal = limitPerPreviousPage * currentPage;

            for (var i = grandPreviousTotal - limitPerPreviousPage; i < grandPreviousTotal; i++) {
                $(".previousEvent .page:eq(" + i + ")").show();
            }
        }
    });

    $("#next-pages").on("click", function () {
        var currentPage = $(".previous li.active").index();
        if (currentPage === totalPreviousPages) {
            return false;
        } else {
            currentPage++;
            $(".previous li").removeClass("active");
            $(".previousEvent .page").hide();

            var grandPreviousTotal = limitPerPreviousPage * currentPage;

            for (var i = grandPreviousTotal - limitPerPreviousPage; i < grandPreviousTotal; i++) {
                $(".previousEvent .page:eq(" + i + ")").show();
            }

            $(".previous li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });

    $("#previous-pages").on("click", function () {
        var currentPage = $(".previous li.active").index();
        if (currentPage === 1) {
            return false;
        } else {
            currentPage--;
            $(".previous li").removeClass("active");
            $(".previousEvent .page").hide();

            var grandPreviousTotal = limitPerPreviousPage * currentPage;

            for (var i = grandPreviousTotal - limitPerPreviousPage; i < grandPreviousTotal; i++) {
                $(".previousEvent .page:eq(" + i + ")").show();
            }

            $(".previous li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });
});