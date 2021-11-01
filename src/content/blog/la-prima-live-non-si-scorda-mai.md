---
title: "La prima live non si scorda mai"
date: 2020-07-14T17:22:37+02:00
publishDate: 2020-07-18T00:00:00+02:00
draft: false
description: 'Sabato 4 Luglio sono stato ospite di Andrea Pollini sul suo canale Twitch per chiaccherare di Blazor e ASP.NET Core. Essendo stato il mio debutto come "speaker" ho voluto scrivere questo post per analizzare come è andata questa bella esperienza.'
keywords:
- live
- twitch
- blazor
- asp.net core
- .net core
---

Sabato 4 Luglio sono stato ospitato da [Andrea Pollini](https://andreapollini.com/) sul suo canale [Twitch](https://www.twitch.tv/profandreapollini) per fare una chiaccherata sul mondo .NET, in particolare ci siamo concentrati su **Blazor** e **ASP.NET Core**. Da questa collaborazione è nata questa live:

{{< youtube kZw_Gf1sO3U>}}

È stato il mio debutto come "speaker" (volutamente tra virgolette) e devo ammettere che (emozione a parte) è stata un'esperienza molto stimolante e divertente. Le persone che hanno avuto la pazienza (o il coraggio) di seguirmi nei miei discorsi per più di 3 ore hanno ravvivato il tutto con molte domande ed interventi e sono riusciti a renderla interattiva come speravo.

Ma di cosa abbiamo parlato? Come dicevo prima gli argomenti principali sono stati Blazor WebAssembly e ASP.NET Core.

L'obiettivo iniziale che mi ero posto era di non usare slide ed infatti ho cercato, utilizzando il template di progetto standard di Visual Studio, di spiegare i concetti di base che stanno dietro a Blazor, arrivando a creare poi una piccola Single Page Application che simulasse l'aggiunta di prodotto ad un carrello.

Oltre alla parte di coding vera e propria ho voluto anche condividere la mia esperienza e quello che in questi anni mi è stato trasmesso sulla parte di analisi di un problema per capire quali sono gli attori che intervengono e accennando di conseguenza a Domain Driven Design come un possibile asset strategico che può aiutare nella parte di design di un software.

Per chi si fosse perso la live o non avesse il tempo di guardare la registrazione su youtube (linkata sopra), vi lascio qui sotto alcuni link utili che sono venuti fuori durante il talk:

- **https://blazor.net**: è il link alla pagina ufficiale di Blazor. Qui trovate tutte le informazioni e le guide ufficiali di Microsoft per iniziare ad utilizzare questa fantastica (dal mio punto di vista) tecnologia che permette di sviluppare SPA utilizzando C# come linguaggio.
- **https://asp.net**: questa è la pagina ufficiale di ASP.NET Core, come sopra qui trovate tutta la documentazione ufficiale di ASP.NET Core
- **https://github.com/AdrienTorris/awesome-blazor**: in questa repository di GitHub trovate una serie di link utili al mondo Blazor, tutorial, talk, articoli, podcast e progetti vari. Se siete interessati a Blazor il mio consiglio è quello di salvarla tra i preferiti e darci un'occhiata almeno una volta al giorno :)
- **https://github.com/albx/blazor-demos**: in questa repository ho messo il codice creato durante la live (lo trovate nella cartella CarrelloProdotti) e punterò, man mano che sperimenterò i vari aspetti di Blazor, a pubblicare altri esempi. Sentitevi liberi di forkare, aprire Issue e Pull Request se avete consigli o volete contribuire.
- **https://github.com/albx/WebTodoList**: è un progetto di esempio (una semplice todolist) che avevo messo in piedi quando ho iniziato a studiare e provare Blazor. L'obiettivo era quello di confrontare Blazor WebAssembly con un altro framework client-side (in questo caso ho scelto React) per creare dei client che si interfacciassero con le stesse API (in questo caso scritte in ASP.NET Core). Come per il link sopra, sentitevi liberi di aprire issue, forkare e fare PR se avete qualsiasi tipo di idea.

Ultimo suggerimento che ho dato è stato quello di condividere attraverso le community, che per quanto riguarda il mondo .NET sono tantissime. Anche qui le community che ho citato durante la live sono state queste:

- **UGIdotNET** (https://www.ugidotnet.org)
- **ASPItalia** (https://www.aspitalia.com)
- **Blazor Developer Italiani** (https://blazordev.it)

Queste sono solo tre di un ecosistema vastissimo (non me ne vogliano le altre), quindi l'invito è sempre quello di partecipare alle varie attività di community che trovate, sia partecipando agli eventi che organizzano sia, magari, contribuendo scrivendo articoli, senza aver paura che quello che stiamo scrivendo possa essere interessante o meno e tenendo conto che le persone che fanno revisione dei contenuti sulle community sono molto brave a darvi consigli per migliorare.

Ma questo post non vuole essere solo un riepilogo di quanto detto durante la live. 

Essendo stato il mio battesimo l'idea era quella di mettere nero su bianco le mie considerazioni e fare una sorta di retrospettiva per capire come poter migliorare le mie ancora scarse capacità di public speaking.

Questi sono stati per me i punti critici da sistemare (dopo essermi riguardato):

- Devo assolutamente rallentare e parlare meno velocemente. Mi sono reso conto che in parecchie occasioni accelero troppo e mi mangio le parole, il che non è ottimale se mi voglio far capire :)
- Qualche strafalcione nella scelta dei termini che ho usato. Ad es. ad inizio live, parlando del terminal ho detto che stavo aspettando che Microsoft rilasciasse WSL 2. In verità WSL 2 è già stato rilasciato, quello che intendevo è che stavo aspettando che la mia versione di Windows10 fosse quella richiesta per attivare la versione 2 del Windows Subsystem for Linux

Detto questo, se avete 3 ore da perdere e vi va di guardare la live, qualsiasi genere di feedback è davvero ben accetto!