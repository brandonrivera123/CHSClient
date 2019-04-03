//Execute after page is loaded
$(document).ready(function(){
    //Initializes Search Bar
    $("#focusedInput").on("keyup", function() {
        var value = $(this).val().toLowerCase(); //Gets users input

        //Filters Unpackaged items accoding to match user input
        $("#unpackagedItems #itemCard h3").filter(function() {
            $(this).parentsUntil("#itemRow").toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
        //Filters Packaged items accoding to match user input
        $("#packagedItems #packagedItemCard h3").filter(function() {
            $(this).parentsUntil("#packagedRow").toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
    
/****************************************************Initialize variables for unpackaged pagination***********************************************/
    var numberOfItems = $("#itemRow .page").length;
    var limitPerPage = 9;

    //Limit number of items to page
    $("#itemRow .page:gt(" + (limitPerPage - 1) + ")").hide();
    var totalPages = Math.round(numberOfItems / limitPerPage);

    //Append html elements to pagination class block
    $(".unpackaged").append("<li class='current-page active'><a href='javascript:void(0)'>" + 1 + "</a></li>");
    //Create appropriate number of pages
    for (var i = 2; i <= totalPages; i++) {
        $(".unpackaged").append("<li class='current-page'><a href='javascript:void(0)'>" + i + "</a></li>");
    }
    $(".unpackaged").append("<li id='next-page'><a href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span></a></li>");

    
    $(".unpackaged li.current-page").on("click", function () {
        if($(this).hasClass("active")) {
            return false;
        } 
        else {
            var currentPage = $(this).index();
            $(".unpackaged li").removeClass("active");
            $(this).addClass("active");
            $("#itemRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#itemRow .page:eq(" + i + ")").show();
            }
        }
    });

    $("#next-page").on("click", function () {
        var currentPage = $(".unpackaged li.active").index();
        if (currentPage === totalPages) {
            return false;
        } else {
            currentPage++;
            $(".unpackaged li").removeClass("active");
            $("#itemRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#itemRow .page:eq(" + i + ")").show();
            }

            $(".unpackaged li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });

    $("#previous-page").on("click", function () {
        var currentPage = $(".unpackaged li.active").index();
        if (currentPage === 1) {
            return false;
        } else {
            currentPage--;
            $(".unpackaged li").removeClass("active");
            $("#itemRow .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $("#itemRow .page:eq(" + i + ")").show();
            }

            $(".unpackaged li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });
    
/*************************************Initialize variables for packaged pagination*************************************************************/
    var numberOfPackagedItems = $("#packagedRow .page").length;
    var limitPerPackagedPage = 9;

    //Limit number of items to page
    $("#packagedRow .page:gt(" + (limitPerPackagedPage - 1) + ")").hide();
    var totalPackagedPages = Math.round(numberOfPackagedItems / limitPerPackagedPage);

    //Append html elements to pagination class block
    $(".packaged").append("<li class='current-page active'><a href='javascript:void(0)'>" + 1 + "</a></li>");
    //Create appropriate number of pages
    for (var i = 2; i <= totalPackagedPages; i++) {
        $(".packaged").append("<li class='current-page'><a href='javascript:void(0)'>" + i + "</a></li>");
    }
    $(".packaged").append("<li id='next-pages'><a href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span></a></li>");

    
    $(".packaged li.current-page").on("click", function () {
        if($(this).hasClass("active")) {
            return false;
        } 
        else {
            var currentPage = $(this).index();
            $(".packaged li").removeClass("active");
            $(this).addClass("active");
            $("#packagedRow .page").hide();

            var grandPackagedTotal = limitPerPackagedPage * currentPage;

            for (var i = grandPackagedTotal - limitPerPackagedPage; i < grandPackagedTotal; i++) {
                $("#packagedRow .page:eq(" + i + ")").show();
            }
        }
    });

    $("#next-pages").on("click", function () {
        var currentPage = $(".packaged li.active").index();
        if (currentPage === totalPackagedPages) {
            return false;
        } else {
            currentPage++;
            $(".packaged li").removeClass("active");
            $("#packagedRow .page").hide();

            var grandPackagedTotal = limitPerPackagedPage * currentPage;

            for (var i = grandPackagedTotal - limitPerPackagedPage; i < grandPackagedTotal; i++) {
                $("#packagedRow .page:eq(" + i + ")").show();
            }

            $(".packaged li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });

    $("#previous-pages").on("click", function () {
        var currentPage = $(".packaged li.active").index();
        if (currentPage === 1) {
            return false;
        } else {
            currentPage--;
            $(".packaged li").removeClass("active");
            $("#packagedRow .page").hide();

            var grandPackagedTotal = limitPerPackagedPage * currentPage;

            for (var i = grandPackagedTotal - limitPerPackagedPage; i < grandPackagedTotal; i++) {
                $("#packagedRow .page:eq(" + i + ")").show();
            }

            $(".packaged li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });
});