﻿$(document).ready(function(){
  $("#focusedInput").on("keyup", function() {
    var value = $(this).val().toLowerCase();
    $("#guest #guestRow" ).filter(function() {
        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
    });
  });



    var numberOfItems = $(".guest .page").length;
    var limitPerPage = 50;

    //Limit number of items to page
    $(".guest .page:gt(" + (limitPerPage - 1) + ")").hide();
    var totalPages = Math.round(numberOfItems / limitPerPage);

    //Append html elements to pagination class block
    $(".pagination").append("<li class='current-page active'><a href='javascript:void(0)'>" + 1 + "</a></li>");
    //Create appropriate number of pages
    for (var i = 2; i <= totalPages; i++) {
        $(".pagination").append("<li class='current-page'><a href='javascript:void(0)'>" + i + "</a></li>");
    }
    $(".pagination").append("<li id='next-page'><a href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span></a></li>");

    
    $(".pagination li.current-page").on("click", function () {
        if($(this).hasClass("active")) {
            return false;
        } 
        else {
            var currentPage = $(this).index();
            $(".pagination li").removeClass("active");
            $(this).addClass("active");
            $(".guest .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $(".guest .page:eq(" + i + ")").show();
            }
        }
    });

    $("#next-page").on("click", function () {
        var currentPage = $(".pagination li.active").index();
        if (currentPage === totalPages) {
            return false;
        } else {
            currentPage++;
            $(".pagination li").removeClass("active");
            $(".guest .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $(".guest .page:eq(" + i + ")").show();
            }

            $(".pagination li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });

    $("#previous-page").on("click", function () {
        var currentPage = $(".pagination li.active").index();
        if (currentPage === 1) {
            return false;
        } else {
            currentPage--;
            $(".pagination li").removeClass("active");
            $(".guest .page").hide();

            var grandTotal = limitPerPage * currentPage;

            for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                $(".guest .page:eq(" + i + ")").show();
            }

            $(".pagination li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
        }
    });
});









