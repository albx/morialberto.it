---
title: There is no silver bullet - Introduzione
date: 2024-05-04T00:00:00+02:00
draft: true
keywords:
    - DDD
    - Metodologie
    - Patterns
    - software architecture
description: Nello sviluppo di una soluzione ci sono approcci che portano un beneficio indipendemente dal caso d'uso? In questa serie di post provo a raccontarvi la mia idea
---
Da un po’ di tempo a questa parte ho una idea che mi ronza in testa. Mi sono reso conto che quando mi approccio ad un problema provo sempre a ricondurmi a delle strutture prefissate e a degli approcci che, per la mia esperienza, mi hanno sempre (o quasi) portato ad un beneficio.

Da qui l’idea di preparare un talk che ho deciso di chiamare *“There is no silver bullet”* in cui mi piacerebbe provare a raccontare questo mio punto di vista e far nascere poi delle discussioni in merito.

Proprio per preparare questo talk, ho pensato anche di scrivere una serie di post sul blog che mi facesse da “blocco degli appunti”.

Partiamo da una premessa. Il titolo del talk è una citazione involontaria al paper **"No Silver Bullet—Essence and Accident in Software Engineering"** di Fred Brooks (cfr [https://www.cs.unc.edu/techreports/86-020.pdf](https://www.cs.unc.edu/techreports/86-020.pdf)).

Semplificando, Brooks divide la complessità in due tipologie: Essenziale e Accidentale. La prima è fondamentalmente la complessità insita nel problema che dobbiamo risolvere (ad es. quali sono le regole che governano il mio dominio?) e che è indipendente dalle scelte tecnologiche che facciamo. La complessità accidentale è legata a fattori esterni (ad esempio scelte tecnologiche).

In realtà la mia idea parte dal fatto che, dalla mia esperienza, anche le soluzioni più semplici hanno una complessità essenziale insita, che molto spesso viene fuori con il procedere degli sviluppi. Con questi presupposti l’affermazione *“la mia applicazione è molto semplice, deve solo leggere e scrivere in un database”* (cit.) potrebbe non essere più vera man mano che si scoperchia il vaso di pandora della complessità nascosta.

In questo contesto ci sono approcci, mutuati ad esempio da Domain Driven Design, che secondo me aiutano nel tenere sotto controllo questa complessità, facendosi meno male con l’avanzare degli sviluppi. 

Nei prossimi post volevo condividere il mio punto di vista, provando a toccare uno ad uno questi aspetti che sono, in ordine di apparizione, **Ubiquitous Language**, **Bounded Context** e **CQS / CQRS**.

Se siete curiosi non vi resta che aspettare il prossimo post, e se nel frattempo volete dire la vostra i commenti sono benvenuti 🙂

A presto!