---
title: "Viaggio nel Cloud"
date: 2023-02-21T21:48:11+01:00
publishDate: 2023-02-23T00:00:00+01:00
draft: false
description: Più di un anno fa ho migrato questo sito da un hosting condiviso ad Azure. Mi ero segnato di scrivere un post per raccontare questa storia. Il giorno è arrivato
keywords:
- blog
- azure static web apps
- azure
---
Ormai più di un anno fa questo sito è stato migrato da un hosting condiviso al Cloud, nello specifico Azure, e mi ero segnato di scrivere un post per raccontare questa storia di migrazione. Il giorno è arrivato.

La prima domanda da farsi è *“perchè scomodare il cloud per un insignificante sito statico come questo?”*. Per rispondere partiamo dall’inizio.

### Le origini
Questo sito era ospitato su un hosting condiviso per ragioni storiche. Le prime versioni erano scritte in PHP ed erano fondamentalmente la palestra per un *“mini-framework”* che mi ero realizzato nei primi anni come freelance e che mi serviva come base di partenza per i siti web che mi venivano richiesti.

L’attuale versione utilizza [Hugo](https://gohugo.io/) come motore di generazione dei contenuti, il che significa che a tutti gli effetti quanto viene pubblicato sono file statici html.

### E venne il giorno di Azure Static Web Apps
Ho scoperto [Azure Static Web Apps](https://learn.microsoft.com/en-us/azure/static-web-apps/overview) come servizio di Azure nel 2021 e devo ammettere che le feature che offriva *out-of-the-box* mi hanno incuriosito fin da subito. 

Provando a descrivere cosa sia in poche parole: si tratta di un servizio offerto da Microsoft Azure che permette di ospitare un contenuto statico in modo globalmente distribuito. Il deploy del codice viene fatto in modo automatico tramite GitHub Action o Pipeline di Azure DevOps a seconda di dove ospitate il vostro codice sorgente (per l’appunto GitHub piuttosto che Azure DevOps).

Il file che definisce il flusso di pubblicazione viene inoltre creato da Azure stesso nel momento in cui faccio il provisioning della risorsa, dandogli le informazioni di dove si trova il codice sorgente, su quale branch rimanere in ascolto e le cartelle dove andare a recuperare l’applicazione.

Detto questo se vi ho incuriosito e volete approfondire l’argomento, vi lascio qui sotto la registrazione del talk che ho tenuto al [Cloud Day 2022](https://www.cloudday.it/):

{{< youtube ZauB8-Z-1oI>}}

### Porting del sito
La decisione di portare anche questo sito su Azure Static Web Apps è stata dettata prima di tutto da fattori economici. Il prezzo dell’hosting originale è salito praticamente del doppio, mentre portandolo su Azure Static Web Apps ho potuto usufruire del piano gratuito, azzerando i costi, il che non è per niente male.

Al di là di questo, il fatto di avere una procedura automatica di pubblicazione dei contenuti è stato l’altro punto vincente. Prima il “deploy” (sì, è volutamente tra virgolette) era un processo manuale di trasferimento dei file via FTP. Sì è vero, il codice sorgente era su Azure DevOps e avrei potuto cercare di capire se esistesse un modo per caricare in modo automatico dei file via FTP tramite una pipeline, ma vogliamo mettere la comodità avere un flusso generato da un altro che fa il lavoro sporco per te e che soprattutto funziona meglio di quanto avrei potuto fare io?!

Altra cosa: il fatto di avere poi deciso di mettere il codice sorgente pubblico su GitHub permette a chi volesse di darmi feedback, segnalarmi problemi o proporre eventuali articoli di poterlo fare in modo agevole e veloce (basta aprire una issue [qui](https://github.com/albx/morialberto.it/issues)).

### Cosa ci riserva il futuro?
Detto questo l’idea è quella di provare a sfruttare il sito (soprattutto la sezione che contiene il blog) per sperimentare qualche chicca di interoperabilità con altri linguaggi. Ad esempio ho in cantiere lo studio di [**Blazor Custom Elements**](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-7.0#blazor-custom-elements) e potrebbe essere interessante capire come fare interagire Blazor con un sito totalmente statico.

Come al solito, se avete qualsiasi genere di feedback sono tutto orecchi :)

**A presto!**