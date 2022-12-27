mergeInto(LibraryManager.library, {

GetPlayerDataFromYandex: function () {

    MyGameInstance.SendMessage('Yandex', 'SetName', player.getName());
    MyGameInstance.SendMessage('Yandex', 'SetPhoto', player.getPhoto("medium"));

  },


});