$(function () {
  // Functions
  var setCities = function (from, to) {
    if (from) $(".city-from").selectpicker("val", from);
    if (to) $(".city-to").selectpicker("val", to);
  };
  var getCities = function (from, to) {
    $.get("/api/location").then(function (result) {
      result.data.forEach((item) => {
        $(".selectpicker").append(
          $("<option/>")
            .val(item.id)
            .html(item.name)
            .attr("data-tokens", item.keywords)
        );
      });
      $(".selectpicker").selectpicker("refresh");
      setCities(from, to);
    });
  };
  var hideOption = function (el, selector) {
    var value = $(el).selectpicker("val"),
      select = $(selector);
    select.find("option").show();
    select.find(`option[value="${value}"]`).hide();
    select.selectpicker("refresh");
  };
  var getSelectedOptionText = function (selector) {
    var el = $(selector),
      val = el.selectpicker("val"),
      option = el.find(`option[value="${val}"]`);

    return option.text();
  };

  // Getting prefrences
  var prefrences = getPrefrences();

  // Owl Carousel Initialization
  $(".owl-carousel").owlCarousel({
    loop: true,
    dots: true,
    items: 1,
    singleItem: true,
  });

  // Date Picker Initialization
  var datepicker = $(".form-date")
    .datepicker({
      language: "tr",
      format: "dd MM yyyy DD",
      startDate: "0",
      autoclose: true,
    })
    .on("changeDate", function (e) {
      var date = new Date(e.date);
      $("#DepartureDate").val(date.toISOString());
    });

  if (prefrences != null) {
    datepicker.datepicker("setDate", new Date(prefrences.DepartureDate));
  } else {
    datepicker.datepicker("setDate", getTomorrow());
    $(".btn-tomorrow").addClass("active");
  }

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

  // City Select Initialization
  // Getting Cities
  getCities(prefrences?.OriginId, prefrences?.DestinationId);

  // Picker Device Configuration
  if (/Android|webOS|iPhone|iPad|iPod|BlackBerry/i.test(navigator.userAgent)) {
    $(".selectpicker").selectpicker("mobile");
  }

  // Change Location Functionality
  $(".btn-switch").click(function () {
    var fromValue = $(".city-from").selectpicker("val"),
      toValue = $(".city-to").selectpicker("val");

    if (!fromValue || !toValue) return;

    setCities(toValue, fromValue);
  });

  $(".selectpicker").on("changed.bs.select", function (e, index, _, _) {
    var isFrom = $(e.target).hasClass("city-from");
    if (isFrom) {
      hideOption(this, ".city-to");
    } else {
      hideOption(this, ".city-from");
    }
  });

  // Form Submit Handling
  $("form").submit(function (e) {
    e.preventDefault();
    const formValues = getFormValues(this);

    const valid = validateForm(formValues);
    if (!valid) {
      e.preventDefault();
      return;
    }

    const values = $.extend({}, formValues, {
      Origin: getSelectedOptionText(".city-from"),
      Departure: getSelectedOptionText(".city-to"),
    });

    cookie.set(
      cookie.names.prefrences,
      base64.encode(JSON.stringify(values)),
      2
    );

    var location = `/seferler/${values.OriginId}-${
      values.DestinationId
    }/${formatDate(new Date(values.DepartureDate))}`;

    window.location = location;
  });
});
