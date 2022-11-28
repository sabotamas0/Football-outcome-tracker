$.fn.tooltipOnOverflow = function (options) {
    $(this).on("mouseenter", function () {
        if (this.offsetWidth < this.scrollWidth) {
            options = options || { placement: "auto" }
            options.title = $(this).text();
            $(this).tooltip(options);
            $(this).tooltip("show");
        } else {
            if ($(this).data("bs.tooltip")) {
                $tooltip.tooltip("hide");
                $tooltip.removeData("bs.tooltip");
            }
        }
    });
};

$('.mightOverflow').tooltipOnOverflow();