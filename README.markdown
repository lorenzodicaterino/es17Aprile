# Il sistema di gestione impiegati

Creare un sistema di gestione impiegati in ASP Web. Ogni impiegato è caratterizzato da: 1 Matricola 1 Nome 1 Cognome 1 Data Nascita 1 Ruolo 1 Reparto (da UNA TABELLA SUL DB) 1 Indirizzo di residenza 2 Città di residenza (da UNA TABELLA SUL DB) 2 Provincia di residenza (da UNA TABELLA SUL DB) a. Sviluppare tutti i punti 1 b. Sviluppare i punti 2 (possibilmente con AJAX o Fetch) c. Sviluppare un campo di ricerca di impiegati per matricola
d. HARD: Collegare con una relazione, il popolamento della selectbox di Città deve essere collegato alla selezione della provincia (es. Se seleziono AQ, all'interno della select di Città devono essere presenti solo gli elementi che hanno la provincia AQ).

```sql
CREATE TABLE reparto(
repartoID INT PRIMARY KEY IDENTITY(1,1),
nome_reparto VARCHAR(250) NOT NULL,
);

CREATE TABLE provincia(
provinciaID INT PRIMARY KEY IDENTITY(1,1),
sigla VARCHAR(2) NOT NULL UNIQUE
);

CREATE TABLE citta(
cittaID INT PRIMARY KEY IDENTITY(1,1),
nome_citta VARCHAR(300) NOT NULL UNIQUE,
provinciaRIF INT NOT NULL,
FOREIGN KEY (provinciaRIF) REFERENCES provincia(provinciaID) ON DELETE CASCADE
);

CREATE TABLE impiegato(
impiegatoID INT PRIMARY KEY IDENTITY(1,1),
matricola VARCHAR(250) NOT NULL UNIQUE,
nome_impiegato VARCHAR(300) NOT NULL,
cognome_impiegato VARCHAR(300) NOT NULL,
data_nascita_impiegato DATE,
ruolo_impiegato VARCHAR(250) NOT NULL,
indirizzo_impiegato VARCHAR(250) NOT NULL,
repartoRIF INT NOT NULL,
cittaRIF VARCHAR(250) NOT NULL
FOREIGN KEY (repartoRIF) REFERENCES reparto(repartoID) ON DELETE CASCADE
);
```
