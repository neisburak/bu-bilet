function getTomorrow() {
  var date = new Date();
  date.setDate(date.getDate() + 1);
  return date;
}

$(function () {
  // Owl Carousel Initialization
  if ($(".owl-carousel").length) {
    $(".owl-carousel").owlCarousel({
      loop: true,
      dots: true,
      items: 1,
      singleItem: true,
    });
  }

  // Date Picker Initialization
  if ($(".form-date").length) {
    var datepicker = $(".form-date")
      .datepicker({
        language: "tr",
        format: "dd MM yyyy DD",
        startDate: "0",
        autoclose: true,
      })
      .datepicker("setDate", getTomorrow());

    $(".form-item-buttons .btn").click(function () {
      var el = $(this),
        data = el.data("date");
      if (el.hasClass("active")) return;

      el.parent().find(".btn").removeClass("active");
      el.addClass("active");

      if (data == "today") {
        datepicker.datepicker("setDate", "now");
      } else {
        datepicker.datepicker("setDate", getTomorrow());
      }
    });
  }

  // City Select Initialization
  if ($(".selectpicker").length) {
    if (
      /Android|webOS|iPhone|iPad|iPod|BlackBerry/i.test(navigator.userAgent)
    ) {
      $(".selectpicker").selectpicker("mobile");
    }

    $(".btn-switch").click(function () {
      var fromValue = $(".city-from").selectpicker("val"),
        toValue = $(".city-to").selectpicker("val");

      if (!fromValue || !toValue) return;

      $(".city-from").selectpicker("val", toValue);
      $(".city-to").selectpicker("val", fromValue);
    });
  }
});
