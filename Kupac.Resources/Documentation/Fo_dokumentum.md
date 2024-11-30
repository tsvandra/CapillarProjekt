# Capillar Szalon Menedzsment Szoftver Dokumentáció

## Tartalom

1. [Bevezető](#bevezető)
2. [Projekt Áttekintés](#projekt-áttekintés)
3. [Követelmények](#követelmények)
4. [Architektúra Áttekintés](#architektúra-áttekintés)
5. [Fejlesztési Napló](#fejlesztési-napló)

## Bevezető

A Capillar egy fodrászszalon menedzsment szoftver, amely lehetőséget biztosít a megrendelések, bevételek, kiadások kezelésére, riportok generálására, valamint a szolgáltatások promóciójára képek feltöltésével. A rendszer célja, hogy egy egységes megoldást nyújtson a fodrászok számára, hogy könnyebben és átláthatóbban tudják kezelni a ügyfeleiket és a napi operatív feladatokat.

## Projekt Áttekintés

A Capillar projekt egy olyan szoftverfejlesztési folyamat eredménye, amelynek célja a felhasználó szalonjának működtetésének megkönnyítése és hatékonyságának növelése. A szoftver a következő kulcsfunkciókat biztosítja:

- **Ügyfélek kezelése**: Az ügyfélek hozzáadása, módosítása, törlése és listázása.
- **Időpontfoglalás kezelése**: Időpontok kezelése és megtekintése.
- **Riportok készítése**: A szalon működéséről, bevételekről és statisztikákról könnyen érthető kimutatások generálása.
- **Szolgáltatások promóciója**: Képek feltöltése a munkákról, amelyeket meg lehet osztani közösségi médiára,&#x20;
- valamint raktárkészlet vezetése az elvégzett fodrászati procedúrákhoz kapcsolódóan.

A projekt jelenlegi állása szerint a fejlesztés már elérte azt a szintet, hogy az ügyfélek adatainak kezelése teljesíthető, illetve a felhasználói felület formálása és stílusai elkezdtek kialakulni.

## Követelmények

A szoftver által teljesítendő követelmények:

- **Platform**: Windows Forms alapú alkalmazás, amelyet a feleséged könnyen tud kezelni.

- **Funkcionalitás**:

  - Ügyféladatok kezelése: hozzáadás, szerkesztés, törlés.
  - Időpontfoglalás kezelése.
  - Riportok generálása a bevételekről és ügyféladatokról.
  - Felhasználóbarát és vizuálisan vonzó felület.
  - Közösségi megosztási lehetőség.

- **Technikai Követelmények**:

  - **Programozási nyelv**: C# .NET 8.0.
  - **Adatbázis**: Microsoft SQL Server, az adatok tárolására (pl. ügyféladatok, időpontok).
  - **UI komponens**: Windows Forms, külön figyelmet fordítva a CustomDataGridView megvalósítására.

## Architektúra Áttekintés

A projekt fő komponensei és felépítése:

1. **KupacProjekt**: A fő könyvtár, amely tartalmazza az alprojektjeidet.

   - **Kupac**: Fő projekt, amely a backend logikáért felel.
   - **Kupac.UI.Customers**: Felhasználói felület az ügyfélek kezelésére.
   - **Kupac.UI.Orders**: A rendelések kezeléséhez tartozó felület (fejlesztés alatt).
   - **Kupac.UI.Shared**: Közös komponensek, mint pl. CustomDataGridView és egyéb megosztott UI elemek.

2. **Adatbázis kezelés**:

   - Az **Entity Framework Core 8.0.8** segítségével történik az adatbázis interakciók kezelése.
   - A fő adatbázis tábla a `Customers`, amely az ügyfélek adatait tartalmazza.

3. **Felület**:

   - **Windows Forms**: A könnyű kezelhetőség és testreszabhatóság érdekében.
   - **CustomDataGridView**: Egyedi DataGridView komponens, amely egységes stílussal rendelkezik, és tartalmazza az egérkezelést is a sorok kiemeléséhez.

## Fejlesztési Napló

### Dátum: [2024.7.27]

- **Kezdeti Projekt Strukturálás**: Létrehoztam a KupacProjekt könyvtárat, amely tartalmazza a **Kupac** backend és **Kupac.UI.Customers** frontend komponenseket.
- **Adatbázis Beállítása**: Létrehoztam az SQL Server adatbázist "Capillar" néven.
- **UI fejlesztés**: Elkezdtem a **CustomDataGridView** megvalósítását, amely biztosítja a vizuálisan egységes felületet.
- **Navigációs panel**: Létrehoztam a navigációs panelt a **MainForm**-ban, amely segíti a felhasználókat a fő oldalak közötti navigációban.

### Dátum: [2024.11.27]

- **Ügyfélek kezelése**: Elkészítettem az Ügyfél hozzáadása formot, amely lehetővé teszi új ügyfélek adatainak felvételét, illetve módosításukat.
- **Szin Beállítás**: A navigációs gombok stílusát és színváltását optimalizáltam, hogy könnyen észrevehető legyen, melyik gomb aktív.

---

Ez a dokumentáció elindítására szolgál, és ahogy haladsz tovább a fejlesztésben, rendszeresen bővítheted az egyes részleteket. Lépésről lépésre érdemes vezetni a fejlesztési naplót, valamint bővíteni az architektúra áttekintését az új komponensekkel. Remélem, hogy ez egy megfelelő kiindulópont számodra!

