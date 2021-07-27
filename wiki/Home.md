## 1 Einleitung
### 1.1 Motivation und Mitarbeiter
Dies ist die alternative Prüfungsleistung von Georg Nicholas Bachmann (65671) und Adrian Papst (66142). 

### 1.2 Grundlegende Idee
Wir möchten eine Textanalyse für Wikipedia implementieren. Ziel ist es ein Tool zu realisieren, welches Wikipedia nach Schlüsselworten durchsuchen und die Ergebnisse ausgeben kann.

### 1.3 der erste Plan
Dafür haben wir geplant mit C# ein Tool zu schreiben welches eine Eingabe (beliebiges Schlüsselwort für Wikipedia) als string ermöglicht und danach die große Enzyklopädie durchsucht. Die Ergebnisse sollen mit Hilfe eines neuen Fensters ausgegeben werden. Hierbei werden in Tabellenform der Seitenname, die URL, der letzte Bearbeitungsdatum, die Wortanzahl, die Größe in Byte und der Satz in dem der Suchbegriff vorkommt ausgegeben. Eine zusätzliche Funktion könnte sein das man die Ergebnisse sortieren kann.

### 1.6 Bestehender Code
Um uns die Arbeit etwas zu erleichtern werden Wir ein Bespielcode von Professor Doktor Sebastian Zug verwenden welches [hier](https://github.com/NULLtheworld/Softwareentwicklung_Projekt/wiki/Bestehender-Code-von-Professor-Doktor-Sebastian-Zug) gefunden werden kann. Ebenfalls nutzt dieser Code die Wiki.Net-Bibliothek, die man [hier](https://github.com/Voltstro-Studios/Wiki.Net) finden kann.

### 1.7 UML Diagramm
![](https://github.com/NULLtheworld/Softwareentwicklung_Projekt/blob/59781ac144251e47c35953f503c5cd41b8a7af46/WikisearchUML.png)

### 1.8 UML Source Code

```UML
@startuml
class Suchanfrage
{
    +AnfrageID: uint << get , set >>
    +Ergebnisanz: byte << get , set >>
    +Seite: ushort << get , set >>
    +Sprache: string << get , set >>
}

class WikiSearchSettings
{
    +RequestId: int << get , set >>
    +ResultLimit: int << get , set >>
    +ResultOffset: int << get , set >>
    +Language: string << get , set >>
}

class WikiSearchResponse 
{
    +searchString: string << get , set >>
    +searchSettings: WikiSearchSettings << get , set >>
}

class Suchausgabe
{
    +Titel: string << get >>
    +Wortanzahl: uint << get >>
    +Groesse: uint << get >>
    +Vorschau: string << get >>
    +URL: string << get >>
    +Auto: string << get >>
    +Änderungsdatum: DateTime << get >>
    
}

Suchanfrage -- WikiSearchSettings
WikiSearchSettings -- WikiSearchResponse
WikiSearchResponse -- Suchausgabe

@enduml

```