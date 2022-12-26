mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
    console.log("Hello, console!");
  },


GetPlayerDataFromYandex: function () {

    MyGameInstance.SendMessage('Yandex', 'SetName', player.getName());
    MyGameInstance.SendMessage('Yandex', 'SetPhoto', player.getPhoto("medium"));

  },


});