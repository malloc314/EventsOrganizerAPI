﻿**Spis treści**
- [Treść zadania](#treść-zadania "Treść zadania")
- [Opis zadania](#opis-zadania "Opis zadania")
- [Środowisko pracy](#środowisko-pracy "Środowisko pracy")
- [Użyte biblioteki](#użyte-biblioteki "Użyte biblioteki")
- [Dostępne punkty końcowe](#Dostępne-punkty-końcowe "Dostępne punkty końcowe")

# Treść zadania
Napisz proste **API** do organizowania i zapisywania na spotkania/eventy/seminaria.

API powinno umożliwiać:

+ Utworzenie spotkania
+ Usunięcie spotkania
+ Zwrócenie listy spotkań
+ Zapis uczestnika na spotkanie
+ Wymaganie do spotkania:
 + Obowiązuje limit 25 uczestników
+ Wymagania do uczestników:
 + Przy zapisie na spotkanie należy podać imię i adres e-mail
 
Aplikacja powinna być napisana w języku **C#** z wykorzystaniem platformy **.NET 5.0.**
Bazą danych, może być dowolna baza **SQL** np. **MSSQL**, **PostgreSQL**, **MySQL** lub dokumentowa np. **MongoDB**.

# Opis zadania
**Event organizer API** to prosta aplikacja backendowa napisana w standardzie **REST API** na potrzeby zadania rekrutacyjnego dla firmy **x-kom**. Z racji na prosty charakter zadania, celowo pominąłem szereg dobrych praktyk związanych z projektowaniem i programowaniem jak na przykład: **podział struktury projektu na warstwy zgodnie z czystą architekturą** czy **dostateczna walidacja danych wejściowych** etc.

# Środowisko pracy
Środowisko w jakim przyszło mi wykonać zadanie.
                    
Narzędzia | Wersja
------------- | :-------------:
C#  | `9.0`
ASP.NET Core | `5.0`
MS SQL Server | `18`

# Użyte biblioteki
Biblioteki i frameworki jakich użyłem do wykonania zadania.

Framework | Opis
------------- | -------------
Auto mapper  | Mapowanie modeli DTO
Entity | Mapowanie baz danych
Swagger | Dokumentacja API

# Dostępne punkty końcowe
Aktualnie dostępne punkty końcowe.

> Pobieranie wszystkich wydarzeń (widok administratora)

- [x] **`GET` /api/event/admin** 

> Pobieranie wszystkich wydarzeń (widok uczestnika)

- [x]  **`GET` /api/event/member** 

> Tworzenie nowego wydarzenia

- [x]  **`POST` /api/event**

> Usuwanie nowego wydarzenia

- [x]  **`DELETE` /api/event/{guid}**

***

> Zapisanie uczestnika na wybrane wydarzenie

- [x]  **`POST` /api/member** 
