$(document).ready(function () {
//Carousel Functions START
    $('.carousel-next').on('click', function () {
        //Get the active slide
        var activeSlide = $(this).parent().find('.carousel.active');
        //Get the next slide
        var nextSlide = activeSlide.next();
        //Make sure it's a carousel slide
        if (!nextSlide.hasClass('carousel')) {
            nextSlide = $(this).parent().find('.carousel').first();
        }
        //Remove active class, add hide class to active slide
        activeSlide.removeClass('active').addClass('hide');
        //Remove the hide class, add active class to next slide
        nextSlide.removeClass('hide').addClass('active');
    });

    $('.carousel-prev').on('click', function () {
        //Get the active slide
        var activeSlide = $(this).parent().find('.carousel.active');
        //Get the next slide
        var nextSlide = activeSlide.prev();
        //Make sure it's a carousel slide
        if (!nextSlide.hasClass('carousel')) {
            nextSlide = $(this).parent().find('.carousel').last();
        }
        //Remove active class, add hide class to active slide
        activeSlide.removeClass('active').addClass('hide');
        //Remove the hide class, add active class to next slide
        nextSlide.removeClass('hide').addClass('active');
    });
    //Carousel Functions END

    //SUPERIOR AJAX GET 
    //Use 2nd select for applying this function to any matching elements that appear on the page AT ANY TIME
    $('body').on('click', '.ajax-get', function () {
        var urlRequest = $(this).data('url');
        //Make the AJAX request
        $.get(urlRequest, function (data) {
            $('#content').html(data);
        });
    });
    //AJAX GET END

    //AJAX POST for Contact Form START
    $('#contactForm').on('submit', function (event) {
        //Prevent default form behavior (Doesn't allow it to be submitted)
        event.preventDefault();
        //See if form is valid
        if ($(this).valid()) {
            //AJAX POST
            var urlToPostTo = $(this).attr('action');
            //Serialize to convert the form fields to a string we can pass into our $.post() function
            var dataToSend = $(this).serialize();
            $.post(urlToPostTo, dataToSend, function (data) {
                //Update the #container elements with the new HTML returned in the "data" param
                $('#container').html(data);
            });
        }
    });
    //AJAX POST for Contact Form END
});