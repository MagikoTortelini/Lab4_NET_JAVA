# Lab4

Zadaniem laboratorium było zapoznanie się z frameworkiem Blazor oraz uczeniem maszynowym ML.NET.

## Zadanie 1 – Modyfikacja aplikacji Blazor

Pierwszym celem było zmodyfikowanie bazowej strony Blazor poprzez:

- wyświetlenie ilości ciepłych dni, czyli takich które posiadały minimum 15 stopni i więcej z prognozy pogodowej dostępnej z domyślnej strony Blazor,
- implementację filtra ukrywającego dni mające mniej niż 15 stopni,
- implementację filtrowania po wpisanej nazwie przez użytkownika w czasie rzeczywistym.

---

## Zadanie 2 – ML.NET

Drugim celem było zapoznanie się z uczeniem maszynowym ML.NET.

W tym celu należało:

- wytrenować model przewidujący sentyment użytkownika po wprowadzonej przez niego wiadomości,
- stworzyć nową stronę wyświetlającą:
  - predykowany sentyment,
  - poziom pewności predykcji,
  - pole do wprowadzenia zdania przez użytkownika.

---

## Zadanie 3 – Projekt filmowy w Blazor

Ostatnim zadaniem było zaimplementowanie nowego projektu Blazor wykorzystującego następujące funkcje:

1. Bazę danych do przechowywania danych o filmach,
2. Ukrywanie przycisków i stron dla niezalogowanych użytkowników,
3. Sortowanie filmów po ich cechach.

### Struktura bazy danych

Baza danych składała się z następujących pól:

1. Id filmu,
2. Tytuł filmu,
3. Opis filmu,
4. Data premiery,
5. Średnia ocena filmu,
6. Łączna wartość ocen filmu,
7. Ilość ocen,
8. Adres URL do zdjęcia filmu,
9. Gatunek filmu.

### Autoryzacja

Do ukrywania stron i elementów wykorzystano domyślne komponenty Blazor:

```razor
<AuthorizeView>
<Authorize>
```

### Sortowanie

W celu sortowania filmów po cechach wykorzystano komponent `Property` z parametrem `sortable`, który umożliwia sortowanie kolumn:

- rosnąco po pierwszym kliknięciu,
- malejąco po ponownym kliknięciu.

---

## Dodatkowe funkcjonalności

Dodatkowo zaimplementowano:

1. Logowanie do strony z wykorzystaniem logowania Google,
2. Model uczenia maszynowego do predykcji gatunków filmów na podstawie ich opisu,
3. Web Component YouTube pozwalający na odtwarzanie filmów po wpisaniu ich ID.
