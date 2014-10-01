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
    //Carousel Functions END
});