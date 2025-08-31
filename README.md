# Firebase za sve uređaje.
Ovo je pripremljeni teren za komunikaciju sa Firebase putem svih uređaja u slučaju drugih projekata.


Prvo se mora kreirati firebase database.
Nakon što se kreirao database mora se odabrat Projec settings.
![Screenshot_29](https://github.com/IndigoGameStudio/Firebase-PC-and-WebGl-SDK/assets/29728342/ac14d18c-7d0b-4956-abd0-1c162e175837)

Unutar project settingsa se treba kreirati SDK za Web i Unity
![Screenshot_30](https://github.com/IndigoGameStudio/Firebase-PC-and-WebGl-SDK/assets/29728342/47302415-9950-45ec-9b23-4c7a30836b7e)


Podatke koje imamo za Web zamjeniti unutar HTML a podatze za Unity zamjeniti s dokumentom google.services.json
Također treba exportati RAR file po imenu  FirebaseCppApp-11_4_0.rar na lokaciji Assets\Firebase\Plugins\x86_64 Inside
zbog toga što ima više od 100 MB te se ne može pushat.

I to bi trebalo biti to projekt već sadrži dosta scena koje bi mogle posjetiti kako se što radi.
Također za sigurnost unutar APIs and Services od google treba staviti restrikcije kao i promjeniti firebase rules:

{
  "rules": {
    ".read": "auth.uid != null",
    ".write": "auth.uid != null"
  }
}
