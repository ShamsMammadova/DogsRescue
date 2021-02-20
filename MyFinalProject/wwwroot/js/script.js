
let baskets = document.querySelectorAll(".purchaseBasket .fa-shopping-basket ");

for (let basket of baskets) {
    basket.addEventListener("click", function () {
        this.firstChild.firstChild.classList.remove("d-none");
        this.nextElementSibling.classList.add("d-none");
    })
}
//preloader
$(document).ready(function () {
    $("#preloader").hide();
});


//small screens sidebar menu
$(document).ready(function () {
    $(window).resize(function () {
        if (window.innerWidth > 992) {
            $("body").css("overflow-y", "unset");
            if ($("#small-screens #sidebar-btn").hasClass("collapsed")) {
                $("#small-screens #sidebar-btn").removeClass("collapsed");
                $("#small-screens #sidebar-btn").children().removeClass("w-100")
                $("#small-screens #sidebar").removeClass("visible")
            }
        }
    });
    $("#small-screens #sidebar-btn").click(function () {
        $("#small-screens #sidebar-btn").toggleClass("collapsed")
        $(this).children().toggleClass("w-100")
        $("#small-screens #sidebar").toggleClass("visible");
        if ($(this).hasClass("collapsed")) {
            $("body").css("overflow-y", "hidden")
        }
        else {
            $("body").css("overflow-y", "unset")
        }
    })
});

//menu position changer
$(document).ready(function () {
    LargeScreenMenuPositionChanger();
    document.addEventListener("scroll", function () {
        LargeScreenMenuPositionChanger();
    })
    function LargeScreenMenuPositionChanger() {
        if (document.scrollingElement.scrollTop > 42) {
            $("#large-screens .menubar").css({
                "position": "fixed",
                "width": "100%",
                "top": "0",
                "z-index": "9999999",
                //  "background-color": "rgba(17, 46, 59, 0.9)"
                "background-color": "#fff"

            })
        }
        else {
            $("#large-screens .menubar").css({
                "position": "unset",
                "background-color": "unset"
            })
        }
    }
});



//login page & register page & contact page line span width changer
$(document).ready(function () {
    $("#login .sign-in-input").focus(function () {
        LoginAndRegisterSpanLineWidthChanger("login", $(this));
    })
    $("#register .sign-in-input").focus(function () {
        LoginAndRegisterSpanLineWidthChanger("register", $(this));
    })
    $("#contact .sign-in-input").focus(function () {
        LoginAndRegisterSpanLineWidthChanger("contact", $(this));
    })
    function LoginAndRegisterSpanLineWidthChanger(section, input) {
        $(`#${section} .line`).css("width", "0%")
        $(input).next().css("width", "100%")
    }
});



//detail gallery
$(document).on("click", '[data-toggle="lightbox"]', function (event) {
    event.preventDefault();
    $(this).ekkoLightbox();
});

//Gallery details tab changer and gallery img height resizer
$(document).ready(function () {

    //single post gallery and car details gallery height resizer
    PostGalleryImagesHeightResizer(0, "post");
    PostGalleryImagesHeightResizer(0, "single-car-details");
    $(window).resize(function () {
        $(".detail-gallery img").each(function () {
            $(this).css("height", "auto")
        })
        PostGalleryImagesHeightResizer(0, "post");
        PostGalleryImagesHeightResizer(0, "single-car-details");
    });
    function PostGalleryImagesHeightResizer(height, sectionId) {
        $(`#${sectionId} .detail-gallery img`).each(function () {
            if ($(this).height() > height) {
                height = $(this).height()
            }
        });
        $(`#${sectionId} .detail-gallery img`).each(function () {
            $(this).height(height)
        });
    }
});


// PARTNER

$(document).ready(function(){
    $('.customer-logos').slick({
        slidesToShow: 6,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 1500,
        arrows: false,
        dots: false,
        pauseOnHover: false,
        responsive: [{
            breakpoint: 768,
            settings: {
                slidesToShow: 4
            }
        }, {
            breakpoint: 520,
            settings: {
                slidesToShow: 3
            }
        }]
    });
});


// LOAD MORE

//$(document).ready(function () {
//    $("#load_more").click(function () {
//        var Id = $(this).val();
//        if (Id) {
//            $.ajax({
//                url: "/Donate/LoadDonates",
//                //url: "/Donate/DonateDetailImage/" + Id,
//                type: "POST",
//                dataType: "json",
//                success: function (don) {

//                    for (var donate of don.data) {
//                        var mainDiv = $("<div>")
//                            .addClass("col-lg-4  col-md-6 col-sm-12  visit mb-3");


//                        var a = $("<a>");
//                        var img = $("<img>").addClass("img-fluid w-100")
//                            .attr("src", "/img/" + donate.photo);

//                        img.appendTo(a);
//                        a.appendTo(mainDiv);
//                        $(".main-row").append(mainDiv);

//                    }
//                }
//            });
//        }
//    })
//});

var skip = 3;
$("#load_more").click(function () {
    $.ajax({
        url: "Donate/LoadDonates",
        type: "Get",
        data: {skip: skip},
        success: function (res) {
            $("#_Donatepartial").html($("#_Donatepartial").html() + res);
            skip += 3;
        }

    })
});




