---
title: There is no silver bullet - Bounded Context
date: 2024-05-18T00:00:00+02:00
draft: false
keywords:
    - bounded context
    - DDD
    - software architecture
description: Quando il nostro dominio diventa complesso, può essere utile suddividere il tutto in Bounded Context. Vediamo insieme di cosa si tratta.
---
Nello [scorso post](https://www.morialberto.it/blog/there-is-no-silver-bullet/ubiquitous-language/) abbiamo parlato di Ubiquitous Language, definendolo come un “linguaggio univoco, comune e rigoroso condiviso tra tutti gli stakeholder di un progetto”.

Questa definizione mette quindi come presupposto che l’ambiguità di significato su tutti i termini sia ridotta il più possibile se non del tutto assente.

Ma se ci trovassimo di fronte a delle ambiguità che non riusciamo a districare in nessun modo, come ci possiamo comportare? 

In questo caso ci viene in aiuto il concetto di **Bounded Context**.

{{<figure src="img/boundedcontext.png" alt="Bounded Context sales and support both with a product entity" title="https://martinfowler.com/bliki/BoundedContext.html" link="https://martinfowler.com/bliki/BoundedContext.html" >}}

### Cosa sono questi Bounded Context?

Provando a semplificare, possiamo definire un bounded context come una sezione del nostro dominio applicativo che vive di vita propria, ha il suo ubiquitous language, le sue regole e non ha nessun riferimento con altri bounded context.

Ad esempio, se esplorando il nostro dominio ci rendiamo conto che il reparto marketing e il reparto di assistenza clienti parlando del concetto di prodotto in due accezioni differenti allora ci troviamo di fronte a due bounded context: “marketing” e “assistenza” ognuno con la propria rappresentazione della classe “Prodotto”.

Adesso mi aspetto la domanda: “Ma quindi dobbiamo scrivere due volte la classe Prodotto?”. La risposta è “Sì, se questo concetto appartiene a due contesti differenti. Perchè i due concetti di prodotto avranno potenzialmente informazioni e comportamenti differenti”.

### Come posso far comunicare due Bounded Context

Abbiamo detto che ogni Bounded context è isolato e non deve avere riferimenti diretti ad altri contesti. Questa affermazione può far sorgere la domanda: “Ma quindi come posso fare se ho bisogno di farli comunicare?”.

Esistono a questo scopo delle strategie di **Context Mapping**, ovvero dei meccanismi che permettono ad un contesto di esporre le proprie informazioni verso l’esterno senza intaccare la propria struttura.

Secondo la letteratura queste strategie si dividono in tre macro-categorie:

- Customer-Supplier (Downstream-Upstream): quando uno dei due bounded context fornisce le informazioni all’altro. Chi espone le informazioni viene definito Supplier (o Upstream), chi riceve viene invece definito Customer (o Downstream). Sono esempi di questo pattern l’Anti-Corruption layer o l’Open Host
- Mutually dependent: quando i due Bounded context condividono tra di loro le informazioni. In questo caso il delivery dei due contesti deve essere contemporaneo dato che le modifiche ad un Bounded context impattano anche l’altro. Esempi famosi sono Partnership e Shared Kernel.
- Free: quando due Bounded context non collaborano e non comunicano tra di loro.

Definendo uno di questi approcci diventa possibile far comunicare due Bounded Context tra di loro, senza esporre in modo diretto la loro struttura.

### Che vantaggi mi porta questa divisione?

Dividere in contesti autonomi ci offre una netta separazione delle responsabilità. Se, ad esempio, assegniamo contesti diversi a parti del nostro team ognuno di essi sarà relativamente sicuro ed autonomo nello sviluppo.

Questo ci permette di concentrarci sugli obiettivi di quel contesto, riducendo i side-effect dovuti a modifiche a parti che non interessano direttamente il nostro bounded context.

### Ma è davvero tutto così facile?

Come sempre non è tutto oro quello che luccica.

Individuare i bounded context alla volte non è così semplice e, come per Ubiquitous Language, una buona esplorazione del dominio è fondamentale per identificarli e dividere nel modo corretto.

Una volta che abbiamo trovato i nostri bounded context è sempre bene ricordare che devono essere autonomi e non devono avere riferimenti ad altri contesti. Alle volte è facile cadere nella trappola di voler riutilizzare un pezzo che abbiamo già implementato in un altro contesto, in questo caso sfruttiamo le strategie di context mapping.

E voi cosa ne pensate? Vi è mai capitato di utilizzare i bounded context?

Raccontatemi la vostra esperienza nei commenti. Ci vediamo al prossimo post!

A presto 🙂
