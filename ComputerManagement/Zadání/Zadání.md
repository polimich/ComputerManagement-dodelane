# Aplikace pro správu počítačů na naší škole
## Co máte k dispozici
1. Kostru aplikace
1. Ne zcela kompletní pohled Index (Page)
1. Exporty testovacích dat

## Co máte udělat *(14 bodů)*
* Zkonfigurovat připojení k databázi přes `Startup.cs` a `appsettings.json` *(1)*
* Navrhnout DB modely `Room` a `Computer` *(1)* včetně všech **shadow** a **navigation** vlastností *(1)*, vytvořit funkční `DBContext` *(1)*
* Provést migrace a aplikovat je do databáze `Computers` (kterou si založíte na lokálním SQL serveru) *(1)*
* Naimportujte data z SQL souborů do čisté databáze *(0)*
* Zobrazit data na stránce index (IList<Computer> Computers) *(2)*
* Vytvořit a odeslat k zobrazení data se seznamem místností (RoomList) *(1)*
* Vytvořte kód pro změnu pořadí prvků dle parametru metody `OnGet` *(2)*
* Vytvořte kód pro filtrování zobrazených dat dle zvolené místnosti *(1)*
* Vytvořte kód pro filtrování zobrazených dat dle části názvu *(1)*
* Dokončete kód tak, aby se filtr zachovával i při změně řazení *(1)*
* Dolaďte aplikaci *(1)*

## Jak naimportovat testovací data
V SQL Server Object Exploreru
1. Pravým myšítkem na název databáze
1. New Query
1. Nakopírovat kód ze souboru ve složce Databáze - nejprve `Rooms`, pak `Computers`
1. zelený trojúhelník úplně vlevo spouští dotaz

## Struktura dat
Zachovejte pořadí položek, jinak nebude možné naimportovat testovací data.
### Room
    Identifikátor (int)
    Dlouhý název místnosti (string)
    Zkratka (string)

### Computer
    Identifikátor (int)
    Název počítače (string)
    Dlouhý popis (string)
    Popis procesoru (typ, frekvence = řetězec)
    Velikost operační paměti (int)
    Velikost lokálního disku (double)
    Rozbitý počítač? (bool)
