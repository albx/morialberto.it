---
title: There is no silver bullet - Ubiquitous Language
date: 2024-05-10T00:00:00+02:00
draft: false
keywords:
    - DDD
    - Ubiquitous language
    - software architecture
description: Ubiquitous language è un concetto espresso da Eric Evans nel "Blue book". In questo post proviamo a capire di cosa si tratta e come ci può aiutare
---
Dopo il [primo post introduttivo](https://www.morialberto.it/blog/there-is-no-silver-bullet/introduzione/) iniziamo ad addentrarci nel primo concetto di cui vorrei parlare: l’**Ubiquitous Language**.

### Cosa è l’Ubiquitous Language?

E’ un concetto espresso da Eric Evans nel libro *“Domain Driven Design: tackling complexity in the heart of software”*. Martin Fowler lo definisce così:

> a common, rigorous language between developers and users
> {{< fonte text="https://martinfowler.com/bliki/UbiquitousLanguage.html" url="https://martinfowler.com/bliki/UbiquitousLanguage.html" >}}

Provando a semplificare possiamo definirlo come un **linguaggio univoco, comune, rigoroso e condiviso tra tutti gli stakeholder che partecipano ad un progetto**.

### Ma io sono un developer, a cosa mi serve sapere questa cosa?

Quando ci approcciamo alla soluzione di un problema è importante che il problema da risolvere sia chiaro. Definire insieme agli altri attori un linguaggio comune che sia quello del business porta con sé un vantaggio non da poco: diminuisce la frizione tra i tecnici e i non tecnici, rendendoci più veloci nella comprensione dei requisiti e nella soluzione dei problemi che emergono durante lo sviluppo.

Purtroppo alla volte il nostro ego tecnico prende il sopravvento e sposta il nostro focus sul codice che scriviamo piuttosto che sul problema che dobbiamo risolvere.

Mano a mano che la complessità nella nostra codebase aumenta, avere un linguaggio comune che parte dal business e si riflette fino al nostro codice ci aiuta ad essere più reattivi e ci permette di essere più agili nel trovare il punto su cui dobbiamo intervenire, senza fare giochi di traduzione che alle volte non sono poi così scontati.

### In teoria è tutto bello, ma in pratica che strumenti ho a disposizione?

Trattandosi di un concetto non strettamente legato alla sola fase di sviluppo gli strumenti utilizzabili possono essere i più disparati.

Ad esempio cercare di mantenere l’ubiquitous language nella scrittura dei nostri backlog items / user stories è, secondo me, già un ottimo punto di partenza.

Spostandosi sul “lato dev”, l’approccio che, personalmente, cerco di applicare è utilizzare i test come definizione delle funzionalità, e in questo senso concentrarci sui comportamenti potrebbe essere una soluzione vincente.

Con questi presupposti utilizzare approcci come BDD (Behavior-Driven Development), che ci permette di scrivere i nostri scenari in un linguaggio più comprensibile anche agli stakeholder non tecnici, potrebbe risultare una strategia vincente.

E voi, Cosa ne pensate? Applicate già questi concetti nel vostro quotidiano?

Lasciatemi la vostra opinione nei commenti, ci vediamo al prossimo post!

A presto 🙂
