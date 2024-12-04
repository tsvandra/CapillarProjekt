- komment mezo -OK
- ha a kozseg valtozik torlodjon ki a PSC

ugyfel tablahoz csatlakozik (id, név)
- Procedura lista
- Hajtipus lista
- Hajhossz lista
- Hajszin lista

metodus a becsult termerkfelhasznalasra a Procedura, Tipus es hossz kombinaciojabol.

- joslat keszites a raktarkeszlet es megrendelesek alapjan
- kosar osszeallitas a megrendelesek alapjan


Megrendeles tablahoz: 
- Id, UgyfelID, RelativeID, Idopont, ProceduraID, TermékID lista, Akcio, Becsult ár, Megjegyzes, hozzaadas datuma

Termek tablahoz: 
- Id, EAN, Név, Kiszereles, Gyarto, Termekcsalad, Hasznalati utmutato (megjegyzesként?)

Raktar: 
- ID, TermekID, Beszerzesi ar dph nelkul, DPH, Beszerzesi ar dph-val , Beszallito, Maradek_db_a_raktaron

Hozzátartozok tabla: (CustomerRelative)
- ID, CustomerId, FirstName, LastName, Note, IsActive

Hozzatartozok reszletei: (CustomerDetails)
- Id, CustomerType (Customer, Relative), PersonID (Customer.ID vagy RelativeID), Hajhossz, Hajtipus, Hajszin


  

