window.getTomorrow = function () {
  var date = new Date();
  date.setDate(date.getDate() + 1);
  return date;
};

window.cookie = {
  names: { prefrences: "Prefrences" },
  set: function (key, value, exdays) {
    const d = new Date();
    d.setTime(d.getTime() + exdays * 24 * 60 * 60 * 1000);
    let expires = "expires=" + d.toUTCString();
    document.cookie = key + "=" + value + ";" + expires + ";path=/";
  },
  get: function (key) {
    let name = key + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(";");
    for (let i = 0; i < ca.length; i++) {
      let c = ca[i];
      while (c.charAt(0) == " ") {
        c = c.substring(1);
      }
      if (c.indexOf(name) == 0) {
        return c.substring(name.length, c.length);
      }
    }
    return "";
  },
  remove: function (key) {
    this.set(key, "", -1);
  },
};

window.base64 = {
  encode: function (str) {
    return btoa(encodeURIComponent(str));
  },
  decode: function (str) {
    return decodeURIComponent(atob(str));
  },
};

window.getFormValues = function (selector) {
  var values = {};
  $.each($(selector).serializeArray(), function (i, field) {
    if (field.name != "__RequestVerificationToken")
      values[field.name] = field.value;
  });
  return values;
};

window.validateForm = function (values) {
  for (const [_, value] of Object.entries(values)) {
    if (value == "" || value == undefined) {
      return false;
    }
  }
  return true;
};

function padTo2Digits(num) {
  return num.toString().padStart(2, "0");
}

window.formatDate = function (date) {
  return [
    date.getFullYear(),
    padTo2Digits(date.getMonth() + 1),
    padTo2Digits(date.getDate()),
  ].join("-");
};

window.getPrefrences = function () {
  var data = cookie.get(cookie.names.prefrences);
  if (data) {
    return JSON.parse(base64.decode(data));
  }
  return null;
};