---
title: "There is no silver bullet - CQS E CQRS"
date: 2024-06-01T00:00:00+02:00
draft: true
keywords:
    - CQS
    - CQRS
    - software architecture
description: Separare in modo netto la lettura dalla scrittura ci aiuta ad isolare i singoli comportamenti. Vediamo come CQS e CQRS ci possono aiutare
---
Dopo aver parlato di [Ubiquitous Language](https://www.morialberto.it/blog/there-is-no-silver-bullet/ubiquitous-language/) e [Bounded Context](https://www.morialberto.it/blog/there-is-no-silver-bullet/bounded-context/) rimane un altro argomento da affrontare: CQS e CQRS.

Sì in realtà sono due, avete ragione, ma sono strettamente collegati e quindi proverò a raccontarvi tutto come se fosse un singolo argomento.

Prima però proviamo a capire di cosa si tratta prendendoli uno alla volta.

### Cosa è CQS?

CQS è una sigla che sta per *Command Query Separation*. Coniato da Bertrand Meyer afferma che ogni unità di codice dovrebbe o restituire dei dati (Query) oppure alterare lo stato di un sistema (Command) ma mai entrambi.

In sostanza, provando a semplificare, se noi abbiamo un oggetto ogni suo metodo dovrebbe fare una sola cosa: o legge dei dati e li restituisce senza modificare nulla oppure modifica lo stato ma non ritorna dei dati.

### E alla fine arriva CQRS

CQRS sta per *Command-Query Responsibility Segregation* ed è un concetto definito da Greg Young.

Prende come base CQS e sposta la sua definizione dall’unità di codice agli attori di un sistema.

Per farla breve ogni attore (es. ogni oggetto) del mio sistema deve saper fare una ed una sola cosa: o restituire dei dati o modificare lo stato del sistema stesso.

### Ma quindi dove vuoi arrivare?

A questo punto la domanda è legittima. Il punto focale in questo caso è che, dal mio punto di vista, il vantaggio di separare in modo netto le responsabilità vale (quasi) sempre il prezzo del biglietto.

Sapere che ho dei punti che si occupano di leggere i dati senza side-effect e dei punti che invece sono preposti a modificare lo stato del mio sistema porta inevitabilmente a una maggiore sostenibilità e facilità sia nello sviluppo che, soprattutto, nella manutenzione e nell’evoluzione di un sistema.

Senza andare necessariamente su CQRS, anche solo partendo da avere dei metodi che si occupano di uno solo di questi due aspetti diminuisce la superficie di impatto e di conseguenza la possibilità di rompere quello che prima funzionava. 

Nel caso in cui, poi, la complessità del progetto richieda che la divisione venga fatta a livello di oggetto (o più genericamente attore di un sistema), allora CQRS diventa un ottimo amico.

Se ci pensiamo, si tratta di applicare il *Single Responsibility Principle*, cosa che, credo e spero, tutti noi cerchiamo di fare nel nostro quotidiano 🙂.

### Tutto troppo semplice, dove sta la fregatura?

In realtà da nessuna parte. Come per tutto c’è un trade-off. In linea generale applicare questi pattern porta a scrivere più codice, soprattutto se parliamo di CQRS. 

Se parliamo poi di testing il tutto è sicuramente più testabile ma l’implementazione di questi test non è banale, dato che il focus del mio test si sposta verso il comportamento e non più su come il codice è scritto.

La scelta va sempre calata nel contesto in cui siamo per capire se il tutto può essere un aiuto a risolvere il nostro problema e a soddisfare i requisiti che abbiamo.

### Ok, ma come lo implemento?

Tante chiacchere ma ancora non abbiamo parlato di come lo posso implementare.

Naturalmente i modi possono essere i più svariati. Cercando di fare un esempio:

**Lato query**: posso modellare ogni use case come un metodo di un servizio. L’implementazione potrebbe dipendere dallo strato di persistenza, nascondendo la capacità di modifica.

**Lato command**: posso utilizzare pattern come Transaction script, in cui ogni comando è sostanzialmente un metodo che prende in input l’insieme delle informazioni necessarie all’esecuzione del comando stesso. Oppure se ho un sistema che si basa su meccanismi di messaggistica, ogni comando potrebbe essere un messaggio che viene mandato su un service bus.

In ogni caso, **ricordiamoci sempre dell’Ubiquitous Language**! La cosa importante è che la nomenclatura che diamo deve definire il task specifico che viene eseguito.

E voi che ne pensate? Applicate o avete mai applicato CQS o CQRS?

Raccontatemi la vostra esperienza nei commenti. Ci vediamo al prossimo post.

A presto 🙂