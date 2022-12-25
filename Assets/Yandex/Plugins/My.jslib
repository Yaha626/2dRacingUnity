mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
    console.log("Hello, console!");
  },


GetPlayerDataFromYandex: function () {
    console.log(player.getName());
    console.log(player.getPhoto("medium"));
  },


});